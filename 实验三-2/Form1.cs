using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 实验三_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Label mylabel = new Label();
            this.Controls.Add(mylabel);
            mylabel.Width = 200;
            mylabel.Height = 20;
            mylabel.Top = 10;
            mylabel.BackColor = Color.Red;
            mylabel.AutoSize = true;
            mylabel.Text = "欢迎光临.....大家好!";
            mylabel.Font = new Font("宋体", 17);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 yourform = new Form2();
            yourform.Show();
            yourform.label1.Font = new Font("宋体", 36);
            yourform.label1.Text = "这是窗体2!";
            yourform.label1.AutoSize = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }
    }
}
