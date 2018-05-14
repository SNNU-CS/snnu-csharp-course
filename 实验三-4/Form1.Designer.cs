namespace 实验四_4
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
            this.tkbRed = new System.Windows.Forms.TrackBar();
            this.pictureshow = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tkbGreen = new System.Windows.Forms.TrackBar();
            this.tkbBlue = new System.Windows.Forms.TrackBar();
            this.label2 = new System.Windows.Forms.Label();
            this.lblRed = new System.Windows.Forms.Label();
            this.lblGreen = new System.Windows.Forms.Label();
            this.lblBlue = new System.Windows.Forms.Label();
            this.lblshow = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tkbRed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureshow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tkbGreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tkbBlue)).BeginInit();
            this.SuspendLayout();
            // 
            // tkbRed
            // 
            this.tkbRed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(1)))), ((int)(((byte)(1)))));
            this.tkbRed.Location = new System.Drawing.Point(243, 52);
            this.tkbRed.Maximum = 255;
            this.tkbRed.Name = "tkbRed";
            this.tkbRed.Size = new System.Drawing.Size(376, 56);
            this.tkbRed.SmallChange = 4;
            this.tkbRed.TabIndex = 0;
            this.tkbRed.TickFrequency = 10;
            this.tkbRed.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.tkbRed.Value = 255;
            this.tkbRed.Scroll += new System.EventHandler(this.tkbRed_Scroll);
            // 
            // pictureshow
            // 
            this.pictureshow.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureshow.Location = new System.Drawing.Point(15, 135);
            this.pictureshow.Name = "pictureshow";
            this.pictureshow.Size = new System.Drawing.Size(131, 131);
            this.pictureshow.TabIndex = 1;
            this.pictureshow.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Red;
            this.label1.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(243, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "0";
            // 
            // tkbGreen
            // 
            this.tkbGreen.BackColor = System.Drawing.Color.Lime;
            this.tkbGreen.Location = new System.Drawing.Point(243, 148);
            this.tkbGreen.Maximum = 255;
            this.tkbGreen.Name = "tkbGreen";
            this.tkbGreen.Size = new System.Drawing.Size(376, 56);
            this.tkbGreen.SmallChange = 4;
            this.tkbGreen.TabIndex = 3;
            this.tkbGreen.TickFrequency = 10;
            this.tkbGreen.Value = 255;
            this.tkbGreen.Scroll += new System.EventHandler(this.tkbRed_Scroll);
            // 
            // tkbBlue
            // 
            this.tkbBlue.BackColor = System.Drawing.Color.Blue;
            this.tkbBlue.Location = new System.Drawing.Point(243, 244);
            this.tkbBlue.Maximum = 255;
            this.tkbBlue.Name = "tkbBlue";
            this.tkbBlue.Size = new System.Drawing.Size(376, 56);
            this.tkbBlue.SmallChange = 4;
            this.tkbBlue.TabIndex = 4;
            this.tkbBlue.TickFrequency = 10;
            this.tkbBlue.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.tkbBlue.Value = 255;
            this.tkbBlue.Scroll += new System.EventHandler(this.tkbRed_Scroll);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Red;
            this.label2.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(580, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 19);
            this.label2.TabIndex = 5;
            this.label2.Text = "255";
            // 
            // lblRed
            // 
            this.lblRed.AutoSize = true;
            this.lblRed.BackColor = System.Drawing.Color.Red;
            this.lblRed.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblRed.Location = new System.Drawing.Point(383, 33);
            this.lblRed.Name = "lblRed";
            this.lblRed.Size = new System.Drawing.Size(39, 19);
            this.lblRed.TabIndex = 6;
            this.lblRed.Text = "255";
            // 
            // lblGreen
            // 
            this.lblGreen.AutoSize = true;
            this.lblGreen.BackColor = System.Drawing.Color.Lime;
            this.lblGreen.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblGreen.Location = new System.Drawing.Point(383, 128);
            this.lblGreen.Name = "lblGreen";
            this.lblGreen.Size = new System.Drawing.Size(39, 19);
            this.lblGreen.TabIndex = 7;
            this.lblGreen.Text = "255";
            // 
            // lblBlue
            // 
            this.lblBlue.AutoSize = true;
            this.lblBlue.BackColor = System.Drawing.Color.Blue;
            this.lblBlue.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblBlue.Location = new System.Drawing.Point(383, 225);
            this.lblBlue.Name = "lblBlue";
            this.lblBlue.Size = new System.Drawing.Size(39, 19);
            this.lblBlue.TabIndex = 8;
            this.lblBlue.Text = "255";
            // 
            // lblshow
            // 
            this.lblshow.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblshow.Font = new System.Drawing.Font("宋体", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblshow.Location = new System.Drawing.Point(12, 319);
            this.lblshow.Name = "lblshow";
            this.lblshow.Size = new System.Drawing.Size(594, 45);
            this.lblshow.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label3.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(28, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "混色结果";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(165, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 48);
            this.label4.TabIndex = 11;
            this.label4.Text = "红";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("宋体", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(165, 143);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 48);
            this.label5.TabIndex = 12;
            this.label5.Text = "绿";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("宋体", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(165, 245);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 48);
            this.label6.TabIndex = 13;
            this.label6.Text = "蓝";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Lime;
            this.label7.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.Location = new System.Drawing.Point(580, 128);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 19);
            this.label7.TabIndex = 15;
            this.label7.Text = "255";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Lime;
            this.label8.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.Location = new System.Drawing.Point(243, 128);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(19, 19);
            this.label8.TabIndex = 14;
            this.label8.Text = "0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.RoyalBlue;
            this.label9.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label9.Location = new System.Drawing.Point(580, 225);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(39, 19);
            this.label9.TabIndex = 17;
            this.label9.Text = "255";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.RoyalBlue;
            this.label10.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label10.Location = new System.Drawing.Point(243, 225);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(19, 19);
            this.label10.TabIndex = 16;
            this.label10.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 385);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblshow);
            this.Controls.Add(this.lblBlue);
            this.Controls.Add(this.lblGreen);
            this.Controls.Add(this.lblRed);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tkbBlue);
            this.Controls.Add(this.tkbGreen);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureshow);
            this.Controls.Add(this.tkbRed);
            this.Name = "Form1";
            this.Text = "调色板";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tkbRed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureshow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tkbGreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tkbBlue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar tkbRed;
        private System.Windows.Forms.PictureBox pictureshow;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar tkbGreen;
        private System.Windows.Forms.TrackBar tkbBlue;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblRed;
        private System.Windows.Forms.Label lblGreen;
        private System.Windows.Forms.Label lblBlue;
        private System.Windows.Forms.Label lblshow;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
    }
}

