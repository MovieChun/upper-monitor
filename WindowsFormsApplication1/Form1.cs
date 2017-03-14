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
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Text = "哈哈哈哈";
            //this.BackColor = Color.FromArgb(0, 0, 0);
            textBox3.Text = textBox1.Text + "\r\n" + textBox2.Text;
        }
    }
}
