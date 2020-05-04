using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Photoroid {
	partial class AboutBox : Form {
		public AboutBox ( ) {
			InitializeComponent ( );
			this.Text = $"About {AssemblyTitle} v{AssemblyVersion}";
			this.labelProductName.Text = AssemblyProduct;
			this.labelVersion.Text = $"Version: v{AssemblyVersion}";
			this.labelCopyright.Text = AssemblyCopyright;
			this.labelCompanyName.Text = AssemblyCompany;
			this.StartPosition = FormStartPosition.CenterScreen;
		}

		#region Assembly Attribute Accessors

		public string AssemblyTitle {
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
	}
}
