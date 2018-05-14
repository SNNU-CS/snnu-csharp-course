namespace 实验四_3
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
            this.tkbBlue = new System.Windows.Forms.TrackBar();
            this.tkbGreen = new System.Windows.Forms.TrackBar();
            this.piccolor = new System.Windows.Forms.PictureBox();
            this.picShow = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.tkbRed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tkbBlue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tkbGreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.piccolor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picShow)).BeginInit();
            this.SuspendLayout();
            // 
            // tkbRed
            // 
            this.tkbRed.BackColor = System.Drawing.Color.LightCoral;
            this.tkbRed.Location = new System.Drawing.Point(320, 48);
            this.tkbRed.Maximum = 255;
            this.tkbRed.Name = "tkbRed";
            this.tkbRed.Size = new System.Drawing.Size(422, 56);
            this.tkbRed.SmallChange = 2;
            this.tkbRed.TabIndex = 0;
            this.tkbRed.TickFrequency = 6;
            this.tkbRed.Scroll += new System.EventHandler(this.tkbRed_Scroll);
            // 
            // tkbBlue
            // 
            this.tkbBlue.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.tkbBlue.Location = new System.Drawing.Point(320, 188);
            this.tkbBlue.Maximum = 255;
            this.tkbBlue.Name = "tkbBlue";
            this.tkbBlue.Size = new System.Drawing.Size(422, 56);
            this.tkbBlue.SmallChange = 2;
            this.tkbBlue.TabIndex = 1;
            this.tkbBlue.TickFrequency = 6;
            this.tkbBlue.Scroll += new System.EventHandler(this.tkbRed_Scroll);
            // 
            // tkbGreen
            // 
            this.tkbGreen.BackColor = System.Drawing.Color.LightGreen;
            this.tkbGreen.Location = new System.Drawing.Point(320, 110);
            this.tkbGreen.Maximum = 255;
            this.tkbGreen.Name = "tkbGreen";
            this.tkbGreen.Size = new System.Drawing.Size(422, 56);
            this.tkbGreen.SmallChange = 2;
            this.tkbGreen.TabIndex = 2;
            this.tkbGreen.TickFrequency = 6;
            this.tkbGreen.Scroll += new System.EventHandler(this.tkbRed_Scroll);
            // 
            // piccolor
            // 
            this.piccolor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.piccolor.Location = new System.Drawing.Point(36, 68);
            this.piccolor.Name = "piccolor";
            this.piccolor.Size = new System.Drawing.Size(185, 176);
            this.piccolor.TabIndex = 3;
            this.piccolor.TabStop = false;
            // 
            // picShow
            // 
            this.picShow.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picShow.Location = new System.Drawing.Point(32, 282);
            this.picShow.Name = "picShow";
            this.picShow.Size = new System.Drawing.Size(710, 260);
            this.picShow.TabIndex = 4;
            this.picShow.TabStop = false;
            this.picShow.MouseDown += new System.Windows.Forms.MouseEventHandler(this.picShow_MouseDown);
            this.picShow.MouseMove += new System.Windows.Forms.MouseEventHandler(this.picShow_MouseMove);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(765, 554);
            this.Controls.Add(this.picShow);
            this.Controls.Add(this.piccolor);
            this.Controls.Add(this.tkbGreen);
            this.Controls.Add(this.tkbBlue);
            this.Controls.Add(this.tkbRed);
            this.Name = "Form1";
            this.Text = "41612164_赵旗";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tkbRed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tkbBlue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tkbGreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.piccolor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picShow)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar tkbRed;
        private System.Windows.Forms.TrackBar tkbBlue;
        private System.Windows.Forms.TrackBar tkbGreen;
        private System.Windows.Forms.PictureBox piccolor;
        private System.Windows.Forms.PictureBox picShow;
    }
}

