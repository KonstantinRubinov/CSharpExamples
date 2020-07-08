using System;
using System.Drawing;
using System.Windows.Forms;

namespace WinForms_Events
{
    class Program
    {
        static void Main(string[] args)
        {
            Form frm = new Form();
            frm.MouseEnter += (sender, e) => (sender as Form).BackColor = Color.Green;
            frm.MouseLeave += Frm_MouseLeave;
            frm.MouseMove += Frm_MouseMove;
            frm.KeyUp += Frm_KeyUp;
            frm.ShowDialog();
        }

        private static void Frm_KeyUp(object sender, KeyEventArgs e)
        {
            MessageBox.Show(e.KeyData.ToString());
        }

        private static void Frm_MouseMove(object sender, MouseEventArgs e)
        {
            Console.WriteLine(e.Location);
            (sender as Form).Text = e.Location.ToString();
        }

        private static void Frm_MouseLeave(object sender, EventArgs e)
        {
            (sender as Form).BackColor = Color.Blue;
        }
    }
}
