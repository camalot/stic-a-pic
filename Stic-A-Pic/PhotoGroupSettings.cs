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
	}

	public class PhotoSettings {

		public PhotoSettings ( ) {
			Size = new PhotoSize ( );
			Location = new Location ( );
		}
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
	}

	public class PhotoSize {
		[JsonProperty ( "width" )]
		public int Width { get; set; } = 0;
		[JsonProperty ( "height" )]
		public int Height { get; set; } = 0;
	}
	public class Location {
		[JsonProperty ( "x" )]
		public int X { get; set; } = -1;
		[JsonProperty ( "y" )]
		public int Y { get; set; } = -1;
	}
}
