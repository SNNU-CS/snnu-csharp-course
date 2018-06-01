namespace 实验四_2
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
            this.lblX = new System.Windows.Forms.Label();
            this.picTankU = new System.Windows.Forms.PictureBox();
            this.picTankR = new System.Windows.Forms.PictureBox();
            this.picTankL = new System.Windows.Forms.PictureBox();
            this.picTankD = new System.Windows.Forms.PictureBox();
            this.picTank = new System.Windows.Forms.PictureBox();
            this.lblY = new System.Windows.Forms.Label();
            this.lblMsg = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picTankU)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTankR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTankL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTankD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTank)).BeginInit();
            this.SuspendLayout();
            // 
            // lblX
            // 
            this.lblX.AutoSize = true;
            this.lblX.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblX.Location = new System.Drawing.Point(30, 245);
            this.lblX.Name = "lblX";
            this.lblX.Size = new System.Drawing.Size(69, 20);
            this.lblX.TabIndex = 0;
            this.lblX.Text = "label1";
            // 
            // picTankU
            // 
            this.picTankU.Image = global::实验四_2.Properties.Resources.tankU;
            this.picTankU.Location = new System.Drawing.Point(14, 32);
            this.picTankU.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.picTankU.Name = "picTankU";
            this.picTankU.Size = new System.Drawing.Size(90, 95);
            this.picTankU.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picTankU.TabIndex = 1;
            this.picTankU.TabStop = false;
            // 
            // picTankR
            // 
            this.picTankR.Image = global::实验四_2.Properties.Resources.tankR;
            this.picTankR.Location = new System.Drawing.Point(334, 32);
            this.picTankR.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.picTankR.Name = "picTankR";
            this.picTankR.Size = new System.Drawing.Size(90, 95);
            this.picTankR.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picTankR.TabIndex = 2;
            this.picTankR.TabStop = false;
            // 
            // picTankL
            // 
            this.picTankL.Image = global::实验四_2.Properties.Resources.tankL;
            this.picTankL.Location = new System.Drawing.Point(227, 32);
            this.picTankL.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.picTankL.Name = "picTankL";
            this.picTankL.Size = new System.Drawing.Size(90, 95);
            this.picTankL.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picTankL.TabIndex = 3;
            this.picTankL.TabStop = false;
            // 
            // picTankD
            // 
            this.picTankD.Image = global::实验四_2.Properties.Resources.tankD;
            this.picTankD.Location = new System.Drawing.Point(120, 32);
            this.picTankD.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.picTankD.Name = "picTankD";
            this.picTankD.Size = new System.Drawing.Size(90, 95);
            this.picTankD.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picTankD.TabIndex = 4;
            this.picTankD.TabStop = false;
            // 
            // picTank
            // 
            this.picTank.Image = global::实验四_2.Properties.Resources.tankU;
            this.picTank.Location = new System.Drawing.Point(334, 226);
            this.picTank.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.picTank.Name = "picTank";
            this.picTank.Size = new System.Drawing.Size(90, 95);
            this.picTank.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picTank.TabIndex = 6;
            this.picTank.TabStop = false;
            // 
            // lblY
            // 
            this.lblY.AutoSize = true;
            this.lblY.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblY.Location = new System.Drawing.Point(30, 287);
            this.lblY.Name = "lblY";
            this.lblY.Size = new System.Drawing.Size(69, 20);
            this.lblY.TabIndex = 7;
            this.lblY.Text = "label2";
            // 
            // lblMsg
            // 
            this.lblMsg.AutoSize = true;
            this.lblMsg.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblMsg.Location = new System.Drawing.Point(30, 329);
            this.lblMsg.Name = "lblMsg";
            this.lblMsg.Size = new System.Drawing.Size(249, 20);
            this.lblMsg.TabIndex = 9;
            this.lblMsg.Text = "请按上下左右键控制坦克！";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 364);
            this.Controls.Add(this.lblMsg);
            this.Controls.Add(this.lblY);
            this.Controls.Add(this.picTank);
            this.Controls.Add(this.picTankD);
            this.Controls.Add(this.picTankL);
            this.Controls.Add(this.picTankR);
            this.Controls.Add(this.picTankU);
            this.Controls.Add(this.lblX);
            this.Font = new System.Drawing.Font("楷体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "41612164_赵旗";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.picTankU)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTankR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTankL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTankD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTank)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblX;
        private System.Windows.Forms.PictureBox picTankU;
        private System.Windows.Forms.PictureBox picTankR;
        private System.Windows.Forms.PictureBox picTankL;
        private System.Windows.Forms.PictureBox picTankD;
        private System.Windows.Forms.PictureBox picTank;
        private System.Windows.Forms.Label lblY;
        private System.Windows.Forms.Label lblMsg;
    }
}

