namespace 实验五_5
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
            this.btnLast = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPrev = new System.Windows.Forms.Button();
            this.btnFirst = new System.Windows.Forms.Button();
            this.lblShow = new System.Windows.Forms.Label();
            this.Label5 = new System.Windows.Forms.Label();
            this.txtQty = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnLast
            // 
            this.btnLast.Location = new System.Drawing.Point(430, 223);
            this.btnLast.Name = "btnLast";
            this.btnLast.Size = new System.Drawing.Size(120, 29);
            this.btnLast.TabIndex = 27;
            this.btnLast.Text = "最后一条";
            this.btnLast.Click += new System.EventHandler(this.btnLast_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(289, 223);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(120, 29);
            this.btnNext.TabIndex = 26;
            this.btnNext.Text = "下一条";
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPrev
            // 
            this.btnPrev.Location = new System.Drawing.Point(149, 223);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(120, 29);
            this.btnPrev.TabIndex = 25;
            this.btnPrev.Text = "上一条";
            this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click);
            // 
            // btnFirst
            // 
            this.btnFirst.Location = new System.Drawing.Point(8, 223);
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.Size = new System.Drawing.Size(120, 29);
            this.btnFirst.TabIndex = 24;
            this.btnFirst.Text = "第一条";
            this.btnFirst.Click += new System.EventHandler(this.btnFirst_Click);
            // 
            // lblShow
            // 
            this.lblShow.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblShow.Location = new System.Drawing.Point(481, 69);
            this.lblShow.Name = "lblShow";
            this.lblShow.Size = new System.Drawing.Size(77, 28);
            this.lblShow.TabIndex = 23;
            this.lblShow.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label5
            // 
            this.Label5.Location = new System.Drawing.Point(366, 69);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(115, 28);
            this.Label5.TabIndex = 22;
            this.Label5.Text = "数据条数：";
            this.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtQty
            // 
            this.txtQty.Location = new System.Drawing.Point(85, 184);
            this.txtQty.Name = "txtQty";
            this.txtQty.Size = new System.Drawing.Size(256, 25);
            this.txtQty.TabIndex = 21;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(85, 146);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(256, 25);
            this.txtPrice.TabIndex = 20;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(85, 108);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(256, 25);
            this.txtName.TabIndex = 19;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(85, 69);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(256, 25);
            this.txtId.TabIndex = 18;
            // 
            // Label4
            // 
            this.Label4.Location = new System.Drawing.Point(21, 184);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(51, 28);
            this.Label4.TabIndex = 17;
            this.Label4.Text = "数量";
            this.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label3
            // 
            this.Label3.Location = new System.Drawing.Point(21, 146);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(51, 28);
            this.Label3.TabIndex = 16;
            this.Label3.Text = "单价";
            this.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label2
            // 
            this.Label2.Location = new System.Drawing.Point(21, 108);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(51, 27);
            this.Label2.TabIndex = 15;
            this.Label2.Text = "书名";
            this.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label1
            // 
            this.Label1.Location = new System.Drawing.Point(21, 69);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(51, 28);
            this.Label1.TabIndex = 14;
            this.Label1.Text = "书号";
            this.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 326);
            this.Controls.Add(this.btnLast);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPrev);
            this.Controls.Add(this.btnFirst);
            this.Controls.Add(this.lblShow);
            this.Controls.Add(this.Label5);
            this.Controls.Add(this.txtQty);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Label1);
            this.Name = "Form1";
            this.Text = "41612164_赵旗";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLast;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPrev;
        private System.Windows.Forms.Button btnFirst;
        private System.Windows.Forms.Label lblShow;
        private System.Windows.Forms.Label Label5;
        private System.Windows.Forms.TextBox txtQty;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label Label4;
        private System.Windows.Forms.Label Label3;
        private System.Windows.Forms.Label Label2;
        private System.Windows.Forms.Label Label1;
    }
}

