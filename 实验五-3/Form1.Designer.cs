namespace 实验五_3
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
            this.cboId = new System.Windows.Forms.ComboBox();
            this.txtAdd = new System.Windows.Forms.TextBox();
            this.txtSex = new System.Windows.Forms.TextBox();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.DataGrid1 = new System.Windows.Forms.DataGrid();
            this.Label5 = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid1)).BeginInit();
            this.SuspendLayout();
            // 
            // cboId
            // 
            this.cboId.DropDownWidth = 121;
            this.cboId.Location = new System.Drawing.Point(29, 45);
            this.cboId.Name = "cboId";
            this.cboId.Size = new System.Drawing.Size(194, 23);
            this.cboId.TabIndex = 21;
            this.cboId.Text = "ComboBox1";
            // 
            // txtAdd
            // 
            this.txtAdd.Location = new System.Drawing.Point(413, 122);
            this.txtAdd.Name = "txtAdd";
            this.txtAdd.Size = new System.Drawing.Size(231, 25);
            this.txtAdd.TabIndex = 20;
            // 
            // txtSex
            // 
            this.txtSex.Location = new System.Drawing.Point(413, 84);
            this.txtSex.Name = "txtSex";
            this.txtSex.Size = new System.Drawing.Size(231, 25);
            this.txtSex.TabIndex = 19;
            // 
            // txtTel
            // 
            this.txtTel.Location = new System.Drawing.Point(29, 122);
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(244, 25);
            this.txtTel.TabIndex = 18;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(29, 84);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(244, 25);
            this.txtName.TabIndex = 17;
            // 
            // DataGrid1
            // 
            this.DataGrid1.DataMember = "";
            this.DataGrid1.HeaderForeColor = System.Drawing.SystemColors.ControlText;
            this.DataGrid1.Location = new System.Drawing.Point(15, 180);
            this.DataGrid1.Name = "DataGrid1";
            this.DataGrid1.Size = new System.Drawing.Size(755, 201);
            this.DataGrid1.TabIndex = 16;
            // 
            // Label5
            // 
            this.Label5.Location = new System.Drawing.Point(337, 122);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(64, 28);
            this.Label5.TabIndex = 15;
            this.Label5.Text = "住址";
            // 
            // Label4
            // 
            this.Label4.Location = new System.Drawing.Point(337, 84);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(64, 27);
            this.Label4.TabIndex = 14;
            this.Label4.Text = "性别";
            // 
            // Label3
            // 
            this.Label3.Location = new System.Drawing.Point(-47, 122);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(64, 28);
            this.Label3.TabIndex = 13;
            this.Label3.Text = "电话";
            // 
            // Label2
            // 
            this.Label2.Location = new System.Drawing.Point(-47, 84);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(64, 27);
            this.Label2.TabIndex = 12;
            this.Label2.Text = "姓名";
            // 
            // Label1
            // 
            this.Label1.Location = new System.Drawing.Point(-47, 45);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(64, 28);
            this.Label1.TabIndex = 11;
            this.Label1.Text = "编号";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 440);
            this.Controls.Add(this.cboId);
            this.Controls.Add(this.txtAdd);
            this.Controls.Add(this.txtSex);
            this.Controls.Add(this.txtTel);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.DataGrid1);
            this.Controls.Add(this.Label5);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Label1);
            this.Name = "Form1";
            this.Text = "41612164_赵旗";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboId;
        private System.Windows.Forms.TextBox txtAdd;
        private System.Windows.Forms.TextBox txtSex;
        private System.Windows.Forms.TextBox txtTel;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.DataGrid DataGrid1;
        private System.Windows.Forms.Label Label5;
        private System.Windows.Forms.Label Label4;
        private System.Windows.Forms.Label Label3;
        private System.Windows.Forms.Label Label2;
        private System.Windows.Forms.Label Label1;
    }
}

