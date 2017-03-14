using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
   
    public partial class Form1 : Form
    {
        int begin_flag = 0;
        MySocket SA;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (begin_flag == 0)
            {
                begin_flag = 1;
                SA = new MySocket(IPTextBox.Text, int.Parse(PortTextBox.Text));
                if (1 == SA.Listener())
                {

                    BeginButton.Text = "停止";
                    while (begin_flag == 1)
                    {
                        if(SA.Receive() == 1)
                        {
                            MessageBox.Show("SA.ReData");
                        }
                    }
                }

                else
                {
                    begin_flag = 0;
                    BeginButton.Text = "开始";
                }

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ReceiveTextBox.Text += SendTextBox.Text;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            
        }
    }
}
