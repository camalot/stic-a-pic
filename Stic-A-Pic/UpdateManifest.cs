using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Photoroid {
	public class UpdateManifest {
		[JsonProperty ( "application" )]
		public string Application { get; set; }
		[JsonProperty ( "path" )]
		public string Path { get; set; }
		[JsonProperty ( "requiresRestart" )]
		public bool RequiresRestart { get; set; } = true;
		[JsonProperty ( "folderName" )]
		public string FolderName { get; set; } = "Stic-A-Pic";
		[JsonProperty ( "version" )]
		public string Version { get; set; } = "1.0.0-snapshot";
		[JsonProperty ( "processName" )]
		public string ProcessName { get; set; } = "Stic-A-Pic";
		[JsonProperty ( "name" )]
		public string Name { get; set; } = "Stic-A-Pic";
		[JsonProperty ( "website" )]
		public string Website { get; set; } = "http://darthminos.tv";
		[JsonProperty ( "kill" )]
		public string[] Kill { get; set; } = new string[0];
		[JsonProperty ( "execute" )]
		public UpdateManifestExecute Execute { get; set; } = new UpdateManifestExecute ( );
		[JsonProperty ( "repository" )]
		public UpdateManifestRepository Repository { get; set; } = new UpdateManifestRepository ( );



	}

	public class UpdateManifestRepository {
		[JsonProperty("owner")]
		public string Owner { get; set; } = "camalot";
		[JsonProperty("name")]
		public string Name { get; set; } = "stic-a-pic";
	}


	public class UpdateManifestExecute {

		[JsonProperty ( "before" )]
		public List<UpdateManifestExecuteCommand> Before { get; set; } = new List<UpdateManifestExecuteCommand> ( );
		[JsonProperty ( "after" )]
		public List<UpdateManifestExecuteCommand> After { get; set; } = new List<UpdateManifestExecuteCommand> ( );
	}

	public class UpdateManifestExecuteCommand {
		[JsonProperty ( "command" )]
		public string Command { get; set; }
		[JsonProperty ( "arguments" )]
		public List<string> Arguments { get; set; } = new List<string> ( );
		[JsonProperty ( "workingDirectory" )]
		public string WorkingDirectory { get; set; }
		[JsonProperty ( "ignoreExitCode" )]
		public bool IgnoreExitCode { get; set; } = true;
		[JsonProperty("validExitCodes")]
		public List<int> ValidExitCodes { get; set; } = new List<int> ( ) { 0 };

		public override string ToString ( ) {
			return $"{Command} {string.Join ( " ", Arguments )}";
		}
	}

}
