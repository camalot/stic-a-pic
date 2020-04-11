namespace Photoroid {
	partial class Frame {
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
			this.components = new System.ComponentModel.Container();
			this.photo = new System.Windows.Forms.PictureBox();
			this.mainContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.setPhotoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
			this.lockToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.alwaysOnTopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.setColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.setFontToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
			this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.photoLabel = new System.Windows.Forms.Label();
			this.panel = new System.Windows.Forms.Panel();
			((System.ComponentModel.ISupportInitialize)(this.photo)).BeginInit();
			this.mainContextMenuStrip.SuspendLayout();
			this.panel.SuspendLayout();
			this.SuspendLayout();
			// 
			// photo
			// 
			this.photo.BackColor = System.Drawing.Color.Gray;
			this.photo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.photo.ContextMenuStrip = this.mainContextMenuStrip;
			this.photo.Dock = System.Windows.Forms.DockStyle.Fill;
			this.photo.Location = new System.Drawing.Point(0, 0);
			this.photo.Name = "photo";
			this.photo.Size = new System.Drawing.Size(258, 214);
			this.photo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.photo.TabIndex = 0;
			this.photo.TabStop = false;
			this.photo.DoubleClick += new System.EventHandler(this.Photo_DoubleClick);
			this.photo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Photo_MouseDown);
			// 
			// mainContextMenuStrip
			// 
			this.mainContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.setPhotoToolStripMenuItem,
            this.toolStripMenuItem2,
            this.lockToolStripMenuItem,
            this.alwaysOnTopToolStripMenuItem,
            this.setColorToolStripMenuItem,
            this.setFontToolStripMenuItem,
            this.toolStripMenuItem1,
            this.closeToolStripMenuItem});
			this.mainContextMenuStrip.Name = "contextMenuStrip1";
			this.mainContextMenuStrip.Size = new System.Drawing.Size(159, 148);
			// 
			// setPhotoToolStripMenuItem
			// 
			this.setPhotoToolStripMenuItem.Name = "setPhotoToolStripMenuItem";
			this.setPhotoToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
			this.setPhotoToolStripMenuItem.Text = "&Set Photo";
			this.setPhotoToolStripMenuItem.Click += new System.EventHandler(this.SetPhotoToolStripMenuItem_Click);
			// 
			// toolStripMenuItem2
			// 
			this.toolStripMenuItem2.Name = "toolStripMenuItem2";
			this.toolStripMenuItem2.Size = new System.Drawing.Size(155, 6);
			// 
			// lockToolStripMenuItem
			// 
			this.lockToolStripMenuItem.CheckOnClick = true;
			this.lockToolStripMenuItem.Name = "lockToolStripMenuItem";
			this.lockToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
			this.lockToolStripMenuItem.Text = "&Locked";
			this.lockToolStripMenuItem.CheckedChanged += new System.EventHandler(this.LockToolStripMenuItem_CheckedChanged);
			// 
			// alwaysOnTopToolStripMenuItem
			// 
			this.alwaysOnTopToolStripMenuItem.CheckOnClick = true;
			this.alwaysOnTopToolStripMenuItem.Name = "alwaysOnTopToolStripMenuItem";
			this.alwaysOnTopToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
			this.alwaysOnTopToolStripMenuItem.Text = "&Always On Top";
			this.alwaysOnTopToolStripMenuItem.CheckedChanged += new System.EventHandler(this.AlwaysOnTopToolStripMenuItem_CheckedChanged);
			// 
			// setColorToolStripMenuItem
			// 
			this.setColorToolStripMenuItem.Name = "setColorToolStripMenuItem";
			this.setColorToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
			this.setColorToolStripMenuItem.Text = "Set Frame C&olor";
			this.setColorToolStripMenuItem.Click += new System.EventHandler(this.SetColorToolStripMenuItem_Click);
			// 
			// setFontToolStripMenuItem
			// 
			this.setFontToolStripMenuItem.Name = "setFontToolStripMenuItem";
			this.setFontToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
			this.setFontToolStripMenuItem.Text = "Set &Font";
			this.setFontToolStripMenuItem.Click += new System.EventHandler(this.SetFontToolStripMenuItem_Click);
			// 
			// toolStripMenuItem1
			// 
			this.toolStripMenuItem1.Name = "toolStripMenuItem1";
			this.toolStripMenuItem1.Size = new System.Drawing.Size(155, 6);
			// 
			// closeToolStripMenuItem
			// 
			this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
			this.closeToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
			this.closeToolStripMenuItem.Text = "&Close";
			this.closeToolStripMenuItem.Click += new System.EventHandler(this.CloseToolStripMenuItem_Click);
			// 
			// photoLabel
			// 
			this.photoLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.photoLabel.AutoEllipsis = true;
			this.photoLabel.BackColor = System.Drawing.Color.Transparent;
			this.photoLabel.Font = new System.Drawing.Font("Comic Sans MS", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.photoLabel.Location = new System.Drawing.Point(12, 239);
			this.photoLabel.Name = "photoLabel";
			this.photoLabel.Size = new System.Drawing.Size(258, 43);
			this.photoLabel.TabIndex = 1;
			this.photoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.photoLabel.DoubleClick += new System.EventHandler(this.PhotoLabel_DoubleClick);
			this.photoLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PhotoLabel_MouseDown);
			// 
			// panel
			// 
			this.panel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.panel.BackColor = System.Drawing.Color.DimGray;
			this.panel.Controls.Add(this.photo);
			this.panel.Location = new System.Drawing.Point(12, 12);
			this.panel.Name = "panel";
			this.panel.Size = new System.Drawing.Size(258, 214);
			this.panel.TabIndex = 2;
			// 
			// Frame
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(282, 291);
			this.ContextMenuStrip = this.mainContextMenuStrip;
			this.ControlBox = false;
			this.Controls.Add(this.photoLabel);
			this.Controls.Add(this.panel);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.MinimumSize = new System.Drawing.Size(282, 291);
			this.Name = "Frame";
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
			this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Frame_MouseDown);
			((System.ComponentModel.ISupportInitialize)(this.photo)).EndInit();
			this.mainContextMenuStrip.ResumeLayout(false);
			this.panel.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.PictureBox photo;
		private System.Windows.Forms.ContextMenuStrip mainContextMenuStrip;
		private System.Windows.Forms.ToolStripMenuItem setPhotoToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem lockToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
		private System.Windows.Forms.ToolStripMenuItem alwaysOnTopToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
		private System.Windows.Forms.Label photoLabel;
		private System.Windows.Forms.ToolStripMenuItem setFontToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem setColorToolStripMenuItem;
		private System.Windows.Forms.Panel panel;
	}
}

