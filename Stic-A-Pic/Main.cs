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
using Newtonsoft.Json;

namespace Photoroid {
	public partial class Main : Form {
		public PhotoGroupSettings PhotoGroupSettings { get; set; }
		public List<Frame> Frames { get; set; }
		public Main ( ) {
			InitializeComponent ( );

			PhotoGroupSettings = new PhotoGroupSettings ( );
			Frames = new List<Frame> ( );

			this.Visible = false;
			Opacity = 0;


			LoadSettings ( );

			LoadPhotos ( );
		}

		protected override void OnClosing ( CancelEventArgs e ) {
			PhotoGroupSettings.Photos.Clear ( );
			foreach ( var item in Frames ) {
				PhotoGroupSettings.Photos.Add ( item.Settings );
			}

			SaveSettings ( );
			base.OnClosing ( e );
		}

		private void LoadPhotos() {
			foreach ( var item in this.PhotoGroupSettings.Photos ) {
				LoadNewFrame ( item );
			}
		}

		private void SaveSettings ( ) {
			var serializer = new JsonSerializer ( );
			var path = System.IO.Path.GetDirectoryName ( Application.ExecutablePath );
			var fname = Path.Combine ( path, "settings.json" );
			using ( var sw = new StreamWriter ( fname, false, Encoding.UTF8 ) ) {
				serializer.Serialize ( sw, this.PhotoGroupSettings );
			}
		}

		private void LoadSettings () {
			try {
				var serializer = new JsonSerializer ( );
				var path = System.IO.Path.GetDirectoryName ( Application.ExecutablePath );
				var fname = Path.Combine ( path, "settings.json" );
				using ( var sr = new StreamReader ( fname ) ) {
					using ( var jr = new JsonTextReader ( sr ) ) {
						this.PhotoGroupSettings = serializer.Deserialize<PhotoGroupSettings> ( jr );
					}
				}
			} catch {
				// nothing
			}
		}

		protected override void OnClosed ( EventArgs e ) {
			base.OnClosed ( e );
		}

		private void ExitToolStripMenuItem_Click ( object sender, EventArgs e ) {
			this.Close ( );
		}

		private void AddPhotoToolStripMenuItem_Click ( object sender, EventArgs e ) {
			LoadNewFrame ( new PhotoSettings() );
		}

		private void LoadNewFrame(PhotoSettings settings) {
			var frame = new Frame ( settings );
			frame.SaveSettings += Frame_SaveSettings;
			Frames.Add ( frame );
			frame.Show ( this );
		}

		private void Frame_SaveSettings ( object sender, EventArgs e ) {
			var frame = (Frame)sender;
			Frames.Remove ( frame );
		}
	}
}
