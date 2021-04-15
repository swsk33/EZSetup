
namespace EZSetup
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
            this.title = new System.Windows.Forms.Label();
            this.mainTabPanel = new System.Windows.Forms.TabControl();
            this.main = new System.Windows.Forms.TabPage();
            this.downSDK = new System.Windows.Forms.LinkLabel();
            this.next = new System.Windows.Forms.Button();
            this.sdkNotFoundTip = new System.Windows.Forms.Label();
            this.tip = new System.Windows.Forms.Label();
            this.config = new System.Windows.Forms.TabPage();
            this.prepareTip = new System.Windows.Forms.Label();
            this.ok = new System.Windows.Forms.Button();
            this.templateList = new System.Windows.Forms.ListBox();
            this.templateTip = new System.Windows.Forms.Label();
            this.compressLevelValue = new System.Windows.Forms.ComboBox();
            this.compressLevelTip = new System.Windows.Forms.Label();
            this.cscVersionBox = new System.Windows.Forms.ComboBox();
            this.cscVersionTip = new System.Windows.Forms.Label();
            this.outputPath = new System.Windows.Forms.Label();
            this.outputPathValue = new System.Windows.Forms.TextBox();
            this.selectPath = new System.Windows.Forms.Button();
            this.setIcon = new System.Windows.Forms.CheckBox();
            this.iconPath = new System.Windows.Forms.TextBox();
            this.selectIcon = new System.Windows.Forms.Button();
            this.mainTabPanel.SuspendLayout();
            this.main.SuspendLayout();
            this.config.SuspendLayout();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.title.Location = new System.Drawing.Point(27, 43);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(292, 25);
            this.title.TabIndex = 0;
            this.title.Text = "EZSetup安装包制作程序";
            // 
            // mainTabPanel
            // 
            this.mainTabPanel.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.mainTabPanel.Controls.Add(this.main);
            this.mainTabPanel.Controls.Add(this.config);
            this.mainTabPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.mainTabPanel.ItemSize = new System.Drawing.Size(10, 10);
            this.mainTabPanel.Location = new System.Drawing.Point(0, 0);
            this.mainTabPanel.Name = "mainTabPanel";
            this.mainTabPanel.SelectedIndex = 0;
            this.mainTabPanel.Size = new System.Drawing.Size(612, 410);
            this.mainTabPanel.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.mainTabPanel.TabIndex = 1;
            // 
            // main
            // 
            this.main.Controls.Add(this.downSDK);
            this.main.Controls.Add(this.next);
            this.main.Controls.Add(this.sdkNotFoundTip);
            this.main.Controls.Add(this.tip);
            this.main.Controls.Add(this.title);
            this.main.Location = new System.Drawing.Point(4, 14);
            this.main.Name = "main";
            this.main.Padding = new System.Windows.Forms.Padding(3);
            this.main.Size = new System.Drawing.Size(604, 392);
            this.main.TabIndex = 0;
            this.main.UseVisualStyleBackColor = true;
            // 
            // downSDK
            // 
            this.downSDK.AutoSize = true;
            this.downSDK.Location = new System.Drawing.Point(29, 234);
            this.downSDK.Name = "downSDK";
            this.downSDK.Size = new System.Drawing.Size(67, 15);
            this.downSDK.TabIndex = 3;
            this.downSDK.TabStop = true;
            this.downSDK.Text = "前往下载";
            this.downSDK.Visible = false;
            this.downSDK.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.downSDK_LinkClicked);
            // 
            // next
            // 
            this.next.Location = new System.Drawing.Point(494, 329);
            this.next.Name = "next";
            this.next.Size = new System.Drawing.Size(87, 39);
            this.next.TabIndex = 2;
            this.next.Text = "下一步";
            this.next.UseVisualStyleBackColor = true;
            this.next.Click += new System.EventHandler(this.next_Click);
            // 
            // sdkNotFoundTip
            // 
            this.sdkNotFoundTip.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.sdkNotFoundTip.ForeColor = System.Drawing.Color.Red;
            this.sdkNotFoundTip.Location = new System.Drawing.Point(29, 191);
            this.sdkNotFoundTip.Name = "sdkNotFoundTip";
            this.sdkNotFoundTip.Size = new System.Drawing.Size(443, 34);
            this.sdkNotFoundTip.TabIndex = 1;
            this.sdkNotFoundTip.Text = "找不到可用的.NET Framework构建环境，请安装.NET Framework SDK，然后关闭并重新打开此软件\r\n";
            this.sdkNotFoundTip.Visible = false;
            // 
            // tip
            // 
            this.tip.AutoSize = true;
            this.tip.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tip.Location = new System.Drawing.Point(28, 102);
            this.tip.Name = "tip";
            this.tip.Size = new System.Drawing.Size(142, 19);
            this.tip.TabIndex = 1;
            this.tip.Text = "点击下一步继续";
            // 
            // config
            // 
            this.config.Controls.Add(this.iconPath);
            this.config.Controls.Add(this.selectIcon);
            this.config.Controls.Add(this.setIcon);
            this.config.Controls.Add(this.selectPath);
            this.config.Controls.Add(this.outputPathValue);
            this.config.Controls.Add(this.outputPath);
            this.config.Controls.Add(this.compressLevelValue);
            this.config.Controls.Add(this.cscVersionBox);
            this.config.Controls.Add(this.prepareTip);
            this.config.Controls.Add(this.ok);
            this.config.Controls.Add(this.templateList);
            this.config.Controls.Add(this.templateTip);
            this.config.Controls.Add(this.compressLevelTip);
            this.config.Controls.Add(this.cscVersionTip);
            this.config.Location = new System.Drawing.Point(4, 14);
            this.config.Name = "config";
            this.config.Padding = new System.Windows.Forms.Padding(3);
            this.config.Size = new System.Drawing.Size(604, 392);
            this.config.TabIndex = 1;
            this.config.UseVisualStyleBackColor = true;
            // 
            // prepareTip
            // 
            this.prepareTip.AutoSize = true;
            this.prepareTip.ForeColor = System.Drawing.Color.Red;
            this.prepareTip.Location = new System.Drawing.Point(32, 323);
            this.prepareTip.Name = "prepareTip";
            this.prepareTip.Size = new System.Drawing.Size(76, 15);
            this.prepareTip.TabIndex = 5;
            this.prepareTip.Text = "准备中...";
            this.prepareTip.Visible = false;
            // 
            // ok
            // 
            this.ok.Location = new System.Drawing.Point(495, 332);
            this.ok.Name = "ok";
            this.ok.Size = new System.Drawing.Size(82, 37);
            this.ok.TabIndex = 4;
            this.ok.Text = "确定";
            this.ok.UseVisualStyleBackColor = true;
            this.ok.Click += new System.EventHandler(this.ok_Click);
            // 
            // templateList
            // 
            this.templateList.FormattingEnabled = true;
            this.templateList.ItemHeight = 15;
            this.templateList.Location = new System.Drawing.Point(24, 207);
            this.templateList.Name = "templateList";
            this.templateList.Size = new System.Drawing.Size(553, 94);
            this.templateList.TabIndex = 3;
            // 
            // templateTip
            // 
            this.templateTip.AutoSize = true;
            this.templateTip.Location = new System.Drawing.Point(21, 177);
            this.templateTip.Name = "templateTip";
            this.templateTip.Size = new System.Drawing.Size(97, 15);
            this.templateTip.TabIndex = 2;
            this.templateTip.Text = "安装包模板：";
            // 
            // compressLevelValue
            // 
            this.compressLevelValue.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.compressLevelValue.FormattingEnabled = true;
            this.compressLevelValue.Items.AddRange(new object[] {
            "仅储存",
            "低",
            "普通",
            "高",
            "极限"});
            this.compressLevelValue.Location = new System.Drawing.Point(159, 57);
            this.compressLevelValue.Name = "compressLevelValue";
            this.compressLevelValue.Size = new System.Drawing.Size(93, 23);
            this.compressLevelValue.TabIndex = 1;
            // 
            // compressLevelTip
            // 
            this.compressLevelTip.AutoSize = true;
            this.compressLevelTip.Location = new System.Drawing.Point(62, 60);
            this.compressLevelTip.Name = "compressLevelTip";
            this.compressLevelTip.Size = new System.Drawing.Size(82, 15);
            this.compressLevelTip.TabIndex = 0;
            this.compressLevelTip.Text = "压缩等级：";
            // 
            // cscVersionBox
            // 
            this.cscVersionBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cscVersionBox.FormattingEnabled = true;
            this.cscVersionBox.Location = new System.Drawing.Point(159, 17);
            this.cscVersionBox.Name = "cscVersionBox";
            this.cscVersionBox.Size = new System.Drawing.Size(148, 23);
            this.cscVersionBox.TabIndex = 1;
            // 
            // cscVersionTip
            // 
            this.cscVersionTip.AutoSize = true;
            this.cscVersionTip.Location = new System.Drawing.Point(32, 25);
            this.cscVersionTip.Name = "cscVersionTip";
            this.cscVersionTip.Size = new System.Drawing.Size(112, 15);
            this.cscVersionTip.TabIndex = 0;
            this.cscVersionTip.Text = "构建框架版本：";
            // 
            // outputPath
            // 
            this.outputPath.AutoSize = true;
            this.outputPath.Location = new System.Drawing.Point(32, 101);
            this.outputPath.Name = "outputPath";
            this.outputPath.Size = new System.Drawing.Size(127, 15);
            this.outputPath.TabIndex = 6;
            this.outputPath.Text = "生成安装包路径：";
            // 
            // outputPathValue
            // 
            this.outputPathValue.Location = new System.Drawing.Point(159, 97);
            this.outputPathValue.Name = "outputPathValue";
            this.outputPathValue.ReadOnly = true;
            this.outputPathValue.Size = new System.Drawing.Size(316, 25);
            this.outputPathValue.TabIndex = 7;
            // 
            // selectPath
            // 
            this.selectPath.Location = new System.Drawing.Point(495, 95);
            this.selectPath.Name = "selectPath";
            this.selectPath.Size = new System.Drawing.Size(82, 29);
            this.selectPath.TabIndex = 8;
            this.selectPath.Text = "浏览";
            this.selectPath.UseVisualStyleBackColor = true;
            this.selectPath.Click += new System.EventHandler(this.selectPath_Click);
            // 
            // setIcon
            // 
            this.setIcon.AutoSize = true;
            this.setIcon.Location = new System.Drawing.Point(40, 140);
            this.setIcon.Name = "setIcon";
            this.setIcon.Size = new System.Drawing.Size(119, 19);
            this.setIcon.TabIndex = 9;
            this.setIcon.Text = "自定义图标：";
            this.setIcon.UseVisualStyleBackColor = true;
            this.setIcon.CheckedChanged += new System.EventHandler(this.setIcon_CheckedChanged);
            // 
            // iconPath
            // 
            this.iconPath.Enabled = false;
            this.iconPath.Location = new System.Drawing.Point(159, 136);
            this.iconPath.Name = "iconPath";
            this.iconPath.ReadOnly = true;
            this.iconPath.Size = new System.Drawing.Size(102, 25);
            this.iconPath.TabIndex = 7;
            // 
            // selectIcon
            // 
            this.selectIcon.Enabled = false;
            this.selectIcon.Location = new System.Drawing.Point(267, 135);
            this.selectIcon.Name = "selectIcon";
            this.selectIcon.Size = new System.Drawing.Size(82, 27);
            this.selectIcon.TabIndex = 8;
            this.selectIcon.Text = "浏览";
            this.selectIcon.UseVisualStyleBackColor = true;
            this.selectIcon.Click += new System.EventHandler(this.selectIcon_Click);
            // 
            // MainGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 409);
            this.Controls.Add(this.mainTabPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainGUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EZSetup安装包制作";
            this.Load += new System.EventHandler(this.MainGUI_Load);
            this.mainTabPanel.ResumeLayout(false);
            this.main.ResumeLayout(false);
            this.main.PerformLayout();
            this.config.ResumeLayout(false);
            this.config.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label title;
        private System.Windows.Forms.TabControl mainTabPanel;
        private System.Windows.Forms.TabPage main;
        private System.Windows.Forms.TabPage config;
        private System.Windows.Forms.Button next;
        private System.Windows.Forms.Label tip;
        private System.Windows.Forms.Label sdkNotFoundTip;
        private System.Windows.Forms.LinkLabel downSDK;
        private System.Windows.Forms.ComboBox cscVersionBox;
        private System.Windows.Forms.Label cscVersionTip;
        private System.Windows.Forms.Button ok;
        private System.Windows.Forms.ListBox templateList;
        private System.Windows.Forms.Label templateTip;
        private System.Windows.Forms.Label prepareTip;
        private System.Windows.Forms.ComboBox compressLevelValue;
        private System.Windows.Forms.Label compressLevelTip;
        private System.Windows.Forms.TextBox outputPathValue;
        private System.Windows.Forms.Label outputPath;
        private System.Windows.Forms.Button selectPath;
        private System.Windows.Forms.TextBox iconPath;
        private System.Windows.Forms.CheckBox setIcon;
        private System.Windows.Forms.Button selectIcon;
    }
}

