
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
            this.ok = new System.Windows.Forms.Button();
            this.templateList = new System.Windows.Forms.ListBox();
            this.templateTip = new System.Windows.Forms.Label();
            this.cscVersionBox = new System.Windows.Forms.ComboBox();
            this.cscVersionTip = new System.Windows.Forms.Label();
            this.prepareTip = new System.Windows.Forms.Label();
            this.mainTabPanel.SuspendLayout();
            this.main.SuspendLayout();
            this.config.SuspendLayout();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.title.Location = new System.Drawing.Point(27, 29);
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
            this.mainTabPanel.Size = new System.Drawing.Size(520, 219);
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
            this.main.Size = new System.Drawing.Size(512, 201);
            this.main.TabIndex = 0;
            this.main.UseVisualStyleBackColor = true;
            // 
            // downSDK
            // 
            this.downSDK.AutoSize = true;
            this.downSDK.Location = new System.Drawing.Point(29, 148);
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
            this.next.Location = new System.Drawing.Point(419, 158);
            this.next.Name = "next";
            this.next.Size = new System.Drawing.Size(78, 30);
            this.next.TabIndex = 2;
            this.next.Text = "下一步";
            this.next.UseVisualStyleBackColor = true;
            this.next.Click += new System.EventHandler(this.next_Click);
            // 
            // sdkNotFoundTip
            // 
            this.sdkNotFoundTip.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.sdkNotFoundTip.ForeColor = System.Drawing.Color.Red;
            this.sdkNotFoundTip.Location = new System.Drawing.Point(29, 105);
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
            this.tip.Location = new System.Drawing.Point(28, 68);
            this.tip.Name = "tip";
            this.tip.Size = new System.Drawing.Size(142, 19);
            this.tip.TabIndex = 1;
            this.tip.Text = "点击下一步继续";
            // 
            // config
            // 
            this.config.Controls.Add(this.prepareTip);
            this.config.Controls.Add(this.ok);
            this.config.Controls.Add(this.templateList);
            this.config.Controls.Add(this.templateTip);
            this.config.Controls.Add(this.cscVersionBox);
            this.config.Controls.Add(this.cscVersionTip);
            this.config.Location = new System.Drawing.Point(4, 14);
            this.config.Name = "config";
            this.config.Padding = new System.Windows.Forms.Padding(3);
            this.config.Size = new System.Drawing.Size(512, 201);
            this.config.TabIndex = 1;
            this.config.UseVisualStyleBackColor = true;
            // 
            // ok
            // 
            this.ok.Location = new System.Drawing.Point(413, 164);
            this.ok.Name = "ok";
            this.ok.Size = new System.Drawing.Size(75, 26);
            this.ok.TabIndex = 4;
            this.ok.Text = "确定";
            this.ok.UseVisualStyleBackColor = true;
            this.ok.Click += new System.EventHandler(this.ok_Click);
            // 
            // templateList
            // 
            this.templateList.FormattingEnabled = true;
            this.templateList.ItemHeight = 15;
            this.templateList.Location = new System.Drawing.Point(33, 75);
            this.templateList.Name = "templateList";
            this.templateList.Size = new System.Drawing.Size(455, 79);
            this.templateList.TabIndex = 3;
            // 
            // templateTip
            // 
            this.templateTip.AutoSize = true;
            this.templateTip.Location = new System.Drawing.Point(30, 52);
            this.templateTip.Name = "templateTip";
            this.templateTip.Size = new System.Drawing.Size(97, 15);
            this.templateTip.TabIndex = 2;
            this.templateTip.Text = "安装包模板：";
            // 
            // cscVersionBox
            // 
            this.cscVersionBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cscVersionBox.FormattingEnabled = true;
            this.cscVersionBox.Location = new System.Drawing.Point(193, 15);
            this.cscVersionBox.Name = "cscVersionBox";
            this.cscVersionBox.Size = new System.Drawing.Size(148, 23);
            this.cscVersionBox.TabIndex = 1;
            // 
            // cscVersionTip
            // 
            this.cscVersionTip.AutoSize = true;
            this.cscVersionTip.Location = new System.Drawing.Point(30, 20);
            this.cscVersionTip.Name = "cscVersionTip";
            this.cscVersionTip.Size = new System.Drawing.Size(157, 15);
            this.cscVersionTip.TabIndex = 0;
            this.cscVersionTip.Text = "用于构建的框架版本：";
            // 
            // prepareTip
            // 
            this.prepareTip.AutoSize = true;
            this.prepareTip.ForeColor = System.Drawing.Color.Red;
            this.prepareTip.Location = new System.Drawing.Point(33, 164);
            this.prepareTip.Name = "prepareTip";
            this.prepareTip.Size = new System.Drawing.Size(76, 15);
            this.prepareTip.TabIndex = 5;
            this.prepareTip.Text = "准备中...";
            this.prepareTip.Visible = false;
            // 
            // MainGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 221);
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
    }
}

