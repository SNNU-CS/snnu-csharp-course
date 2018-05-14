using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 实验四_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.textBox1.TextChanged += new System.EventHandler(Mybutton_Click);
            this.textBox2.TextChanged += new System.EventHandler(Mybutton_Click);
            textBox1.Text = "";
            textBox2.Text = "";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            this.textBox1.TextChanged += new System.EventHandler(Mybutton_Click);
            this.textBox2.TextChanged += new System.EventHandler(Mybutton_Click);
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            this.textBox1.TextChanged -= new System.EventHandler(Mybutton_Click);
            this.textBox2.TextChanged -= new System.EventHandler(Mybutton_Click);
        }
        private void Mybutton_Click(object sender, EventArgs e)
        {
            //string x=Convert.ToString(Convert.ToInt32(textBox1.Text)+ Convert.ToInt32(textBox2.Text));
            long a = string.IsNullOrEmpty(textBox1.Text) ? 0 : Convert.ToInt64(textBox1.Text);
            long b = string.IsNullOrEmpty(textBox2.Text) ? 0 : Convert.ToInt64(textBox2.Text);
            label3.Text = (a + b).ToString();
        }
    }
}
