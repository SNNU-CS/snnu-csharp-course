using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace 实验五_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ShowPerson();
        }
        private void ShowPerson()
        {
            string connStr, selectCmd;
            connStr = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=PERSONDB.mdb";
            selectCmd = "Select id_no AS 序号,name AS 姓名,id_position AS 职位,tel AS 电话,salary AS 工资  From PERSON Order By id_no DESC";
            OleDbConnection conn;
            OleDbDataAdapter myAdapter;
            DataSet myDataSet = new DataSet();
            conn = new OleDbConnection(connStr);
            conn.Open();
            myAdapter = new OleDbDataAdapter(selectCmd, conn);
            myAdapter.Fill(myDataSet, "PERSON");
            DataGrid1.DataSource = myDataSet.Tables["PERSON"];
        }
        string GetSqlStr(string str)
        {
            return str.Replace("'", "''");
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            string connStr, insertCmd;
            connStr = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=PERSONDB.mdb";
            //insertCmd = "Insert Into PERSON(name, id_position, tel, salary) Values('" + GetSqlStr(txtName.Text) + "','" + GetSqlStr(txtPosition.Text) + "','" + GetSqlStr(txtTel.Text) + "'," + txtSalary.Text + ")";
            insertCmd = "Insert Into PERSON(name, id_position, tel, salary) Values(@姓名, @职称, @电话, @工资)";
            OleDbConnection conn = new OleDbConnection(connStr);
            conn.Open();
            OleDbCommand cmd = new OleDbCommand(insertCmd, conn);
            cmd.Parameters.Add(new OleDbParameter("@姓名", OleDbType.Char));
            cmd.Parameters.Add(new OleDbParameter("@职称", OleDbType.Char));
            cmd.Parameters.Add(new OleDbParameter("@电话", OleDbType.Char));
            cmd.Parameters.Add(new OleDbParameter("@工资", OleDbType.Integer));
            cmd.Parameters["@姓名"].Value = txtName.Text;
            cmd.Parameters["@职称"].Value = txtPosition.Text;
            cmd.Parameters["@电话"].Value = txtTel.Text;
            cmd.Parameters["@工资"].Value = Convert.ToInt32( txtSalary.Text);
            cmd.ExecuteNonQuery();
            conn.Close();
            ShowPerson();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string connStr, updateCmd;
            connStr = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=PERSONDB.mdb";
            updateCmd = "UPDATE PERSON Set id_position=@职称, tel=@电话, salary=@工资 Where name=@姓名";
            OleDbConnection conn = new OleDbConnection(connStr);
            conn.Open();
            OleDbCommand cmd = new OleDbCommand(updateCmd, conn);
            cmd = new OleDbCommand(updateCmd, conn);
            cmd.Parameters.Add(new OleDbParameter("@职称", OleDbType.Char));
            cmd.Parameters.Add(new OleDbParameter("@电话", OleDbType.Char));
            cmd.Parameters.Add(new OleDbParameter("@工资", OleDbType.Integer));
            cmd.Parameters.Add(new OleDbParameter("@姓名", OleDbType.Char));
            cmd.Parameters["@职称"].Value = txtPosition.Text;
            cmd.Parameters["@电话"].Value = txtTel.Text;
            cmd.Parameters["@工资"].Value = Convert.ToInt32( txtSalary.Text);
            cmd.Parameters["@姓名"].Value = txtName.Text;
            cmd.ExecuteNonQuery();
            conn.Close();
            ShowPerson();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            string connStr, delCmd;
            connStr = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=PERSONDB.mdb";
            delCmd = "Delete From PERSON Where name = '" + GetSqlStr(txtName.Text) + "'";
            OleDbConnection conn = new OleDbConnection(connStr);
            conn.Open();
            OleDbCommand cmd = new OleDbCommand(delCmd, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
            ShowPerson();
        }
    }
}
