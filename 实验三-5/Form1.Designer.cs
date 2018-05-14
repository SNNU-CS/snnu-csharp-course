namespace 实验三_5
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pic1 = new System.Windows.Forms.PictureBox();
            this.pic2 = new System.Windows.Forms.PictureBox();
            this.pic3 = new System.Windows.Forms.PictureBox();
            this.pic4 = new System.Windows.Forms.PictureBox();
            this.picRunner = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pic1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRunner)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pic1
            // 
            this.pic1.Image = ((System.Drawing.Image)(resources.GetObject("pic1.Image")));
            this.pic1.InitialImage = null;
            this.pic1.Location = new System.Drawing.Point(23, 43);
            this.pic1.Name = "pic1";
            this.pic1.Size = new System.Drawing.Size(72, 78);
            this.pic1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pic1.TabIndex = 0;
            this.pic1.TabStop = false;
            // 
            // pic2
            // 
            this.pic2.Image = global::实验三_5.Properties.Resources.RUNNER2;
            this.pic2.InitialImage = null;
            this.pic2.Location = new System.Drawing.Point(140, 43);
            this.pic2.Name = "pic2";
            this.pic2.Size = new System.Drawing.Size(72, 78);
            this.pic2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pic2.TabIndex = 1;
            this.pic2.TabStop = false;
            // 
            // pic3
            // 
            this.pic3.Image = global::实验三_5.Properties.Resources.RUNNER3;
            this.pic3.InitialImage = null;
            this.pic3.Location = new System.Drawing.Point(257, 43);
            this.pic3.Name = "pic3";
            this.pic3.Size = new System.Drawing.Size(72, 78);
            this.pic3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pic3.TabIndex = 2;
            this.pic3.TabStop = false;
            // 
            // pic4
            // 
            this.pic4.Image = global::实验三_5.Properties.Resources.RUNNER4;
            this.pic4.InitialImage = null;
            this.pic4.Location = new System.Drawing.Point(374, 43);
            this.pic4.Name = "pic4";
            this.pic4.Size = new System.Drawing.Size(72, 78);
            this.pic4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pic4.TabIndex = 3;
            this.pic4.TabStop = false;
            // 
            // picRunner
            // 
            this.picRunner.BackColor = System.Drawing.Color.Transparent;
            this.picRunner.Location = new System.Drawing.Point(373, 142);
            this.picRunner.Name = "picRunner";
            this.picRunner.Size = new System.Drawing.Size(72, 78);
            this.picRunner.TabIndex = 4;
            this.picRunner.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(475, 242);
            this.Controls.Add(this.picRunner);
            this.Controls.Add(this.pic4);
            this.Controls.Add(this.pic3);
            this.Controls.Add(this.pic2);
            this.Controls.Add(this.pic1);
            this.Name = "Form1";
            this.Text = "Runner";
            this.Resize += new System.EventHandler(this.Form1_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.pic1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRunner)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pic1;
        private System.Windows.Forms.PictureBox pic2;
        private System.Windows.Forms.PictureBox pic3;
        private System.Windows.Forms.PictureBox pic4;
        private System.Windows.Forms.PictureBox picRunner;
    }
}

