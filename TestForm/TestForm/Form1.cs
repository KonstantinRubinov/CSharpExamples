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
    public partial class Form1 : Form
    {
        private int count;
        public Form1()
        {
            InitializeComponent();
            count = 0;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            Color myColor = Color.FromArgb(rnd.Next()%256,rnd.Next()%256,rnd.Next()%256);

            count++;
            frmNew newFrm = new frmNew(count, myColor);
            newFrm.Show();
            newFrm = null;
        }
    }
}
