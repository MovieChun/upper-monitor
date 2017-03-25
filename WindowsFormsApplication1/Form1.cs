using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

using System.Net;
using System.Net.Sockets;

namespace WindowsFormsApplication1
{
   
    public partial class Form1 : Form
    {
        int begin_flag = 0;
        MySocket SA;
        Thread thread;
        //Thread BoxShow;
  
        public Form1()
        {
            InitializeComponent();
          
        }

        void RShow()
        {
            while (true)
            {
                if (SA.flag == 1)
                {
                    SA.flag = 0;
                    ReceiveTextBox.Text += SA.ReData;

                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            

            if (begin_flag == 0)
            {
                SA = new MySocket(IPTextBox.Text, int.Parse(PortTextBox.Text));
                if (SA.Listener() == 1)
                {
                   
                    thread = new Thread(new ThreadStart(SA.Receive));
                    thread.Start();
                    begin_flag = 1;
                    BeginButton.Text = "停止";
                }
            }

            else
            {
                SA.Stop();
                thread.DisableComObjectEagerCleanup();
                
                begin_flag = 0; 
                BeginButton.Text = "开始";
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer1.Interval = 20;  //20ms
            
        }

        private void ReceiveTextBox_Leave(object sender, EventArgs e)
        {
           
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            if (begin_flag==1 && SA != null)
            {
                SA.flag = 0;
                ReceiveTextBox.Text +=  SA.ReData;
                SA.ReData = "";
            }
            timer1.Enabled = true;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(thread != null)thread.DisableComObjectEagerCleanup();
        }

    }
}
