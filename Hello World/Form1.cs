using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hello_World
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            labTime.Text = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss");

            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            timer1.Start();
        }

        private void btnSay_Click(object sender, EventArgs e)
        {
            labHelloWorld.Text = "Hello World!";
        }

        private async void btnCount_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 11; i++)
            {
                labCount.Text = i.ToString();
                await Task.Delay(1000);
            }
            labCount.Text = "label2";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            labTime.Text = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss");
        }
    }
}
