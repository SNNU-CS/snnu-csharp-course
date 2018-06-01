using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace 实验五_5
{
    public partial class Form1 : Form
    {
        BindingManagerBase Bm;
        public Form1()
        {
            InitializeComponent();
        }

        private void CheckBm()
        {
            if (Bm.Position == 0)
            {
                btnFirst.Enabled = false;
                btnPrev.Enabled = false;
                btnNext.Enabled = true;
                btnLast.Enabled = true;
            }
            else if (Bm.Position == Bm.Count - 1)
            {

                btnFirst.Enabled = true;
                btnPrev.Enabled = true;
                btnNext.Enabled = false;
                btnLast.Enabled = false;
            }
            else
            {
                btnFirst.Enabled = true;
                btnPrev.Enabled = true;
                btnNext.Enabled = true;
                btnLast.Enabled = true;
            }
            lblShow.Text = (Bm.Position + 1) + "/" + Bm.Count;
        }
        private void btnFirst_Click(object sender, EventArgs e)
        {
            Bm.Position = 0;
            CheckBm();
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            Bm.Position -= 1;
            CheckBm();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            Bm.Position += 1;
            CheckBm();
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            Bm.Position = Bm.Count - 1;
            CheckBm();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string selectCmd = "select id_no as 书号, name as 书名, price as 单价, qty as 数量 From BOOK";
            string connStr = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=BOOKDB.mdb";
            OleDbConnection conn;
            OleDbDataAdapter myAdapter;
            DataSet myDataSet = new DataSet();
            conn = new OleDbConnection(connStr);
            conn.Open();
            myAdapter = new OleDbDataAdapter(selectCmd, conn);
            myAdapter.Fill(myDataSet, "BOOK");
            Binding bindId = new Binding("Text", myDataSet, "BOOK.书号");
            Binding bindName = new Binding("Text", myDataSet, "BOOK.书名");
            Binding bindPrice = new Binding("Text", myDataSet, "BOOK.单价");
            Binding bindQty = new Binding("Text", myDataSet, "BOOK.数量");
            txtId.DataBindings.Add(bindId);
            txtName.DataBindings.Add(bindName);
            txtPrice.DataBindings.Add(bindPrice);
            txtQty.DataBindings.Add(bindQty);
            Bm = this.BindingContext[myDataSet, "BOOK"];
            CheckBm();
        }
    }
}
