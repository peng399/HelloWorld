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
    }
}
