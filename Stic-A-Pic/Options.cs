using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
	public partial class Options : Form {
		
		public Options ( Main owner ) {
			LoadSettings ( );
			InitializeComponent ( );
			this.Owner = owner;
			this.Text = $"{AssemblyTitle} Options";
			startupOption.Checked = this.PhotoGroupSettings.StartWithWindows;
			this.version.Text = $"{AssemblyTitle} v{AssemblyVersion}";
			this.copyright.Text = $"{AssemblyCopyright}";
		}

		public PhotoGroupSettings PhotoGroupSettings { get; set; }
		public Main Owner { get; private set; }
		private void SaveSettings ( ) {

			var serializer = new JsonSerializer ( );
			var path = System.IO.Path.GetDirectoryName ( Application.ExecutablePath );
			var fname = Path.Combine ( path, "settings.json" );
			if ( File.Exists ( fname ) ) {
				using ( var sw = new StreamWriter ( fname, false, Encoding.UTF8 ) ) {
					serializer.Serialize ( sw, this.PhotoGroupSettings );
				}
			}
		}

		private void LoadSettings ( ) {
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


		private void StartupOption_CheckedChanged ( object sender, EventArgs e ) {
			if ( startupOption.Checked ) {
				AddApplicationToStartup ( );
			} else {
				RemoveApplicationFromStartup ( );
			}
			this.PhotoGroupSettings.StartWithWindows = startupOption.Checked;
			SaveSettings ( );
		}

		public DialogResult ShowAbout() {
			this.tabControl1.SelectedTab = this.tabAbout;
			return this.ShowDialog ( );
		}

# region Assembly Reflection
		private string AssemblyTitle {
			get {
				object[] attributes = Assembly.GetExecutingAssembly ( ).GetCustomAttributes ( typeof ( AssemblyTitleAttribute ), false );
				if ( attributes.Length > 0 ) {
					AssemblyTitleAttribute titleAttribute = (AssemblyTitleAttribute)attributes[0];
					if ( titleAttribute.Title != "" ) {
						return titleAttribute.Title;
					}
				}
				return System.IO.Path.GetFileNameWithoutExtension ( Assembly.GetExecutingAssembly ( ).CodeBase );
			}
		}


		public string AssemblyVersion {
			get {
				return Assembly.GetExecutingAssembly ( ).GetName ( ).Version.ToString ( );
			}
		}

		public string AssemblyDescription {
			get {
				object[] attributes = Assembly.GetExecutingAssembly ( ).GetCustomAttributes ( typeof ( AssemblyDescriptionAttribute ), false );
				if ( attributes.Length == 0 ) {
					return "";
				}
				return ( (AssemblyDescriptionAttribute)attributes[0] ).Description;
			}
		}

		public string AssemblyProduct {
			get {
				object[] attributes = Assembly.GetExecutingAssembly ( ).GetCustomAttributes ( typeof ( AssemblyProductAttribute ), false );
				if ( attributes.Length == 0 ) {
					return "";
				}
				return ( (AssemblyProductAttribute)attributes[0] ).Product;
			}
		}

		public string AssemblyCopyright {
			get {
				object[] attributes = Assembly.GetExecutingAssembly ( ).GetCustomAttributes ( typeof ( AssemblyCopyrightAttribute ), false );
				if ( attributes.Length == 0 ) {
					return "";
				}
				return ( (AssemblyCopyrightAttribute)attributes[0] ).Copyright;
			}
		}

		public string AssemblyCompany {
			get {
				object[] attributes = Assembly.GetExecutingAssembly ( ).GetCustomAttributes ( typeof ( AssemblyCompanyAttribute ), false );
				if ( attributes.Length == 0 ) {
					return "";
				}
				return ( (AssemblyCompanyAttribute)attributes[0] ).Company;
			}
		}
		#endregion

		private void AddApplicationToStartup ( ) {
			using ( var key = Registry.CurrentUser.OpenSubKey ( "SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true ) ) {
				key.SetValue ( AssemblyTitle, "\"" + Application.ExecutablePath + "\"" );
			}
		}

		private void RemoveApplicationFromStartup ( ) {
			using ( var key = Registry.CurrentUser.OpenSubKey ( "SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true ) ) {
				key.DeleteValue ( AssemblyTitle, false );
			}
		}

		private void Ok_Click ( object sender, EventArgs e ) {
			this.Close ( );
		}

		private void SupportGithub_Click ( object sender, EventArgs e ) {
			System.Diagnostics.Process.Start ( "https://github.com/sponsors/camalot" );
		}

		private void SupportTwitch_Click ( object sender, EventArgs e ) {
			System.Diagnostics.Process.Start ( "https://www.twitch.tv/products/darthminos" );
		}

		private void SupportPaypal_Click ( object sender, EventArgs e ) {
			System.Diagnostics.Process.Start ( "https://paypal.me/camalotdesigns/10" );
		}

		private void SupportPatreon_Click ( object sender, EventArgs e ) {
			System.Diagnostics.Process.Start ( "https://patreon.com/darthminos" );
		}

		private void CheckForUpdates_Click ( object sender, EventArgs e ) {
			this.Owner.CheckForUpdates ( );
		}
	}
}
