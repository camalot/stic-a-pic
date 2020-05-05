namespace Photoroid {
	partial class Options {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose ( bool disposing ) {
			if ( disposing && ( components != null ) ) {
				components.Dispose ( );
			}
			base.Dispose ( disposing );
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent ( ) {
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Options));
			this.panel1 = new System.Windows.Forms.Panel();
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabGeneral = new System.Windows.Forms.TabPage();
			this.startupOption = new System.Windows.Forms.CheckBox();
			this.ok = new System.Windows.Forms.Button();
			this.tabAbout = new System.Windows.Forms.TabPage();
			this.supportPatreon = new System.Windows.Forms.Button();
			this.supportPaypal = new System.Windows.Forms.Button();
			this.supportTwitch = new System.Windows.Forms.Button();
			this.supportGithub = new System.Windows.Forms.Button();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.version = new System.Windows.Forms.Label();
			this.copyright = new System.Windows.Forms.Label();
			this.checkForUpdates = new System.Windows.Forms.Button();
			this.panel1.SuspendLayout();
			this.tabControl1.SuspendLayout();
			this.tabGeneral.SuspendLayout();
			this.tabAbout.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.ok);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panel1.Location = new System.Drawing.Point(0, 254);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(519, 44);
			this.panel1.TabIndex = 0;
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.tabGeneral);
			this.tabControl1.Controls.Add(this.tabAbout);
			this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tabControl1.Location = new System.Drawing.Point(0, 0);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(519, 254);
			this.tabControl1.TabIndex = 1;
			// 
			// tabGeneral
			// 
			this.tabGeneral.Controls.Add(this.startupOption);
			this.tabGeneral.Location = new System.Drawing.Point(4, 22);
			this.tabGeneral.Name = "tabGeneral";
			this.tabGeneral.Padding = new System.Windows.Forms.Padding(3);
			this.tabGeneral.Size = new System.Drawing.Size(511, 228);
			this.tabGeneral.TabIndex = 0;
			this.tabGeneral.Text = "General";
			this.tabGeneral.UseVisualStyleBackColor = true;
			// 
			// startupOption
			// 
			this.startupOption.AutoSize = true;
			this.startupOption.Location = new System.Drawing.Point(9, 7);
			this.startupOption.Name = "startupOption";
			this.startupOption.Size = new System.Drawing.Size(154, 17);
			this.startupOption.TabIndex = 0;
			this.startupOption.Text = "&Start when Windows Starts";
			this.startupOption.UseVisualStyleBackColor = true;
			this.startupOption.CheckedChanged += new System.EventHandler(this.StartupOption_CheckedChanged);
			// 
			// ok
			// 
			this.ok.Location = new System.Drawing.Point(432, 9);
			this.ok.Name = "ok";
			this.ok.Size = new System.Drawing.Size(75, 23);
			this.ok.TabIndex = 0;
			this.ok.Text = "&OK";
			this.ok.UseVisualStyleBackColor = true;
			this.ok.Click += new System.EventHandler(this.Ok_Click);
			// 
			// tabAbout
			// 
			this.tabAbout.Controls.Add(this.checkForUpdates);
			this.tabAbout.Controls.Add(this.copyright);
			this.tabAbout.Controls.Add(this.version);
			this.tabAbout.Controls.Add(this.pictureBox1);
			this.tabAbout.Controls.Add(this.supportPatreon);
			this.tabAbout.Controls.Add(this.supportPaypal);
			this.tabAbout.Controls.Add(this.supportTwitch);
			this.tabAbout.Controls.Add(this.supportGithub);
			this.tabAbout.Location = new System.Drawing.Point(4, 22);
			this.tabAbout.Name = "tabAbout";
			this.tabAbout.Size = new System.Drawing.Size(511, 228);
			this.tabAbout.TabIndex = 1;
			this.tabAbout.Text = "About";
			this.tabAbout.UseVisualStyleBackColor = true;
			// 
			// supportPatreon
			// 
			this.supportPatreon.BackColor = System.Drawing.Color.DarkRed;
			this.supportPatreon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.supportPatreon.ForeColor = System.Drawing.Color.White;
			this.supportPatreon.Location = new System.Drawing.Point(379, 197);
			this.supportPatreon.Name = "supportPatreon";
			this.supportPatreon.Size = new System.Drawing.Size(124, 23);
			this.supportPatreon.TabIndex = 7;
			this.supportPatreon.Text = "💜 Support on Patreon";
			this.supportPatreon.UseVisualStyleBackColor = false;
			this.supportPatreon.Visible = false;
			this.supportPatreon.Click += new System.EventHandler(this.SupportPatreon_Click);
			// 
			// supportPaypal
			// 
			this.supportPaypal.BackColor = System.Drawing.Color.RoyalBlue;
			this.supportPaypal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.supportPaypal.ForeColor = System.Drawing.Color.White;
			this.supportPaypal.Location = new System.Drawing.Point(379, 168);
			this.supportPaypal.Name = "supportPaypal";
			this.supportPaypal.Size = new System.Drawing.Size(124, 23);
			this.supportPaypal.TabIndex = 6;
			this.supportPaypal.Text = "💜 Support on Paypal";
			this.supportPaypal.UseVisualStyleBackColor = false;
			this.supportPaypal.Click += new System.EventHandler(this.SupportPaypal_Click);
			// 
			// supportTwitch
			// 
			this.supportTwitch.BackColor = System.Drawing.Color.SlateBlue;
			this.supportTwitch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.supportTwitch.ForeColor = System.Drawing.Color.White;
			this.supportTwitch.Location = new System.Drawing.Point(379, 139);
			this.supportTwitch.Name = "supportTwitch";
			this.supportTwitch.Size = new System.Drawing.Size(124, 23);
			this.supportTwitch.TabIndex = 5;
			this.supportTwitch.Text = "💜 Support on Twitch";
			this.supportTwitch.UseVisualStyleBackColor = false;
			this.supportTwitch.Click += new System.EventHandler(this.SupportTwitch_Click);
			// 
			// supportGithub
			// 
			this.supportGithub.BackColor = System.Drawing.Color.White;
			this.supportGithub.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.supportGithub.ForeColor = System.Drawing.Color.Black;
			this.supportGithub.Location = new System.Drawing.Point(379, 110);
			this.supportGithub.Name = "supportGithub";
			this.supportGithub.Size = new System.Drawing.Size(124, 23);
			this.supportGithub.TabIndex = 4;
			this.supportGithub.Text = "💜 Support on Github";
			this.supportGithub.UseVisualStyleBackColor = false;
			this.supportGithub.Click += new System.EventHandler(this.SupportGithub_Click);
			// 
			// pictureBox1
			// 
			this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(8, 8);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(187, 212);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 8;
			this.pictureBox1.TabStop = false;
			// 
			// version
			// 
			this.version.Location = new System.Drawing.Point(204, 8);
			this.version.Name = "version";
			this.version.Size = new System.Drawing.Size(299, 23);
			this.version.TabIndex = 9;
			this.version.Text = "[Version]";
			this.version.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// copyright
			// 
			this.copyright.Location = new System.Drawing.Point(201, 35);
			this.copyright.Name = "copyright";
			this.copyright.Size = new System.Drawing.Size(302, 23);
			this.copyright.TabIndex = 10;
			this.copyright.Text = "[Copyright]";
			this.copyright.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// checkForUpdates
			// 
			this.checkForUpdates.BackColor = System.Drawing.Color.DarkGreen;
			this.checkForUpdates.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.checkForUpdates.ForeColor = System.Drawing.Color.White;
			this.checkForUpdates.Location = new System.Drawing.Point(379, 61);
			this.checkForUpdates.Name = "checkForUpdates";
			this.checkForUpdates.Size = new System.Drawing.Size(124, 23);
			this.checkForUpdates.TabIndex = 11;
			this.checkForUpdates.Text = "📌 Check For Updates";
			this.checkForUpdates.UseVisualStyleBackColor = false;
			this.checkForUpdates.Click += new System.EventHandler(this.CheckForUpdates_Click);
			// 
			// Options
			// 
			this.AcceptButton = this.ok;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSize = true;
			this.ClientSize = new System.Drawing.Size(519, 298);
			this.Controls.Add(this.tabControl1);
			this.Controls.Add(this.panel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "Options";
			this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Options";
			this.panel1.ResumeLayout(false);
			this.tabControl1.ResumeLayout(false);
			this.tabGeneral.ResumeLayout(false);
			this.tabGeneral.PerformLayout();
			this.tabAbout.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tabGeneral;
		private System.Windows.Forms.CheckBox startupOption;
		private System.Windows.Forms.Button ok;
		private System.Windows.Forms.TabPage tabAbout;
		private System.Windows.Forms.Label copyright;
		private System.Windows.Forms.Label version;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Button supportPatreon;
		private System.Windows.Forms.Button supportPaypal;
		private System.Windows.Forms.Button supportTwitch;
		private System.Windows.Forms.Button supportGithub;
		private System.Windows.Forms.Button checkForUpdates;
	}
}