using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 实验四_3
{
    public partial class Form1 : Form
    {
        private int oldX,oldY;
        Color pen_color;
        Bitmap bmp;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            piccolor.BackColor = Color.FromArgb(0, 0, 0);
            pen_color = new Color();
            pen_color = Color.Black;
            bmp = new Bitmap(picShow.Width,picShow.Height);
            picShow.Image = bmp;
        }

        private void tkbRed_Scroll(object sender, EventArgs e)
        {
            piccolor.BackColor = Color.FromArgb(tkbRed.Value, tkbGreen.Value, tkbBlue.Value);
            pen_color = piccolor.BackColor;
        }

        private void picShow_MouseDown(object sender, MouseEventArgs e)
        {
                oldX = e.X;
                oldY = e.Y;
        }

        private void picShow_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Graphics g = Graphics.FromImage(bmp);
                Pen pen = new Pen(pen_color,3);
                g.DrawLine(pen, oldX, oldY, e.X, e.Y);
                picShow.Image = bmp;
                oldX = e.X;
                oldY = e.Y;
                picShow.Refresh();
            }
        }
    }
}
