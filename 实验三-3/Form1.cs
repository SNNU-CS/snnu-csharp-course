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
        double time;//时间
        int count;//次数
        int[,] a;
        Random rand;

        public Form1()
        {
            InitializeComponent();
            btnStart.Enabled = true;
            btnEnd.Enabled = false;
            timer1.Interval = 100;
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;
            button7.Enabled = false;
            button8.Enabled = false;
            button9.Enabled = false;
        }

        private void btnEnd_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
            button7.Enabled = true;
            button8.Enabled = true;
            button9.Enabled = true;
            count = 0;
            time = 0.0;
            timer1.Enabled = true;
            btnStart.Enabled = false;
            btnEnd.Enabled = true;
            a = new int[4, 4];
            rand = new Random((int)DateTime.Now.Ticks);
            for (int i = 1; i <= 3; i++)
                for (int j = 1; j <= 3; j++)
                {
                    if (rand.NextDouble() > 0.5)
                        a[i, j] = 1;
                    else
                        a[i, j] = -1;
                }
            Display();
        }
        private void Display()
        {
            if (a[1, 1] == 1)
                button1.BackColor = Color.Coral;
            else
                button1.BackColor = Color.Yellow;
            if ((a[1, 2] == 1))
                button2.BackColor = Color.Coral;
            else
                button2.BackColor = Color.Yellow;
            if (a[1, 3] == 1)
                button3.BackColor = Color.Coral;
            else
                button3.BackColor = Color.Yellow;
            if (a[2, 1] == 1)
                button4.BackColor = Color.Coral;
            else
                button4.BackColor = Color.Yellow;
            if (a[2, 2] == 1)
                button5.BackColor = Color.Coral;
            else
                button5.BackColor = Color.Yellow;
            if (a[2, 3] == 1)
                button6.BackColor = Color.Coral;
            else
                button6.BackColor = Color.Yellow;
            if (a[3, 1] == 1)
                button7.BackColor = Color.Coral;
            else
                button7.BackColor = Color.Yellow;
            if (a[3, 2] == 1)
                button8.BackColor = Color.Coral;
            else
                button8.BackColor = Color.Yellow;
            if (a[3, 3] == 1)
                button9.BackColor = Color.Coral;
            else
                button9.BackColor = Color.Yellow;
            lblCount.Text = "次数: " + count + "次";
        }
        private void Check()
        {
            int sum = 0;
            for (int i = 1; i <= 3; i++)
                for (int j = 1; j <= 3; j++)
                {
                    sum += a[i, j];
                }
            if (sum == 7 && a[2, 2] == -1)
            {
                btnStart.Enabled = true;
                time = 0;
                timer1.Enabled = false;
                MessageBox.Show("恭喜!过关......");
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            time += 0.1;
            lblTime.Text = "秒数： " + time.ToString("0.0") + "秒";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            count++;
            string temp = ((Button)sender).Text;
            switch (temp)
            {
                case "1":
                    a[1, 1] = -a[1, 1];
                    a[1, 2] = -a[1, 2];
                    a[2, 1] = -a[2, 1];
                    a[2, 2] = -a[2, 2];
                    break;
                case "2":
                    a[1, 1] = -a[1, 1];
                    a[1, 2] = -a[1, 2];
                    a[1, 3] = -a[1, 3];
                    break;
                case "3":
                    a[1, 2] = -a[1, 2];
                    a[1, 3] = -a[1, 3];
                    a[2, 2] = -a[2, 2];
                    a[2, 3] = -a[2, 3];
                    break;
                case "4":
                    a[1, 1] = -a[1, 1];
                    a[2, 1] = -a[2, 1];
                    a[3, 1] = -a[3, 1];
                    break;
                case "5":
                    a[1, 2] = -a[1, 2];
                    a[2, 1] = -a[2, 1];
                    a[2, 2] = -a[2, 2];
                    a[2, 3] = -a[2, 3];
                    a[3, 2] = -a[3, 2];
                    break;
                case "6":
                    a[1, 3] = -a[1, 3];
                    a[2, 3] = -a[2, 3];
                    a[3, 3] = -a[3, 3];
                    break;
                case "7":
                    a[2, 1] = -a[2, 1];
                    a[2, 2] = -a[2, 2];
                    a[3, 1] = -a[3, 1];
                    a[3, 2] = -a[3, 2];
                    break;
                case "8":
                    a[3, 1] = -a[3, 1];
                    a[3, 2] = -a[3, 2];
                    a[3, 3] = -a[3, 3];
                    break;
                case "9":
                    a[2, 2] = -a[2, 2];
                    a[2, 3] = -a[2, 3];
                    a[3, 2] = -a[3, 2];
                    a[3, 3] = -a[3, 3];
                    break;
            }
            Display();
            Check();
        }
    }
}
