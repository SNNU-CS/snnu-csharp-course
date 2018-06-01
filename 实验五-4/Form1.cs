using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace 实验五_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string selectCmd1, selectCmd2, connstr;
            selectCmd1 = "Select order_id as 订单编号, customers as 客户名称, order_date as 订购日期 From ORDERTITLE";
            selectCmd2 = "Select order_id as 订单编号, PRODUCT as 订购产品, price as 产品单价, qty as 订购数量 From ORDERDETAIL";
            connstr = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=ORDERSDB.mdb";
            OleDbConnection conn;
            OleDbDataAdapter myAdapter;
            DataSet myDataSet = new DataSet();
            conn = new OleDbConnection(connstr);
            conn.Open();
            myAdapter = new OleDbDataAdapter(selectCmd1, conn);
            myAdapter.Fill(myDataSet, "ORDERTITLE");
            myAdapter = new OleDbDataAdapter(selectCmd2, conn);
            myAdapter.Fill(myDataSet, "ORDERDETAIL");
            myDataSet.Relations.Add("relations_order_id", myDataSet.Tables["ORDERTITLE"].Columns["订单编号"],
            myDataSet.Tables["ORDERDETAIL"].Columns["订单编号"]);
            dgTitle.DataSource = myDataSet;
            dgTitle.DataMember = "ORDERTITLE";
            dgDetail.DataSource = myDataSet;
            dgDetail.DataMember = "ORDERTITLE.relations_order_id";
            cboOrderId.DataSource = myDataSet;
            cboOrderId.DisplayMember = "ORDERTITLE.订单编号";
            txtCustomers.DataBindings.Add("Text", myDataSet, "ORDERTITLE.客户名称");
            txtDate.DataBindings.Add("Text", myDataSet, "ORDERTITLE.订购日期");
        }

        private void btnEnd_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
