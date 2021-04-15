
namespace EZSetup
{
    partial class ProcessForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.processingTip = new System.Windows.Forms.Label();
            this.close = new System.Windows.Forms.Button();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.openDir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // processingTip
            // 
            this.processingTip.AutoSize = true;
            this.processingTip.Location = new System.Drawing.Point(46, 45);
            this.processingTip.Name = "processingTip";
            this.processingTip.Size = new System.Drawing.Size(67, 15);
            this.processingTip.TabIndex = 0;
            this.processingTip.Text = "构建中：";
            // 
            // close
            // 
            this.close.Enabled = false;
            this.close.Location = new System.Drawing.Point(116, 129);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(85, 31);
            this.close.TabIndex = 1;
            this.close.Text = "关闭";
            this.close.UseVisualStyleBackColor = true;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(49, 82);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(410, 23);
            this.progressBar.TabIndex = 2;
            // 
            // openDir
            // 
            this.openDir.Enabled = false;
            this.openDir.Location = new System.Drawing.Point(268, 129);
            this.openDir.Name = "openDir";
            this.openDir.Size = new System.Drawing.Size(129, 31);
            this.openDir.TabIndex = 1;
            this.openDir.Text = "打开输出文件夹";
            this.openDir.UseVisualStyleBackColor = true;
            this.openDir.Click += new System.EventHandler(this.openDir_Click);
            // 
            // ProcessForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(503, 189);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.openDir);
            this.Controls.Add(this.close);
            this.Controls.Add(this.processingTip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ProcessForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProcessForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.ProgressBar progressBar;
        public System.Windows.Forms.Label processingTip;
        public System.Windows.Forms.Button close;
        public System.Windows.Forms.Button openDir;
    }
}