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
	public partial class SetLabelForm : Form {
		public SetLabelForm ( string label ) {
			InitializeComponent ( );
			this.labelText.Text = label;
		}

		protected override void OnShown ( EventArgs e ) {
			this.labelText.Focus();
			base.OnShown ( e );
		}

		public string LabelText { get { return this.labelText.Text;  } }

		private void Ok_Click ( object sender, EventArgs e ) {
			this.DialogResult = DialogResult.OK;
			this.Close ( );
		}
	}
}
