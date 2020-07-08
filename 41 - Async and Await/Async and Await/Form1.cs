using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Async_and_Await
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void buttonDoWork1_Click(object sender, EventArgs e)
        {
            int sum = 0;
            Task t = new Task(() => {
                for (int i = 1; i <= 100; i++)
                {
                    Thread.Sleep(100);
                    sum += (2 * i);
                }
            });
            t.Start();
            await t;
            label1.Text = sum.ToString();
        }

        private async void buttonDoWork2_Click(object sender, EventArgs e)
        {
            Text = "Start";
            label1.Text = await doWorkAsync();
            Text = "End";
        }

        private async Task<string> doWorkAsync()
        {
            Task<string> t = new Task<string>(() => {
                int sum = 0;
                for (int i = 1; i <= 100; i++)
                {
                    Thread.Sleep(100);
                    sum += i;
                }
                return sum.ToString();
            });
            t.Start();
            return await t;
        }
    }
}
