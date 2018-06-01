using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace 实验五_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string selectCmd = "Select * from MEMBER";
            string connStr = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=MEMBERDB.mdb";
            OleDbConnection conn;
            OleDbDataAdapter myAdapter;
            DataSet myDataSet = new DataSet();
            conn = new OleDbConnection(connStr);
            conn.Open();
            myAdapter = new OleDbDataAdapter(selectCmd, conn);
            myAdapter.Fill(myDataSet, "MEMBER");
            cboId.DataSource = myDataSet;
            cboId.DisplayMember = "MEMBER.id_no";

            txtName.DataBindings.Add("Text", myDataSet, "MEMBER.name");
            txtTel.DataBindings.Add("Text", myDataSet, "MEMBER.tel");
            txtSex.DataBindings.Add("Text", myDataSet, "MEMBER.sex");
            txtAdd.DataBindings.Add("Text", myDataSet, "MEMBER.address");

            DataGrid1.DataSource = myDataSet;
            DataGrid1.DataMember = "MEMBER";

            //DataGrid1.DataSource = myDataSet.Tables["MEMBER"];
            //DataGrid1.DataSource = myDataSet.Tables["MEMBER"].DefaultView;
        }
    }
}
