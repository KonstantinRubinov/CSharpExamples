using System;
using System.Windows.Forms;

namespace AssafFinkelshtein {

    public partial class CopyForm : Form {

        public CopyForm() {
            InitializeComponent();
        }

        private void CopyForm_Shown(object sender, EventArgs e) {
            Hide();
        }

        private void mnuFullO_Click(object sender, EventArgs e) {
            Clipboard.SetImage(pictureBoxFullO.Image);
        }

        private void mnuFullV_Click(object sender, EventArgs e) {
            Clipboard.SetImage(pictureBoxFullV.Image);
        }

        private void mnuEmptyO_Click(object sender, EventArgs e) {
            Clipboard.SetImage(pictureBoxEmptyO.Image);
        }

        private void mnuEmptyV_Click(object sender, EventArgs e) {
            Clipboard.SetImage(pictureBoxEmptyV.Image);
        }

        private void mnuExit_Click(object sender, EventArgs e) {
            Close();
        }
    }
}
