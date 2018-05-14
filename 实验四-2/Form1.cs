using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 实验四_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblX.Text = "X坐标:" + picTank.Left ;
            lblY.Text = "Y坐标:" + picTank.Top ;
            picTank.Image = picTankU.Image;
            picTankU.Visible = false;
            picTankD.Visible = false;
            picTankL.Visible = false;
            picTankR.Visible = false;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Up:
                    picTank.Image = picTankU.Image;
                    if ((picTank.Top + picTank.Height) <= 0)
                        picTank.Top = this.Height;
                    else
                        picTank.Top -= 10;
                    break;
                case Keys.Down:
                    picTank.Image = picTank.Image;
                    if (picTankD.Top > this.Height)
                        picTank.Top = 0 - picTank.Height;
                    else
                        picTank.Top += 10;
                    break;
                case Keys.Left:
                    picTank.Image = picTankL.Image;
                    if (picTank.Width + picTank.Left <= 0)
                        picTank.Left = this.Width;
                    else
                        picTank.Left -= 10;
                    break;
                case Keys.Right:
                    picTank.Image = picTankR.Image;
                    if (picTank.Left >= this.Width)
                        picTank.Left = 0 - picTank.Width;
                    else
                        picTank.Left += 10;
                    break;
            }
            lblX.Text = "X坐标:" + picTank.Left ;
            lblY.Text = "Y坐标:" + picTank.Top ;
            lblMsg.Text = "现在按下" + e.KeyCode.ToString() + "键，键值为" + Convert.ToInt32(e.KeyCode) + "!!";
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            lblMsg.Text = "请按上下左右键控制坦克！";
        }
    }
}
