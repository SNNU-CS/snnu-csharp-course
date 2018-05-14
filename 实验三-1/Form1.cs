using System;
using System.Drawing;
using System.Windows.Forms;

namespace 实验三_1
{
    public partial class Form1 : Form
    {
        Boolean flag=true ;//跑马灯方向朝左
        public Form1()
        {
            InitializeComponent();
            lblMsg.BackColor = Color.Aqua;
            lblMsg.Text = "41612164_赵旗";
            timer1.Enabled = true;
            timer1.Interval = 10;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblLocation.Text = "跑马灯位置:" + lblMsg.Left;
            if(flag==true )//左移
            {
                lblMsg.Left -= 1;
                lblDirection.Text = "目前方向:往左移";
                if (lblMsg.Left <= 0)
                    flag = false;
            }
            else//右移
            {
                lblMsg.Left += 1;
                lblDirection.Text = "目前方向:  往右移";
                if (lblMsg.Width+lblMsg.Left >= this.Width)
                    flag = true;
            }
        }
    }
}
