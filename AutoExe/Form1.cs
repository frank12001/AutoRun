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

namespace AutoExe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                for (int i = 0; i < int.Parse(textBox2.Text); i++)
                {
                    System.Diagnostics.Process.Start(System.Windows.Forms.Application.StartupPath + @"\" + textBox3.Text + @".exe");
                    Thread.Sleep(int.Parse(textBox1.Text) * 1000);
                }
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
            }
        }
    }
}
