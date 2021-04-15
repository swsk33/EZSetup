
namespace InstallPack
{
    partial class MainGUI
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
            this.installingGif = new System.Windows.Forms.PictureBox();
            this.installingTip = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.installingGif)).BeginInit();
            this.SuspendLayout();
            // 
            // installingGif
            // 
            this.installingGif.Location = new System.Drawing.Point(54, 49);
            this.installingGif.Name = "installingGif";
            this.installingGif.Size = new System.Drawing.Size(75, 41);
            this.installingGif.TabIndex = 0;
            this.installingGif.TabStop = false;
            // 
            // installingTip
            // 
            this.installingTip.AutoSize = true;
            this.installingTip.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.installingTip.Location = new System.Drawing.Point(150, 59);
            this.installingTip.Name = "installingTip";
            this.installingTip.Size = new System.Drawing.Size(179, 20);
            this.installingTip.TabIndex = 1;
            this.installingTip.Text = "安装中，请稍等...";
            // 
            // MainGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 140);
            this.Controls.Add(this.installingTip);
            this.Controls.Add(this.installingGif);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainGUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "title";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainGUI_FormClosed);
            this.Load += new System.EventHandler(this.MainGUI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.installingGif)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox installingGif;
        private System.Windows.Forms.Label installingTip;
    }
}

