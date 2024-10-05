namespace EscPOS.Emulator
{
	partial class MainForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.textBoxMessage = new System.Windows.Forms.TextBox();
			this.buttonStartServer = new System.Windows.Forms.Button();
			this.labelStatus = new System.Windows.Forms.Label();
			this.checkBoxFont = new System.Windows.Forms.CheckBox();
			this.SuspendLayout();
			// 
			// textBoxMessage
			// 
			this.textBoxMessage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.textBoxMessage.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBoxMessage.Location = new System.Drawing.Point(12, 55);
			this.textBoxMessage.Multiline = true;
			this.textBoxMessage.Name = "textBoxMessage";
			this.textBoxMessage.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.textBoxMessage.Size = new System.Drawing.Size(453, 518);
			this.textBoxMessage.TabIndex = 0;
			// 
			// buttonStartServer
			// 
			this.buttonStartServer.Location = new System.Drawing.Point(390, 12);
			this.buttonStartServer.Name = "buttonStartServer";
			this.buttonStartServer.Size = new System.Drawing.Size(75, 23);
			this.buttonStartServer.TabIndex = 1;
			this.buttonStartServer.Text = "Start";
			this.buttonStartServer.UseVisualStyleBackColor = true;
			this.buttonStartServer.Click += new System.EventHandler(this.buttonStartServer_Click);
			// 
			// labelStatus
			// 
			this.labelStatus.AutoSize = true;
			this.labelStatus.Location = new System.Drawing.Point(24, 21);
			this.labelStatus.Name = "labelStatus";
			this.labelStatus.Size = new System.Drawing.Size(50, 13);
			this.labelStatus.TabIndex = 2;
			this.labelStatus.Text = "Ready...";
			// 
			// checkBoxFont
			// 
			this.checkBoxFont.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.checkBoxFont.Appearance = System.Windows.Forms.Appearance.Button;
			this.checkBoxFont.AutoSize = true;
			this.checkBoxFont.Location = new System.Drawing.Point(12, 578);
			this.checkBoxFont.Name = "checkBoxFont";
			this.checkBoxFont.Size = new System.Drawing.Size(52, 23);
			this.checkBoxFont.TabIndex = 4;
			this.checkBoxFont.Text = "Courier";
			this.checkBoxFont.UseVisualStyleBackColor = true;
			this.checkBoxFont.CheckedChanged += new System.EventHandler(this.checkBoxFont_CheckedChanged);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(477, 605);
			this.Controls.Add(this.checkBoxFont);
			this.Controls.Add(this.labelStatus);
			this.Controls.Add(this.buttonStartServer);
			this.Controls.Add(this.textBoxMessage);
			this.Font = new System.Drawing.Font("Tahoma", 8.25F);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "MainForm";
			this.Text = "Tarsier Virtual Network POS Printer";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox textBoxMessage;
		private System.Windows.Forms.Button buttonStartServer;
		private System.Windows.Forms.Label labelStatus;
		private System.Windows.Forms.CheckBox checkBoxFont;
	}
}

