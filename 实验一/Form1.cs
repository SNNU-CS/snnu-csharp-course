using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 实验一
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Please Select button", "Hello", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dr == DialogResult.OK)
            {
                //点确定的代码
                this.BackColor = Color.Red;
            }
            else
            {
                //点取消的代码   
                this.WindowState = FormWindowState.Maximized;
                this.BackColor = Color.Yellow;
            }
        }
    }
}
