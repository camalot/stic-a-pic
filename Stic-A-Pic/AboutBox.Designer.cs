namespace Photoroid {
	partial class AboutBox {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutBox));
			this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
			this.logoPictureBox = new System.Windows.Forms.PictureBox();
			this.labelProductName = new System.Windows.Forms.Label();
			this.labelVersion = new System.Windows.Forms.Label();
			this.labelCopyright = new System.Windows.Forms.Label();
			this.labelCompanyName = new System.Windows.Forms.Label();
			this.okButton = new System.Windows.Forms.Button();
			this.panel1 = new System.Windows.Forms.Panel();
			this.supportGithub = new System.Windows.Forms.Button();
			this.supportTwitch = new System.Windows.Forms.Button();
			this.supportPaypal = new System.Windows.Forms.Button();
			this.supportPatreon = new System.Windows.Forms.Button();
			this.tableLayoutPanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).BeginInit();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// tableLayoutPanel
			// 
			this.tableLayoutPanel.ColumnCount = 2;
			this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33F));
			this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 67F));
			this.tableLayoutPanel.Controls.Add(this.logoPictureBox, 0, 0);
			this.tableLayoutPanel.Controls.Add(this.labelProductName, 1, 0);
			this.tableLayoutPanel.Controls.Add(this.labelVersion, 1, 1);
			this.tableLayoutPanel.Controls.Add(this.labelCopyright, 1, 2);
			this.tableLayoutPanel.Controls.Add(this.labelCompanyName, 1, 3);
			this.tableLayoutPanel.Controls.Add(this.okButton, 1, 5);
			this.tableLayoutPanel.Controls.Add(this.panel1, 1, 4);
			this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel.Location = new System.Drawing.Point(9, 9);
			this.tableLayoutPanel.Name = "tableLayoutPanel";
			this.tableLayoutPanel.RowCount = 6;
			this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
			this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
			this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
			this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.924528F));
			this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 51.69811F));
			this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
			this.tableLayoutPanel.Size = new System.Drawing.Size(417, 265);
			this.tableLayoutPanel.TabIndex = 0;
			// 
			// logoPictureBox
			// 
			this.logoPictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.logoPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("logoPictureBox.Image")));
			this.logoPictureBox.Location = new System.Drawing.Point(3, 3);
			this.logoPictureBox.Name = "logoPictureBox";
			this.tableLayoutPanel.SetRowSpan(this.logoPictureBox, 6);
			this.logoPictureBox.Size = new System.Drawing.Size(131, 259);
			this.logoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.logoPictureBox.TabIndex = 12;
			this.logoPictureBox.TabStop = false;
			// 
			// labelProductName
			// 
			this.labelProductName.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelProductName.Location = new System.Drawing.Point(143, 0);
			this.labelProductName.Margin = new System.Windows.Forms.Padding(6, 0, 3, 0);
			this.labelProductName.MaximumSize = new System.Drawing.Size(0, 17);
			this.labelProductName.Name = "labelProductName";
			this.labelProductName.Size = new System.Drawing.Size(271, 17);
			this.labelProductName.TabIndex = 19;
			this.labelProductName.Text = "Product Name";
			this.labelProductName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// labelVersion
			// 
			this.labelVersion.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelVersion.Location = new System.Drawing.Point(143, 26);
			this.labelVersion.Margin = new System.Windows.Forms.Padding(6, 0, 3, 0);
			this.labelVersion.MaximumSize = new System.Drawing.Size(0, 17);
			this.labelVersion.Name = "labelVersion";
			this.labelVersion.Size = new System.Drawing.Size(271, 17);
			this.labelVersion.TabIndex = 0;
			this.labelVersion.Text = "Version";
			this.labelVersion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// labelCopyright
			// 
			this.labelCopyright.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelCopyright.Location = new System.Drawing.Point(143, 52);
			this.labelCopyright.Margin = new System.Windows.Forms.Padding(6, 0, 3, 0);
			this.labelCopyright.MaximumSize = new System.Drawing.Size(0, 17);
			this.labelCopyright.Name = "labelCopyright";
			this.labelCopyright.Size = new System.Drawing.Size(271, 17);
			this.labelCopyright.TabIndex = 21;
			this.labelCopyright.Text = "Copyright";
			this.labelCopyright.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// labelCompanyName
			// 
			this.labelCompanyName.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelCompanyName.Location = new System.Drawing.Point(143, 78);
			this.labelCompanyName.Margin = new System.Windows.Forms.Padding(6, 0, 3, 0);
			this.labelCompanyName.MaximumSize = new System.Drawing.Size(0, 17);
			this.labelCompanyName.Name = "labelCompanyName";
			this.labelCompanyName.Size = new System.Drawing.Size(271, 17);
			this.labelCompanyName.TabIndex = 22;
			this.labelCompanyName.Text = "Company Name";
			this.labelCompanyName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// okButton
			// 
			this.okButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.okButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.okButton.Location = new System.Drawing.Point(339, 239);
			this.okButton.Name = "okButton";
			this.okButton.Size = new System.Drawing.Size(75, 23);
			this.okButton.TabIndex = 24;
			this.okButton.Text = "&OK";
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.supportPatreon);
			this.panel1.Controls.Add(this.supportPaypal);
			this.panel1.Controls.Add(this.supportTwitch);
			this.panel1.Controls.Add(this.supportGithub);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel1.Location = new System.Drawing.Point(140, 102);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(274, 131);
			this.panel1.TabIndex = 25;
			// 
			// supportGithub
			// 
			this.supportGithub.BackColor = System.Drawing.Color.White;
			this.supportGithub.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.supportGithub.ForeColor = System.Drawing.Color.Black;
			this.supportGithub.Location = new System.Drawing.Point(67, 3);
			this.supportGithub.Name = "supportGithub";
			this.supportGithub.Size = new System.Drawing.Size(124, 23);
			this.supportGithub.TabIndex = 0;
			this.supportGithub.Text = "💜 Support on Github";
			this.supportGithub.UseVisualStyleBackColor = false;
			this.supportGithub.Click += new System.EventHandler(this.SupportGithub_Click);
			// 
			// supportTwitch
			// 
			this.supportTwitch.BackColor = System.Drawing.Color.SlateBlue;
			this.supportTwitch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.supportTwitch.ForeColor = System.Drawing.Color.White;
			this.supportTwitch.Location = new System.Drawing.Point(67, 32);
			this.supportTwitch.Name = "supportTwitch";
			this.supportTwitch.Size = new System.Drawing.Size(124, 23);
			this.supportTwitch.TabIndex = 1;
			this.supportTwitch.Text = "💜 Support on Twitch";
			this.supportTwitch.UseVisualStyleBackColor = false;
			this.supportTwitch.Click += new System.EventHandler(this.SupportTwitch_Click);
			// 
			// supportPaypal
			// 
			this.supportPaypal.BackColor = System.Drawing.Color.RoyalBlue;
			this.supportPaypal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.supportPaypal.ForeColor = System.Drawing.Color.White;
			this.supportPaypal.Location = new System.Drawing.Point(67, 61);
			this.supportPaypal.Name = "supportPaypal";
			this.supportPaypal.Size = new System.Drawing.Size(124, 23);
			this.supportPaypal.TabIndex = 2;
			this.supportPaypal.Text = "💜 Support on Paypal";
			this.supportPaypal.UseVisualStyleBackColor = false;
			this.supportPaypal.Click += new System.EventHandler(this.SupportPaypal_Click);
			// 
			// supportPatreon
			// 
			this.supportPatreon.BackColor = System.Drawing.Color.DarkRed;
			this.supportPatreon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.supportPatreon.ForeColor = System.Drawing.Color.White;
			this.supportPatreon.Location = new System.Drawing.Point(67, 90);
			this.supportPatreon.Name = "supportPatreon";
			this.supportPatreon.Size = new System.Drawing.Size(124, 23);
			this.supportPatreon.TabIndex = 3;
			this.supportPatreon.Text = "💜 Support on Patreon";
			this.supportPatreon.UseVisualStyleBackColor = false;
			this.supportPatreon.Visible = false;
			this.supportPatreon.Click += new System.EventHandler(this.SupportPatreon_Click);
			// 
			// AboutBox
			// 
			this.AcceptButton = this.okButton;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(435, 283);
			this.Controls.Add(this.tableLayoutPanel);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "AboutBox";
			this.Padding = new System.Windows.Forms.Padding(9);
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "About Box";
			this.tableLayoutPanel.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).EndInit();
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
		private System.Windows.Forms.PictureBox logoPictureBox;
		private System.Windows.Forms.Label labelProductName;
		private System.Windows.Forms.Label labelVersion;
		private System.Windows.Forms.Label labelCopyright;
		private System.Windows.Forms.Label labelCompanyName;
		private System.Windows.Forms.Button okButton;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button supportPatreon;
		private System.Windows.Forms.Button supportPaypal;
		private System.Windows.Forms.Button supportTwitch;
		private System.Windows.Forms.Button supportGithub;
	}
}
