
namespace InstallPack.ConfigModule
{
    partial class ShortcutInfo
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
			this.shortcutName = new System.Windows.Forms.Label();
			this.originFile = new System.Windows.Forms.Label();
			this.shortcutNameValue = new System.Windows.Forms.TextBox();
			this.originFileValue = new System.Windows.Forms.TextBox();
			this.selectOriginFile = new System.Windows.Forms.Button();
			this.ok = new System.Windows.Forms.Button();
			this.argsValue = new System.Windows.Forms.TextBox();
			this.argsLabel = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// shortcutName
			// 
			this.shortcutName.AutoSize = true;
			this.shortcutName.Location = new System.Drawing.Point(37, 65);
			this.shortcutName.Name = "shortcutName";
			this.shortcutName.Size = new System.Drawing.Size(97, 15);
			this.shortcutName.TabIndex = 0;
			this.shortcutName.Text = "快捷方式名：";
			// 
			// originFile
			// 
			this.originFile.AutoSize = true;
			this.originFile.Location = new System.Drawing.Point(67, 28);
			this.originFile.Name = "originFile";
			this.originFile.Size = new System.Drawing.Size(67, 15);
			this.originFile.TabIndex = 0;
			this.originFile.Text = "原文件：";
			// 
			// shortcutNameValue
			// 
			this.shortcutNameValue.Location = new System.Drawing.Point(141, 62);
			this.shortcutNameValue.Name = "shortcutNameValue";
			this.shortcutNameValue.Size = new System.Drawing.Size(185, 25);
			this.shortcutNameValue.TabIndex = 1;
			// 
			// originFileValue
			// 
			this.originFileValue.Location = new System.Drawing.Point(141, 23);
			this.originFileValue.Name = "originFileValue";
			this.originFileValue.Size = new System.Drawing.Size(185, 25);
			this.originFileValue.TabIndex = 1;
			// 
			// selectOriginFile
			// 
			this.selectOriginFile.Location = new System.Drawing.Point(341, 23);
			this.selectOriginFile.Name = "selectOriginFile";
			this.selectOriginFile.Size = new System.Drawing.Size(60, 25);
			this.selectOriginFile.TabIndex = 2;
			this.selectOriginFile.Text = "浏览";
			this.selectOriginFile.UseVisualStyleBackColor = true;
			this.selectOriginFile.Click += new System.EventHandler(this.selectOriginFile_Click);
			// 
			// ok
			// 
			this.ok.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.ok.Location = new System.Drawing.Point(173, 132);
			this.ok.Name = "ok";
			this.ok.Size = new System.Drawing.Size(62, 29);
			this.ok.TabIndex = 2;
			this.ok.Text = "ok";
			this.ok.UseVisualStyleBackColor = true;
			this.ok.Click += new System.EventHandler(this.ok_Click);
			// 
			// argsValue
			// 
			this.argsValue.Location = new System.Drawing.Point(141, 98);
			this.argsValue.Name = "argsValue";
			this.argsValue.Size = new System.Drawing.Size(185, 25);
			this.argsValue.TabIndex = 4;
			// 
			// argsLabel
			// 
			this.argsLabel.AutoSize = true;
			this.argsLabel.Location = new System.Drawing.Point(7, 103);
			this.argsLabel.Name = "argsLabel";
			this.argsLabel.Size = new System.Drawing.Size(128, 15);
			this.argsLabel.TabIndex = 3;
			this.argsLabel.Text = "运行参数(可选)：";
			// 
			// ShortcutInfo
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(417, 170);
			this.Controls.Add(this.argsValue);
			this.Controls.Add(this.originFileValue);
			this.Controls.Add(this.shortcutNameValue);
			this.Controls.Add(this.argsLabel);
			this.Controls.Add(this.ok);
			this.Controls.Add(this.selectOriginFile);
			this.Controls.Add(this.originFile);
			this.Controls.Add(this.shortcutName);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "ShortcutInfo";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "快捷方式配置";
			this.Load += new System.EventHandler(this.ShortcutInfo_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label shortcutName;
        private System.Windows.Forms.Label originFile;
        private System.Windows.Forms.TextBox shortcutNameValue;
        private System.Windows.Forms.TextBox originFileValue;
        private System.Windows.Forms.Button selectOriginFile;
        private System.Windows.Forms.Button ok;
		private System.Windows.Forms.TextBox argsValue;
		private System.Windows.Forms.Label argsLabel;
	}
}