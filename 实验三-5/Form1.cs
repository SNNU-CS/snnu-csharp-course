using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 实验三_5
{
    public partial class Form1 : Form
    {
        int n=0;

        public Form1()
        {
            InitializeComponent();
            pic1.Visible = false;
            pic2.Visible = false;
            pic3.Visible = false;
            pic4.Visible = false;
            timer1.Interval = 100;
            timer1.Enabled = true;
            picRunner.Location = new Point(this.Width, 130);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            switch(n%4)
            {
                case 0:
                    picRunner.Image = pic1.Image;
                    n++;
                    break;
                case 1:
                    picRunner.Image = pic2.Image;
                    n++;
                    break;
                case 2:
                    picRunner.Image = pic3.Image;
                    n++;
                    break;
                case 3:
                    picRunner.Image = pic4.Image;
                    n = 0;
                    break;
            }
            if (picRunner.Location.X + picRunner.Width > 0)
                picRunner.Location = new Point(picRunner.Location.X - 10, 130);
            else
                picRunner.Location = new Point(this.Width, 130);
        }

        private void Form1_Resize(object sender, EventArgs e)
        {

            this.Size = new Size(493, 289);
        }
    }
}
