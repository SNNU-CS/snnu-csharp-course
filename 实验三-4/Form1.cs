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

        private void tkbRed_Scroll(object sender, EventArgs e)
        {
            pictureshow.BackColor = Color.FromArgb(tkbRed.Value, tkbGreen.Value, tkbBlue.Value);
            lblshow.Text = "当前设置:RGB(" + tkbRed.Value.ToString() + "," +
                tkbGreen.Value.ToString() + "," + tkbBlue.Value.ToString() + ")";
            lblRed.Text = tkbRed.Value.ToString();
            lblGreen.Text = tkbGreen.Value.ToString();
            lblBlue.Text = tkbBlue.Value.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pictureshow.BackColor = Color.FromArgb(tkbRed.Value, tkbGreen.Value, tkbBlue.Value);
            lblshow.Text = "当前设置:RGB(" + tkbRed.Value.ToString() + "," +
                tkbGreen.Value.ToString() + "," + tkbBlue.Value.ToString() + ")";
        }
    }
}
