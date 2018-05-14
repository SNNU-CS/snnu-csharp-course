using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 实验三_6
{
    public partial class Form1 : Form
    {
        string fontstyle = "宋体";
        int fontsize = 48;
        public Form1()
        {
            InitializeComponent();
            label1.AutoSize = true;
        }

        private void 宋体ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fontstyle = "宋体";
            label1.Font = new Font(fontstyle, fontsize);
        }

        private void 楷体ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fontstyle = "楷体";
            label1.Font = new Font(fontstyle, fontsize);
        }

        private void 白色ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label1.ForeColor = Color.White;
        }

        private void 浅蓝ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label1.ForeColor = Color.LightBlue;
        }

        private void 黄色ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label1.ForeColor = Color.Yellow;
        }

        private void 红色ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label1.BackColor = Color.Red;
        }

        private void 深蓝色ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label1.BackColor = Color.Blue;
        }

        private void 深绿色ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label1.BackColor = Color.Green;
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            fontsize = 10;
            label1.Font = new Font(fontstyle, fontsize);
        }

        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {
            fontsize = 24;
            label1.Font = new Font(fontstyle, fontsize);
        }

        private void toolStripMenuItem7_Click(object sender, EventArgs e)
        {
            fontsize = 36;
            label1.Font = new Font(fontstyle, fontsize);
        }
    }
}
