using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Photoroid {
	public class PhotoGroupSettings {
		public PhotoGroupSettings ( ) {
			Photos = new List<PhotoSettings> ( );
		}
		[JsonProperty("photos")]
		public List<PhotoSettings> Photos { get; set; }
		[JsonProperty ( "startWithWindows" )]
		public bool StartWithWindows { get; set; } = false;
	}

	public class PhotoSettings {

		public PhotoSettings ( ) {
			Size = new PhotoSize ( );
			Location = new Location ( );
			Font = new PhotoFont ( );
		}

		[JsonProperty("color")]
		public int Color { get; set; } = System.Drawing.Color.White.ToArgb ( );
		[JsonProperty("file")]
		public string File { get; set; }
		[JsonProperty("location")]
		public Location Location { get; set; }
		[JsonProperty("label")]
		public string Label { get; set; }
		[JsonProperty ( "onTop" )]
		public bool OnTop { get; set; }
		[JsonProperty ( "locked" )]
		public bool Locked { get; set; }
		[JsonProperty("size")]
		public PhotoSize Size { get; set; }
		[JsonProperty ( "font" )]
		public PhotoFont Font { get; set; }

	}

	public class PhotoFont {
		[JsonProperty("name")]
		public string Name { get; set; } = "Comic Sans MS";
		[JsonProperty("size")]
		public float Size { get; set; } = 22;
		[JsonProperty("bold")]
		public bool Bold { get; set; } = true;
		[JsonProperty ( "strike" )]
		public bool Strike { get; set; }
		[JsonProperty ( "italic" )]
		public bool Italic { get; set; }
		[JsonProperty ( "color" )]
		public int Color { get; set; } = System.Drawing.Color.Black.ToArgb ( );

		public Font GetFont() {
			var style = FontStyle.Regular;
			if ( Bold ) {
				style &= FontStyle.Bold;
			}
			if ( Strike ) {
				style &= FontStyle.Strikeout;
			}
			if ( Italic ) {
				style &= FontStyle.Italic;
			}
			return new Font ( this.Name, this.Size, style, GraphicsUnit.Point );
		}
	}

	public class PhotoSize {
		[JsonProperty ( "width" )]
		public int Width { get; set; } = 0;
		[JsonProperty ( "height" )]
		public int Height { get; set; } = 0;
		public bool IsEmpty ( ) {
			return this.Height <= 0 || this.Width <= 0;
		}
	}
	public class Location {
		[JsonProperty("screen")]
		public string Screen { get; set; }
		[JsonProperty ( "x" )]
		public int X { get; set; } = -99999;
		[JsonProperty ( "y" )]
		public int Y { get; set; } = -99999;

		public bool IsEmpty () {
			return this.X == -99999 || this.Y == -99999;
		}
	}
}
