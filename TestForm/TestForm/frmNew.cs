using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestForm
{
    public partial class frmNew : Form
    {
        public frmNew(int num, Color myColor)
        {
            InitializeComponent();
            this.Text = num.ToString();
            this.BackColor = myColor;
        }
    }
}
