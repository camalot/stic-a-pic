using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;
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
				if ( File.Exists ( fname ) ) {
					using ( var sr = new StreamReader ( fname ) ) {
						using ( var jr = new JsonTextReader ( sr ) ) {
							this.PhotoGroupSettings = serializer.Deserialize<PhotoGroupSettings> ( jr );
						}
					}
				}
			} catch {
				// nothing
			}
		}

		protected override void OnClosed ( EventArgs e ) {
			base.OnClosed ( e );
		}

		#region Menu Items
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

		private void CheckForUpdatesToolStripMenuItem_Click ( object sender, EventArgs e ) {
			CheckForUpdates ( );
		}

		private void AboutSticAPicToolStripMenuItem_Click ( object sender, EventArgs e ) {
			var options = new Options ( this );
			options.ShowAbout ( );
		}


		private void OptionsToolStripMenuItem_Click ( object sender, EventArgs e ) {
			var options = new Options ( this );
			options.ShowDialog ( );
		}
		#endregion


		private void NotifyIcon_MouseDoubleClick ( object sender, MouseEventArgs e ) {
			var options = new Options ( this );
			options.ShowDialog ( );
		}

		public void CheckForUpdates ( ) {
			var app = Application.ExecutablePath;
			var dirName = System.IO.Path.GetDirectoryName ( app );
			var dir = new DirectoryInfo ( dirName );
			var appVersion = Assembly.GetExecutingAssembly ( ).GetName ( ).Version;
			Console.WriteLine ( $"Application Version: {appVersion}" );
			var version = new Semver.SemVersion ( appVersion.Major, appVersion.Minor, appVersion.Build );
			Console.WriteLine ( $"Version: {version}" );
			var manifest = new UpdateManifest ( ) {
				Application = app,
				Version = version.ToString ( ),
				FolderName = dir.Name,
				Path = dir.Parent.FullName,
				ProcessName = Path.GetFileNameWithoutExtension ( app ),
				RequiresRestart = true,
				Kill = new string[0],
				Website = "http://darthminos.tv"
			};

			var test = Newtonsoft.Json.JsonConvert.SerializeObject ( manifest );
			Console.WriteLine ( test );
			// copy updater to temp dir
			var updaterPath = new DirectoryInfo ( Path.Combine ( dirName, "updater" ) );
			if ( !updaterPath.Exists ) {
				Console.WriteLine ( "Updater Path Does Not Exist." );
				MessageBox.Show ( "Unable to locate the updater. Please make sure you have the latest version.", "Error Updating", MessageBoxButtons.OK, MessageBoxIcon.Error );
				return;
			}
			var tempPath = Path.Combine ( Path.GetTempPath ( ), "Stic-A-Pic" );
			if ( Directory.Exists ( tempPath ) ) {
				Directory.Delete ( tempPath, true );
			}

			var tempDir = Directory.CreateDirectory ( tempPath );

			foreach ( var f in updaterPath.GetFiles ( "**", SearchOption.AllDirectories ) ) {
				var newDest = f.FullName.Replace ( updaterPath.FullName, tempPath );
				Console.Write ( newDest );
				var dirPath = Path.GetDirectoryName ( newDest );
				if ( !Directory.Exists ( dirPath ) ) {
					Directory.CreateDirectory ( dirPath );
				}
				Console.WriteLine ( $"Copy {f.FullName} => {newDest}" );
				File.Copy ( f.FullName, newDest );
			}

			var executer = Path.Combine ( tempPath, "ApplicationUpdater.exe" );
			using ( var sw = new StreamWriter ( Path.Combine ( tempPath, "update.manifest" ), false, Encoding.UTF8 ) ) {
				var ser = new JsonSerializer ( );
				ser.Serialize ( sw, manifest );
			}

			var psi = new ProcessStartInfo ( );
			psi.FileName = executer;
			Process.Start ( psi );
		}

	}
}
