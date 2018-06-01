using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace 实验五_2
{
    public partial class Form1 : Form
    {
        string selectCmd = "Select id_no as 学号, name as 姓名, chi as 语文, eng as 英语, math as 数学 From SCORE";

        public Form1()
        {
            InitializeComponent();
            DataGrid1.DataSource = CreateView("SCOREDB.mdb", selectCmd, "SCORE");
        }
        private DataView CreateView(string DBName, string SQLcmd, string TabName)
        {
            string connstr = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + DBName;
            OleDbConnection conn;
            OleDbDataAdapter myAdapter;
            DataSet myDataSet = new DataSet();
            conn = new OleDbConnection(connstr);
            conn.Open();
            myAdapter = new OleDbDataAdapter(SQLcmd, conn);
            myAdapter.Fill(myDataSet, TabName);
            return myDataSet.Tables[TabName].DefaultView;
        }
        private void btnOk_Click(object sender, EventArgs e)
        {
            string sortStr = string.Empty;
            if (rdbChi.Checked)
                sortStr += rdbChi.Text;
            if (rdbEng.Checked)
                sortStr += rdbEng.Text;
            if (rdbMath.Checked)
                sortStr += rdbMath.Text;
            if (rdbDesc.Checked)
                sortStr += " DESC";
            if (rdbAsc.Checked)
                sortStr += " ASC";
            DataView myDataView = new DataView();
            myDataView = CreateView("SCOREDB.mdb", selectCmd, "SCORE");
            myDataView.RowFilter = txtFilter.Text;
            myDataView.Sort = sortStr;
            DataGrid1.DataSource = myDataView;
        }
    }
}
