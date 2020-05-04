namespace Photoroid {
	partial class Main {
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
			this.mainContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.addPhotoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
			this.aboutSticAPicToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.checkForUpdatesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
			this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
			this.mainContextMenuStrip.SuspendLayout();
			this.SuspendLayout();
			// 
			// mainContextMenuStrip
			// 
			this.mainContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addPhotoToolStripMenuItem,
            this.toolStripMenuItem2,
            this.aboutSticAPicToolStripMenuItem,
            this.checkForUpdatesToolStripMenuItem,
            this.toolStripMenuItem1,
            this.exitToolStripMenuItem});
			this.mainContextMenuStrip.Name = "contextMenuStrip1";
			this.mainContextMenuStrip.Size = new System.Drawing.Size(181, 126);
			// 
			// addPhotoToolStripMenuItem
			// 
			this.addPhotoToolStripMenuItem.Name = "addPhotoToolStripMenuItem";
			this.addPhotoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.addPhotoToolStripMenuItem.Text = "&Add Photo";
			this.addPhotoToolStripMenuItem.Click += new System.EventHandler(this.AddPhotoToolStripMenuItem_Click);
			// 
			// toolStripMenuItem2
			// 
			this.toolStripMenuItem2.Name = "toolStripMenuItem2";
			this.toolStripMenuItem2.Size = new System.Drawing.Size(177, 6);
			// 
			// aboutSticAPicToolStripMenuItem
			// 
			this.aboutSticAPicToolStripMenuItem.Name = "aboutSticAPicToolStripMenuItem";
			this.aboutSticAPicToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.aboutSticAPicToolStripMenuItem.Text = "About &Stic-A-Pic";
			this.aboutSticAPicToolStripMenuItem.Click += new System.EventHandler(this.AboutSticAPicToolStripMenuItem_Click);
			// 
			// checkForUpdatesToolStripMenuItem
			// 
			this.checkForUpdatesToolStripMenuItem.Name = "checkForUpdatesToolStripMenuItem";
			this.checkForUpdatesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.checkForUpdatesToolStripMenuItem.Text = "Check For &Updates";
			this.checkForUpdatesToolStripMenuItem.Click += new System.EventHandler(this.CheckForUpdatesToolStripMenuItem_Click);
			// 
			// toolStripMenuItem1
			// 
			this.toolStripMenuItem1.Name = "toolStripMenuItem1";
			this.toolStripMenuItem1.Size = new System.Drawing.Size(177, 6);
			// 
			// exitToolStripMenuItem
			// 
			this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
			this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.exitToolStripMenuItem.Text = "E&xit";
			this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
			// 
			// notifyIcon
			// 
			this.notifyIcon.ContextMenuStrip = this.mainContextMenuStrip;
			this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
			this.notifyIcon.Text = "Stic-A-Pic";
			this.notifyIcon.Visible = true;
			// 
			// Main
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(373, 369);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "Main";
			this.ShowInTaskbar = false;
			this.Text = "Stic-A-Pic";
			this.mainContextMenuStrip.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.ContextMenuStrip mainContextMenuStrip;
		private System.Windows.Forms.NotifyIcon notifyIcon;
		private System.Windows.Forms.ToolStripMenuItem addPhotoToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
		private System.Windows.Forms.ToolStripMenuItem aboutSticAPicToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem checkForUpdatesToolStripMenuItem;
	}
}