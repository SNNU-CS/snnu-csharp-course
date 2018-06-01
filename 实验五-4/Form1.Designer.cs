namespace 实验五_4
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
            this.cboOrderId = new System.Windows.Forms.ComboBox();
            this.txtDate = new System.Windows.Forms.TextBox();
            this.txtCustomers = new System.Windows.Forms.TextBox();
            this.dgDetail = new System.Windows.Forms.DataGrid();
            this.btnEnd = new System.Windows.Forms.Button();
            this.dgTitle = new System.Windows.Forms.DataGrid();
            this.Label6 = new System.Windows.Forms.Label();
            this.Label5 = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgDetail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgTitle)).BeginInit();
            this.SuspendLayout();
            // 
            // cboOrderId
            // 
            this.cboOrderId.DropDownWidth = 96;
            this.cboOrderId.Location = new System.Drawing.Point(813, 150);
            this.cboOrderId.Name = "cboOrderId";
            this.cboOrderId.Size = new System.Drawing.Size(154, 23);
            this.cboOrderId.TabIndex = 23;
            // 
            // txtDate
            // 
            this.txtDate.Location = new System.Drawing.Point(813, 226);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(205, 25);
            this.txtDate.TabIndex = 22;
            // 
            // txtCustomers
            // 
            this.txtCustomers.Location = new System.Drawing.Point(813, 188);
            this.txtCustomers.Name = "txtCustomers";
            this.txtCustomers.Size = new System.Drawing.Size(205, 25);
            this.txtCustomers.TabIndex = 21;
            // 
            // dgDetail
            // 
            this.dgDetail.DataMember = "";
            this.dgDetail.HeaderForeColor = System.Drawing.SystemColors.ControlText;
            this.dgDetail.Location = new System.Drawing.Point(147, 342);
            this.dgDetail.Name = "dgDetail";
            this.dgDetail.Size = new System.Drawing.Size(538, 163);
            this.dgDetail.TabIndex = 20;
            // 
            // btnEnd
            // 
            this.btnEnd.Location = new System.Drawing.Point(711, 284);
            this.btnEnd.Name = "btnEnd";
            this.btnEnd.Size = new System.Drawing.Size(120, 29);
            this.btnEnd.TabIndex = 19;
            this.btnEnd.Text = "退出";
            this.btnEnd.Click += new System.EventHandler(this.btnEnd_Click);
            // 
            // dgTitle
            // 
            this.dgTitle.DataMember = "";
            this.dgTitle.HeaderForeColor = System.Drawing.SystemColors.ControlText;
            this.dgTitle.Location = new System.Drawing.Point(147, 140);
            this.dgTitle.Name = "dgTitle";
            this.dgTitle.Size = new System.Drawing.Size(538, 163);
            this.dgTitle.TabIndex = 18;
            // 
            // Label6
            // 
            this.Label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Label6.Font = new System.Drawing.Font("宋体", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Label6.Location = new System.Drawing.Point(263, 54);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(499, 57);
            this.Label6.TabIndex = 17;
            this.Label6.Text = "陕西师范大学订单";
            this.Label6.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // Label5
            // 
            this.Label5.Location = new System.Drawing.Point(711, 226);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(89, 28);
            this.Label5.TabIndex = 16;
            this.Label5.Text = "订购日期";
            this.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label4
            // 
            this.Label4.Location = new System.Drawing.Point(711, 188);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(89, 28);
            this.Label4.TabIndex = 15;
            this.Label4.Text = "客户名称";
            this.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label3
            // 
            this.Label3.Location = new System.Drawing.Point(711, 150);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(89, 27);
            this.Label3.TabIndex = 14;
            this.Label3.Text = "订单编号";
            this.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label2
            // 
            this.Label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Label2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Label2.Location = new System.Drawing.Point(7, 332);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(115, 28);
            this.Label2.TabIndex = 13;
            this.Label2.Text = "订单明细";
            // 
            // Label1
            // 
            this.Label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Label1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Label1.Location = new System.Drawing.Point(7, 140);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(115, 28);
            this.Label1.TabIndex = 12;
            this.Label1.Text = "订单";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1022, 585);
            this.Controls.Add(this.cboOrderId);
            this.Controls.Add(this.txtDate);
            this.Controls.Add(this.txtCustomers);
            this.Controls.Add(this.dgDetail);
            this.Controls.Add(this.btnEnd);
            this.Controls.Add(this.dgTitle);
            this.Controls.Add(this.Label6);
            this.Controls.Add(this.Label5);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Label1);
            this.Name = "Form1";
            this.Text = "41612164_赵旗";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgDetail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgTitle)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboOrderId;
        private System.Windows.Forms.TextBox txtDate;
        private System.Windows.Forms.TextBox txtCustomers;
        private System.Windows.Forms.DataGrid dgDetail;
        private System.Windows.Forms.Button btnEnd;
        private System.Windows.Forms.DataGrid dgTitle;
        private System.Windows.Forms.Label Label6;
        private System.Windows.Forms.Label Label5;
        private System.Windows.Forms.Label Label4;
        private System.Windows.Forms.Label Label3;
        private System.Windows.Forms.Label Label2;
        private System.Windows.Forms.Label Label1;
    }
}

