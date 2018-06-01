namespace 实验五_2
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.rdbMath = new System.Windows.Forms.RadioButton();
            this.lblTitle = new System.Windows.Forms.Label();
            this.rdbEng = new System.Windows.Forms.RadioButton();
            this.btnOk = new System.Windows.Forms.Button();
            this.txtFilter = new System.Windows.Forms.TextBox();
            this.rdbDesc = new System.Windows.Forms.RadioButton();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbChi = new System.Windows.Forms.RadioButton();
            this.DataGrid1 = new System.Windows.Forms.DataGrid();
            this.GroupBox2 = new System.Windows.Forms.GroupBox();
            this.rdbAsc = new System.Windows.Forms.RadioButton();
            this.GroupBox3 = new System.Windows.Forms.GroupBox();
            this.GroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid1)).BeginInit();
            this.GroupBox2.SuspendLayout();
            this.GroupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // rdbMath
            // 
            this.rdbMath.Location = new System.Drawing.Point(26, 86);
            this.rdbMath.Name = "rdbMath";
            this.rdbMath.Size = new System.Drawing.Size(76, 29);
            this.rdbMath.TabIndex = 12;
            this.rdbMath.Text = "数学";
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblTitle.Location = new System.Drawing.Point(96, 21);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(461, 28);
            this.lblTitle.TabIndex = 13;
            this.lblTitle.Text = "陕西师范大学计算机班成绩单";
            // 
            // rdbEng
            // 
            this.rdbEng.Location = new System.Drawing.Point(26, 58);
            this.rdbEng.Name = "rdbEng";
            this.rdbEng.Size = new System.Drawing.Size(76, 28);
            this.rdbEng.TabIndex = 11;
            this.rdbEng.Text = "英语";
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(851, 31);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(120, 29);
            this.btnOk.TabIndex = 12;
            this.btnOk.Text = "确定";
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // txtFilter
            // 
            this.txtFilter.Location = new System.Drawing.Point(13, 29);
            this.txtFilter.Name = "txtFilter";
            this.txtFilter.Size = new System.Drawing.Size(281, 25);
            this.txtFilter.TabIndex = 9;
            // 
            // rdbDesc
            // 
            this.rdbDesc.Checked = true;
            this.rdbDesc.Location = new System.Drawing.Point(13, 38);
            this.rdbDesc.Name = "rdbDesc";
            this.rdbDesc.Size = new System.Drawing.Size(77, 29);
            this.rdbDesc.TabIndex = 0;
            this.rdbDesc.TabStop = true;
            this.rdbDesc.Text = "递减";
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.rdbChi);
            this.GroupBox1.Controls.Add(this.rdbEng);
            this.GroupBox1.Controls.Add(this.rdbMath);
            this.GroupBox1.Location = new System.Drawing.Point(685, 89);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(128, 124);
            this.GroupBox1.TabIndex = 11;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "排序字段";
            // 
            // rdbChi
            // 
            this.rdbChi.Checked = true;
            this.rdbChi.Location = new System.Drawing.Point(26, 29);
            this.rdbChi.Name = "rdbChi";
            this.rdbChi.Size = new System.Drawing.Size(76, 29);
            this.rdbChi.TabIndex = 10;
            this.rdbChi.TabStop = true;
            this.rdbChi.Text = "语文";
            // 
            // DataGrid1
            // 
            this.DataGrid1.DataMember = "";
            this.DataGrid1.HeaderForeColor = System.Drawing.SystemColors.ControlText;
            this.DataGrid1.Location = new System.Drawing.Point(7, 79);
            this.DataGrid1.Name = "DataGrid1";
            this.DataGrid1.Size = new System.Drawing.Size(652, 221);
            this.DataGrid1.TabIndex = 10;
            // 
            // GroupBox2
            // 
            this.GroupBox2.Controls.Add(this.rdbDesc);
            this.GroupBox2.Controls.Add(this.rdbAsc);
            this.GroupBox2.Location = new System.Drawing.Point(851, 89);
            this.GroupBox2.Name = "GroupBox2";
            this.GroupBox2.Size = new System.Drawing.Size(128, 124);
            this.GroupBox2.TabIndex = 15;
            this.GroupBox2.TabStop = false;
            this.GroupBox2.Text = "排序方式";
            // 
            // rdbAsc
            // 
            this.rdbAsc.Location = new System.Drawing.Point(13, 77);
            this.rdbAsc.Name = "rdbAsc";
            this.rdbAsc.Size = new System.Drawing.Size(77, 29);
            this.rdbAsc.TabIndex = 1;
            this.rdbAsc.Text = "递增";
            // 
            // GroupBox3
            // 
            this.GroupBox3.Controls.Add(this.txtFilter);
            this.GroupBox3.Location = new System.Drawing.Point(685, 223);
            this.GroupBox3.Name = "GroupBox3";
            this.GroupBox3.Size = new System.Drawing.Size(307, 77);
            this.GroupBox3.TabIndex = 14;
            this.GroupBox3.TabStop = false;
            this.GroupBox3.Text = "过滤条件";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(999, 513);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.GroupBox1);
            this.Controls.Add(this.DataGrid1);
            this.Controls.Add(this.GroupBox2);
            this.Controls.Add(this.GroupBox3);
            this.Name = "Form1";
            this.Text = "41612164_赵旗";
            this.GroupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid1)).EndInit();
            this.GroupBox2.ResumeLayout(false);
            this.GroupBox3.ResumeLayout(false);
            this.GroupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RadioButton rdbMath;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.RadioButton rdbEng;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.TextBox txtFilter;
        private System.Windows.Forms.RadioButton rdbDesc;
        private System.Windows.Forms.GroupBox GroupBox1;
        private System.Windows.Forms.RadioButton rdbChi;
        private System.Windows.Forms.DataGrid DataGrid1;
        private System.Windows.Forms.GroupBox GroupBox2;
        private System.Windows.Forms.RadioButton rdbAsc;
        private System.Windows.Forms.GroupBox GroupBox3;
    }
}

