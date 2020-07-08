using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TabTest
{
    public partial class frmTab : Form
    {
        public frmTab()
        {
            InitializeComponent();
        }

        private void tbcTest_SelectedIndexChanged(object sender, EventArgs e)
        {
            Console.WriteLine(tbcTest.SelectedIndex.ToString());
        }
    }
}
