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
		private const int WM_NCLBUTTONDOWN = 0xA1;
		private const int HT_CAPTION = 0x2;
		private const int WM_NCHITTEST = 0x84;
		private const int WM_LBUTTONDBLCLK = 0x00A3;

		public bool Locked { get; set; }

		public PhotoSettings Settings { get; set; }

		public event EventHandler SaveSettings;

		public Frame ( PhotoSettings settings ) {
			InitializeComponent ( );
			Settings = settings;
			this.FormBorderStyle = FormBorderStyle.None;
			this.DoubleBuffered = true;
			this.SetStyle ( ControlStyles.ResizeRedraw, true );

			if ( !string.IsNullOrWhiteSpace ( settings.File ) ) {
				if ( System.IO.File.Exists ( settings.File ) ) {
					this.Size = new Size ( this.Settings.Size.Width, this.Settings.Size.Height );
					SetPhoto ( settings.File );
					this.photoLabel.Text = settings.Label;
					this.alwaysOnTopToolStripMenuItem.Checked = settings.OnTop;
					this.lockToolStripMenuItem.Checked = settings.Locked;
					this.Locked = settings.Locked;
					this.DesktopLocation = new Point ( settings.Location.X, settings.Location.Y );

					this.photoLabel.Font = Settings.Font.GetFont ( );
					this.photoLabel.ForeColor = Color.FromArgb ( Settings.Font.Color );
					this.BackColor = Color.FromArgb ( Settings.Color );
				}
			}
		}

		public Frame ( ) : this ( new PhotoSettings ( ) ) {
			
		}

		private void Photo_DoubleClick ( object sender, EventArgs e ) {

		}

		protected override void OnPaint ( PaintEventArgs e ) {
			e.Graphics.Clear ( this.BackColor );
			Rectangle rc = new Rectangle ( this.ClientSize.Width - cGRIP, this.ClientSize.Height - cGRIP, cGRIP, cGRIP );
			if ( !this.Locked ) {
				ControlPaint.DrawSizeGrip ( e.Graphics, this.BackColor, rc );
			}
		}

		protected override void WndProc ( ref Message m ) {
			switch ( m.Msg ) {
				case WM_NCHITTEST:
					Point pos = new Point ( m.LParam.ToInt32 ( ) );
					pos = this.PointToClient ( pos );
					if ( !Locked ) {

						if ( pos.X >= this.ClientSize.Width - cGRIP && pos.Y >= this.ClientSize.Height - cGRIP ) {
							m.Result = (IntPtr)17; // HTBOTTOMRIGHT
							return;
						} else {
							m.Result = (IntPtr)HT_CAPTION;  // HTCAPTION
							return;
						}
					}
					break;
				case WM_LBUTTONDBLCLK:
					return;
				default:
					break;
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
				var screen = Screen.FromControl ( this );
				this.Settings.Location = new Location {
					Screen = screen.DeviceName,
					X = this.DesktopLocation.X,
					Y = this.DesktopLocation.Y
				};
			}
			base.OnMove ( e );
		}

		private void SetPhoto ( string path ) {
			if ( photo.Image != null ) {
				photo.Image.Dispose ( );
			}

			var image = new Bitmap ( path );
			photo.Image = image;
		}

		private void LockToolStripMenuItem_CheckedChanged ( object sender, EventArgs e ) {
			Locked = lockToolStripMenuItem.Checked;
			Settings.Locked = Locked;
			using ( var g = new PaintEventArgs ( this.CreateGraphics ( ), this.Bounds ) ) {
				this.OnPaint ( g );
			}
		}

		private void AlwaysOnTopToolStripMenuItem_CheckedChanged ( object sender, EventArgs e ) {
			this.TopMost = alwaysOnTopToolStripMenuItem.Checked;
			Settings.OnTop = this.TopMost;
		}

		private void CloseToolStripMenuItem_Click ( object sender, EventArgs e ) {
			this.SaveSettings?.Invoke ( this, e );
			this.Close ( );
		}

		private void PhotoLabel_DoubleClick ( object sender, EventArgs e ) {
			var setLabel = new SetLabelForm ( Settings.Label );
			setLabel.ShowDialog ( this );
			if ( setLabel.DialogResult == DialogResult.OK ) {
				this.photoLabel.Text = setLabel.LabelText;
				Settings.Label = setLabel.LabelText;
			}
		}

		private void SetFontToolStripMenuItem_Click ( object sender, EventArgs e ) {
			var fd = new FontDialog ( );
			fd.ShowColor = true;
			var style = FontStyle.Regular;
			if ( Settings.Font.Bold ) {
				style &= FontStyle.Bold;
			}
			if ( Settings.Font.Strike ) {
				style &= FontStyle.Strikeout;
			}
			if ( Settings.Font.Italic ) {
				style &= FontStyle.Italic;
			}
			fd.Color = Color.FromArgb ( Settings.Font.Color );
			fd.Font = new Font ( Settings.Font.Name, Settings.Font.Size, style, GraphicsUnit.Point );
			if ( fd.ShowDialog ( ) == DialogResult.OK ) {
				Settings.Font.Name = fd.Font.FontFamily.Name;
				Settings.Font.Size = fd.Font.SizeInPoints;
				Settings.Font.Bold = fd.Font.Bold;
				Settings.Font.Italic = fd.Font.Italic;
				Settings.Font.Strike = fd.Font.Strikeout;
				Settings.Font.Color = fd.Color.ToArgb ( );
				this.photoLabel.Font = Settings.Font.GetFont ( );
				this.photoLabel.ForeColor = Color.FromArgb ( Settings.Font.Color );
			}
		}

		private void SetColorToolStripMenuItem_Click ( object sender, EventArgs e ) {
			var cd = new ColorDialog ( );
			cd.Color = Color.FromArgb ( Settings.Color );
			cd.AnyColor = true;
			cd.AllowFullOpen = true;
			cd.FullOpen = true;
			if ( cd.ShowDialog ( ) == DialogResult.OK ) {
				var color = cd.Color;
				Settings.Color = color.ToArgb ( );
				this.BackColor = color;
			}
		}

		private void Photo_MouseDown ( object sender, MouseEventArgs e ) {
			if ( e.Clicks <= 1 && !Locked ) {
				( sender as Control ).Capture = false;
				Message msg = Message.Create ( Handle, WM_NCLBUTTONDOWN, (IntPtr)HT_CAPTION, IntPtr.Zero );
				base.WndProc ( ref msg );
			}
		}

		private void PhotoLabel_MouseDown ( object sender, MouseEventArgs e ) {
			if ( e.Clicks <= 1 && !Locked ) {
				( sender as Control ).Capture = false;
				Message msg = Message.Create ( Handle, WM_NCLBUTTONDOWN, (IntPtr)HT_CAPTION, IntPtr.Zero );
				base.WndProc ( ref msg );
			}
		}

		private void Frame_MouseDown ( object sender, MouseEventArgs e ) {
			if ( e.Clicks >= 2 ) {
				( sender as Control ).Capture = false;
			}
		}
	}
}
