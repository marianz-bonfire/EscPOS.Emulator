using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Net;
using System.Threading;
using System.Reflection.Emit;

namespace EscPOS.Emulator
{
	public partial class MainForm : Form
	{
		private Thread serverThread = null;
		private bool running = false;
		public MainForm() {
			InitializeComponent();
		}

		private void StartServer() {
			// Define the endpoint and create the server socket
			IPEndPoint endPoint = new IPEndPoint(IPAddress.Any, 9100);
			Socket serverSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

			try {
				// Bind the socket to the endpoint and start listening for incoming connections
				serverSocket.Bind(endPoint);
				serverSocket.Listen(10);

				Console.WriteLine("Server is listening on port 9100...");

				while (running) {
					// Accept a client connection
					Socket clientSocket = serverSocket.Accept();
					Console.WriteLine("Client connected.");
					AddMessage("", true);
					// Handle the client connection in a separate thread
					Thread clientThread = new Thread(HandleClient);
					clientThread.Start(clientSocket);
				}
			} catch (Exception ex) {
				Console.WriteLine("Error: " + ex.Message);
			} finally {
				serverSocket.Close();
			}
		}

		void HandleClient(object client) {
			Socket clientSocket = (Socket)client;
			byte[] buffer = new byte[4096];
			int bytesRead;

			try {
				while ((bytesRead = clientSocket.Receive(buffer)) > 0) {
					string message = Encoding.ASCII.GetString(buffer, 0, bytesRead);
					Console.WriteLine("Received message: " + message);
					//AddMessage(message, false);
					String[] chunks = message.Split(new string[] { "\r\n", "\r", "\n" },StringSplitOptions.None);
					foreach (string chunk in chunks) {
						AddMessage(chunk, false);
					}
					// Echo the message back to the client
					clientSocket.Send(buffer, bytesRead, SocketFlags.None);
				}
			} catch (Exception ex) {
				Console.WriteLine("Client error: " + ex.Message);
			} finally {
				clientSocket.Close();
			}
		}

		void AddMessage(string message, bool clear = false) {
			
			if (textBoxMessage.InvokeRequired) {
				if (clear) {
					textBoxMessage.Invoke(new Action(() => textBoxMessage.Text = ""));
				} else {
					textBoxMessage.Invoke(new Action(() => textBoxMessage.Text += (message + Environment.NewLine)));
				}
			} else {
				if (clear) {
					textBoxMessage.Text = "";
				} else {
					textBoxMessage.Text += (message+ Environment.NewLine);
				}
			}
		}

		private void buttonStartServer_Click(object sender, EventArgs e) {
			if (buttonStartServer.Text.Equals("Start")) {
				buttonStartServer.Text = "Stop";
				running = true;
				AddMessage("", true);
				labelStatus.Text = "Listening Sirius POS print request...";
				serverThread = new Thread(new ThreadStart(StartServer));
				serverThread.Start();
			} else {
				running = false;
				labelStatus.Text = "Server stopped...";
				buttonStartServer.Text = "Start";
				AddMessage("", true);
				if (serverThread != null) {
					serverThread.Abort();
					serverThread.Join();
					serverThread = null;
				}
			}
		}

		private void checkBoxFont_CheckedChanged(object sender, EventArgs e) {
			textBoxMessage.Font = checkBoxFont.Checked ? new Font("Consolas", 10f) : new Font("Courier New", 10f);
			checkBoxFont.Text = checkBoxFont.Checked ? "Courier" : "Consolas";
		}
	}
}