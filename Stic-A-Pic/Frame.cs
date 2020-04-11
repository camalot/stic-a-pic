using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Photoroid {
	public partial class Frame : Form {

		private const int cGRIP = 16;
		private const int cCAPTION = 32;

		public bool Locked { get; set; }

		public PhotoSettings Settings { get; set; }

		public event EventHandler SaveSettings;

		public Frame(PhotoSettings settings) {
			InitializeComponent ( );
			Settings = settings;
			this.FormBorderStyle = FormBorderStyle.None;
			this.DoubleBuffered = true;
			this.SetStyle ( ControlStyles.ResizeRedraw, true );

			if(!string.IsNullOrWhiteSpace(settings.File)) {
				if ( System.IO.File.Exists ( settings.File ) ) {
					this.Size = new Size ( this.Settings.Size.Width, this.Settings.Size.Height );
					SetPhoto ( settings.File );
					this.photoLabel.Text = settings.Label;
					this.alwaysOnTopToolStripMenuItem.Checked = settings.OnTop;
					this.lockToolStripMenuItem.Checked = settings.Locked;
				}
			}
		}

		public Frame ( ) : this(new PhotoSettings() ){
			
		}

		private void Photo_DoubleClick ( object sender, EventArgs e ) {

		}

		protected override void OnPaint ( PaintEventArgs e ) {
			Rectangle rc = new Rectangle ( this.ClientSize.Width - cGRIP, this.ClientSize.Height - cGRIP, cGRIP, cGRIP );
			ControlPaint.DrawSizeGrip ( e.Graphics, this.BackColor, rc );
			rc = new Rectangle ( 0, 0, this.ClientSize.Width, cCAPTION );
			e.Graphics.FillRectangle ( Brushes.White, rc );
		}

		protected override void WndProc ( ref Message m ) {
			if ( m.Msg == 0x84 ) {  // Trap WM_NCHITTEST
				Point pos = new Point ( m.LParam.ToInt32 ( ) );
				pos = this.PointToClient ( pos );
				if ( !Locked ) {
					if ( pos.Y < cCAPTION ) {
						m.Result = (IntPtr)2;  // HTCAPTION
						return;
					}
					if ( pos.X >= this.ClientSize.Width - cGRIP && pos.Y >= this.ClientSize.Height - cGRIP ) {
						m.Result = (IntPtr)17; // HTBOTTOMRIGHT
						return;
					}
				}
			}
			base.WndProc ( ref m );
		}

		private void SetPhotoToolStripMenuItem_Click ( object sender, EventArgs e ) {
			var ofd = new OpenFileDialog ( );
			ofd.Filter = "Photos|*.jpg;*.jpeg;*.bpm;*.png|All Files|*.*";
			if ( ofd.ShowDialog ( ) == DialogResult.OK ) {
				var file = ofd.FileName;
				this.Settings.File = file;

				SetPhoto ( file );
			}
		}

		protected override void OnResize ( EventArgs e ) {
			if ( this.Settings != null && this.Settings.Size != null ) {
				this.Settings.Size = new PhotoSize {
					Height = this.Size.Height,
					Width = this.Size.Width
				};
			}
			base.OnResize ( e );
		}

		protected override void OnMove ( EventArgs e ) {
			if ( this.Settings != null && this.Settings.Location != null ) {
				this.Settings.Location = new Location {
					X = this.Location.X,
					Y = this.Location.Y
				};
			}
			base.OnMove ( e );
		}

		private void SetPhoto(string path) {
			if(photo.Image != null) {
				photo.Image.Dispose ( );
			}

			var image = new Bitmap ( path );
			photo.Image = image;
		}

		private void LockToolStripMenuItem_CheckedChanged ( object sender, EventArgs e ) {
			Locked = lockToolStripMenuItem.Checked;
			Settings.Locked = Locked;
		}

		private void AlwaysOnTopToolStripMenuItem_CheckedChanged ( object sender, EventArgs e ) {
			this.TopMost = alwaysOnTopToolStripMenuItem.Checked;
			Settings.OnTop = this.TopMost;
		}

		private void AddPhotoToolStripMenuItem_Click ( object sender, EventArgs e ) {
			
		}

		private void CloseToolStripMenuItem_Click ( object sender, EventArgs e ) {
			

			this.SaveSettings?.Invoke ( this, e );

			this.Close ( );
		}

		private void PhotoLabel_DoubleClick ( object sender, EventArgs e ) {
			var setLabel = new SetLabelForm ( );
			setLabel.ShowDialog ( this );
			if(setLabel.DialogResult == DialogResult.OK) {
				this.photoLabel.Text = setLabel.LabelText;
				Settings.Label = setLabel.LabelText;
			}
		}
	}
}
