
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
            this.mainTabPanel = new System.Windows.Forms.TabControl();
            this.initPage = new System.Windows.Forms.TabPage();
            this.exit = new System.Windows.Forms.Button();
            this.title = new System.Windows.Forms.Label();
            this.initPageNext = new System.Windows.Forms.Button();
            this.description = new System.Windows.Forms.Label();
            this.licensePage = new System.Windows.Forms.TabPage();
            this.agree = new System.Windows.Forms.CheckBox();
            this.licensePageNext = new System.Windows.Forms.Button();
            this.licensePageLast = new System.Windows.Forms.Button();
            this.licenseContent = new System.Windows.Forms.TextBox();
            this.licenseTip = new System.Windows.Forms.Label();
            this.configPage = new System.Windows.Forms.TabPage();
            this.install = new System.Windows.Forms.Button();
            this.configPageLast = new System.Windows.Forms.Button();
            this.options = new System.Windows.Forms.GroupBox();
            this.addBootOption = new System.Windows.Forms.CheckBox();
            this.addDesktopIcon = new System.Windows.Forms.CheckBox();
            this.pathValue = new System.Windows.Forms.TextBox();
            this.browse = new System.Windows.Forms.Button();
            this.pathLabel = new System.Windows.Forms.Label();
            this.installPage = new System.Windows.Forms.TabPage();
            this.currentFile = new System.Windows.Forms.Label();
            this.processValue = new System.Windows.Forms.Label();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.installTip = new System.Windows.Forms.Label();
            this.processDonePage = new System.Windows.Forms.TabPage();
            this.done = new System.Windows.Forms.Button();
            this.lastOptions = new System.Windows.Forms.GroupBox();
            this.openNow = new System.Windows.Forms.CheckBox();
            this.installDoneTip = new System.Windows.Forms.Label();
            this.mainTabPanel.SuspendLayout();
            this.initPage.SuspendLayout();
            this.licensePage.SuspendLayout();
            this.configPage.SuspendLayout();
            this.options.SuspendLayout();
            this.installPage.SuspendLayout();
            this.processDonePage.SuspendLayout();
            this.lastOptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainTabPanel
            // 
            this.mainTabPanel.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.mainTabPanel.Controls.Add(this.initPage);
            this.mainTabPanel.Controls.Add(this.licensePage);
            this.mainTabPanel.Controls.Add(this.configPage);
            this.mainTabPanel.Controls.Add(this.installPage);
            this.mainTabPanel.Controls.Add(this.processDonePage);
            this.mainTabPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.mainTabPanel.ItemSize = new System.Drawing.Size(0, 1);
            this.mainTabPanel.Location = new System.Drawing.Point(0, 0);
            this.mainTabPanel.Margin = new System.Windows.Forms.Padding(4);
            this.mainTabPanel.Name = "mainTabPanel";
            this.mainTabPanel.SelectedIndex = 0;
            this.mainTabPanel.Size = new System.Drawing.Size(791, 430);
            this.mainTabPanel.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.mainTabPanel.TabIndex = 6;
            // 
            // initPage
            // 
            this.initPage.Controls.Add(this.exit);
            this.initPage.Controls.Add(this.title);
            this.initPage.Controls.Add(this.initPageNext);
            this.initPage.Controls.Add(this.description);
            this.initPage.Location = new System.Drawing.Point(4, 14);
            this.initPage.Margin = new System.Windows.Forms.Padding(4);
            this.initPage.Name = "initPage";
            this.initPage.Padding = new System.Windows.Forms.Padding(4);
            this.initPage.Size = new System.Drawing.Size(783, 412);
            this.initPage.TabIndex = 0;
            this.initPage.UseVisualStyleBackColor = true;
            // 
            // exit
            // 
            this.exit.Location = new System.Drawing.Point(511, 360);
            this.exit.Margin = new System.Windows.Forms.Padding(4);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(100, 29);
            this.exit.TabIndex = 3;
            this.exit.Text = "取消";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // title
            // 
            this.title.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.title.Location = new System.Drawing.Point(46, 46);
            this.title.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(535, 65);
            this.title.TabIndex = 0;
            this.title.Text = "欢迎使用title安装向导";
            // 
            // initPageNext
            // 
            this.initPageNext.Location = new System.Drawing.Point(636, 360);
            this.initPageNext.Margin = new System.Windows.Forms.Padding(4);
            this.initPageNext.Name = "initPageNext";
            this.initPageNext.Size = new System.Drawing.Size(100, 29);
            this.initPageNext.TabIndex = 2;
            this.initPageNext.Text = "下一步";
            this.initPageNext.UseVisualStyleBackColor = true;
            this.initPageNext.Click += new System.EventHandler(this.initPageNext_Click);
            // 
            // description
            // 
            this.description.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.description.Location = new System.Drawing.Point(48, 137);
            this.description.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.description.Name = "description";
            this.description.Size = new System.Drawing.Size(533, 49);
            this.description.TabIndex = 4;
            this.description.Text = "点击下一步按钮开始进行安装配置，点击取消按钮退出安装程序。";
            // 
            // licensePage
            // 
            this.licensePage.Controls.Add(this.agree);
            this.licensePage.Controls.Add(this.licensePageNext);
            this.licensePage.Controls.Add(this.licensePageLast);
            this.licensePage.Controls.Add(this.licenseContent);
            this.licensePage.Controls.Add(this.licenseTip);
            this.licensePage.Location = new System.Drawing.Point(4, 14);
            this.licensePage.Margin = new System.Windows.Forms.Padding(4);
            this.licensePage.Name = "licensePage";
            this.licensePage.Size = new System.Drawing.Size(783, 412);
            this.licensePage.TabIndex = 4;
            this.licensePage.UseVisualStyleBackColor = true;
            // 
            // agree
            // 
            this.agree.AutoSize = true;
            this.agree.Checked = true;
            this.agree.CheckState = System.Windows.Forms.CheckState.Checked;
            this.agree.Location = new System.Drawing.Point(31, 328);
            this.agree.Margin = new System.Windows.Forms.Padding(4);
            this.agree.Name = "agree";
            this.agree.Size = new System.Drawing.Size(179, 19);
            this.agree.TabIndex = 3;
            this.agree.Text = "我已阅读并同意该协议";
            this.agree.UseVisualStyleBackColor = true;
            this.agree.CheckedChanged += new System.EventHandler(this.agree_CheckedChanged);
            // 
            // licensePageNext
            // 
            this.licensePageNext.Location = new System.Drawing.Point(636, 360);
            this.licensePageNext.Margin = new System.Windows.Forms.Padding(4);
            this.licensePageNext.Name = "licensePageNext";
            this.licensePageNext.Size = new System.Drawing.Size(100, 29);
            this.licensePageNext.TabIndex = 0;
            this.licensePageNext.Text = "下一步";
            this.licensePageNext.UseVisualStyleBackColor = true;
            this.licensePageNext.Click += new System.EventHandler(this.licensePageNext_Click);
            // 
            // licensePageLast
            // 
            this.licensePageLast.Location = new System.Drawing.Point(511, 360);
            this.licensePageLast.Margin = new System.Windows.Forms.Padding(4);
            this.licensePageLast.Name = "licensePageLast";
            this.licensePageLast.Size = new System.Drawing.Size(100, 29);
            this.licensePageLast.TabIndex = 2;
            this.licensePageLast.Text = "上一步";
            this.licensePageLast.UseVisualStyleBackColor = true;
            this.licensePageLast.Click += new System.EventHandler(this.licensePageLast_Click);
            // 
            // licenseContent
            // 
            this.licenseContent.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.licenseContent.Location = new System.Drawing.Point(31, 59);
            this.licenseContent.Margin = new System.Windows.Forms.Padding(4);
            this.licenseContent.Multiline = true;
            this.licenseContent.Name = "licenseContent";
            this.licenseContent.ReadOnly = true;
            this.licenseContent.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.licenseContent.Size = new System.Drawing.Size(713, 244);
            this.licenseContent.TabIndex = 1;
            // 
            // licenseTip
            // 
            this.licenseTip.AutoSize = true;
            this.licenseTip.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.licenseTip.Location = new System.Drawing.Point(27, 22);
            this.licenseTip.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.licenseTip.Name = "licenseTip";
            this.licenseTip.Size = new System.Drawing.Size(296, 18);
            this.licenseTip.TabIndex = 0;
            this.licenseTip.Text = "请阅读以下协议，然后同意以继续：";
            // 
            // configPage
            // 
            this.configPage.Controls.Add(this.install);
            this.configPage.Controls.Add(this.configPageLast);
            this.configPage.Controls.Add(this.options);
            this.configPage.Controls.Add(this.pathValue);
            this.configPage.Controls.Add(this.browse);
            this.configPage.Controls.Add(this.pathLabel);
            this.configPage.Location = new System.Drawing.Point(4, 5);
            this.configPage.Margin = new System.Windows.Forms.Padding(4);
            this.configPage.Name = "configPage";
            this.configPage.Padding = new System.Windows.Forms.Padding(4);
            this.configPage.Size = new System.Drawing.Size(783, 421);
            this.configPage.TabIndex = 1;
            this.configPage.UseVisualStyleBackColor = true;
            // 
            // install
            // 
            this.install.Location = new System.Drawing.Point(636, 360);
            this.install.Margin = new System.Windows.Forms.Padding(4);
            this.install.Name = "install";
            this.install.Size = new System.Drawing.Size(100, 29);
            this.install.TabIndex = 0;
            this.install.Text = "安装";
            this.install.UseVisualStyleBackColor = true;
            this.install.Click += new System.EventHandler(this.install_Click);
            // 
            // configPageLast
            // 
            this.configPageLast.Location = new System.Drawing.Point(511, 360);
            this.configPageLast.Margin = new System.Windows.Forms.Padding(4);
            this.configPageLast.Name = "configPageLast";
            this.configPageLast.Size = new System.Drawing.Size(100, 29);
            this.configPageLast.TabIndex = 6;
            this.configPageLast.Text = "上一步";
            this.configPageLast.UseVisualStyleBackColor = true;
            this.configPageLast.Click += new System.EventHandler(this.configPageLast_Click);
            // 
            // options
            // 
            this.options.Controls.Add(this.addBootOption);
            this.options.Controls.Add(this.addDesktopIcon);
            this.options.Location = new System.Drawing.Point(35, 94);
            this.options.Margin = new System.Windows.Forms.Padding(4);
            this.options.Name = "options";
            this.options.Padding = new System.Windows.Forms.Padding(4);
            this.options.Size = new System.Drawing.Size(707, 242);
            this.options.TabIndex = 4;
            this.options.TabStop = false;
            this.options.Text = "附加选项";
            // 
            // addBootOption
            // 
            this.addBootOption.AutoSize = true;
            this.addBootOption.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.addBootOption.Location = new System.Drawing.Point(37, 86);
            this.addBootOption.Margin = new System.Windows.Forms.Padding(4);
            this.addBootOption.Name = "addBootOption";
            this.addBootOption.Size = new System.Drawing.Size(138, 22);
            this.addBootOption.TabIndex = 3;
            this.addBootOption.Text = "添加开机启动";
            this.addBootOption.UseVisualStyleBackColor = true;
            // 
            // addDesktopIcon
            // 
            this.addDesktopIcon.AutoSize = true;
            this.addDesktopIcon.Checked = true;
            this.addDesktopIcon.CheckState = System.Windows.Forms.CheckState.Checked;
            this.addDesktopIcon.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.addDesktopIcon.Location = new System.Drawing.Point(37, 46);
            this.addDesktopIcon.Margin = new System.Windows.Forms.Padding(4);
            this.addDesktopIcon.Name = "addDesktopIcon";
            this.addDesktopIcon.Size = new System.Drawing.Size(138, 22);
            this.addDesktopIcon.TabIndex = 3;
            this.addDesktopIcon.Text = "添加快捷方式";
            this.addDesktopIcon.UseVisualStyleBackColor = true;
            // 
            // pathValue
            // 
            this.pathValue.Location = new System.Drawing.Point(121, 40);
            this.pathValue.Margin = new System.Windows.Forms.Padding(4);
            this.pathValue.Multiline = true;
            this.pathValue.Name = "pathValue";
            this.pathValue.Size = new System.Drawing.Size(503, 28);
            this.pathValue.TabIndex = 1;
            this.pathValue.WordWrap = false;
            // 
            // browse
            // 
            this.browse.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.browse.Location = new System.Drawing.Point(641, 39);
            this.browse.Margin = new System.Windows.Forms.Padding(4);
            this.browse.Name = "browse";
            this.browse.Size = new System.Drawing.Size(100, 31);
            this.browse.TabIndex = 2;
            this.browse.Text = "浏览";
            this.browse.UseVisualStyleBackColor = true;
            this.browse.Click += new System.EventHandler(this.browse_Click);
            // 
            // pathLabel
            // 
            this.pathLabel.AutoSize = true;
            this.pathLabel.Font = new System.Drawing.Font("宋体", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.pathLabel.Location = new System.Drawing.Point(31, 45);
            this.pathLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.pathLabel.Name = "pathLabel";
            this.pathLabel.Size = new System.Drawing.Size(85, 19);
            this.pathLabel.TabIndex = 1;
            this.pathLabel.Text = "安装到：";
            // 
            // installPage
            // 
            this.installPage.Controls.Add(this.currentFile);
            this.installPage.Controls.Add(this.processValue);
            this.installPage.Controls.Add(this.progressBar);
            this.installPage.Controls.Add(this.installTip);
            this.installPage.Location = new System.Drawing.Point(4, 5);
            this.installPage.Margin = new System.Windows.Forms.Padding(4);
            this.installPage.Name = "installPage";
            this.installPage.Size = new System.Drawing.Size(783, 421);
            this.installPage.TabIndex = 2;
            this.installPage.UseVisualStyleBackColor = true;
            // 
            // currentFile
            // 
            this.currentFile.AutoSize = true;
            this.currentFile.Font = new System.Drawing.Font("宋体", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.currentFile.ForeColor = System.Drawing.Color.DarkMagenta;
            this.currentFile.Location = new System.Drawing.Point(36, 151);
            this.currentFile.Name = "currentFile";
            this.currentFile.Size = new System.Drawing.Size(93, 17);
            this.currentFile.TabIndex = 5;
            this.currentFile.Text = "正在释放：";
            // 
            // processValue
            // 
            this.processValue.AutoSize = true;
            this.processValue.Font = new System.Drawing.Font("宋体", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.processValue.ForeColor = System.Drawing.Color.Blue;
            this.processValue.Location = new System.Drawing.Point(35, 116);
            this.processValue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.processValue.Name = "processValue";
            this.processValue.Size = new System.Drawing.Size(29, 19);
            this.processValue.TabIndex = 4;
            this.processValue.Text = "0%";
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(37, 66);
            this.progressBar.Margin = new System.Windows.Forms.Padding(4);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(700, 29);
            this.progressBar.TabIndex = 3;
            // 
            // installTip
            // 
            this.installTip.AutoSize = true;
            this.installTip.Font = new System.Drawing.Font("宋体", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.installTip.Location = new System.Drawing.Point(33, 30);
            this.installTip.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.installTip.Name = "installTip";
            this.installTip.Size = new System.Drawing.Size(115, 19);
            this.installTip.TabIndex = 2;
            this.installTip.Text = "正在安装...";
            // 
            // processDonePage
            // 
            this.processDonePage.Controls.Add(this.done);
            this.processDonePage.Controls.Add(this.lastOptions);
            this.processDonePage.Controls.Add(this.installDoneTip);
            this.processDonePage.Location = new System.Drawing.Point(4, 5);
            this.processDonePage.Margin = new System.Windows.Forms.Padding(4);
            this.processDonePage.Name = "processDonePage";
            this.processDonePage.Size = new System.Drawing.Size(783, 421);
            this.processDonePage.TabIndex = 3;
            this.processDonePage.UseVisualStyleBackColor = true;
            // 
            // done
            // 
            this.done.Location = new System.Drawing.Point(641, 348);
            this.done.Margin = new System.Windows.Forms.Padding(4);
            this.done.Name = "done";
            this.done.Size = new System.Drawing.Size(100, 29);
            this.done.TabIndex = 0;
            this.done.Text = "完成";
            this.done.UseVisualStyleBackColor = true;
            this.done.Click += new System.EventHandler(this.done_Click);
            // 
            // lastOptions
            // 
            this.lastOptions.Controls.Add(this.openNow);
            this.lastOptions.Location = new System.Drawing.Point(33, 88);
            this.lastOptions.Margin = new System.Windows.Forms.Padding(4);
            this.lastOptions.Name = "lastOptions";
            this.lastOptions.Padding = new System.Windows.Forms.Padding(4);
            this.lastOptions.Size = new System.Drawing.Size(708, 231);
            this.lastOptions.TabIndex = 1;
            this.lastOptions.TabStop = false;
            this.lastOptions.Text = "附加选项";
            // 
            // openNow
            // 
            this.openNow.AutoSize = true;
            this.openNow.Checked = true;
            this.openNow.CheckState = System.Windows.Forms.CheckState.Checked;
            this.openNow.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.openNow.Location = new System.Drawing.Point(42, 57);
            this.openNow.Margin = new System.Windows.Forms.Padding(4);
            this.openNow.Name = "openNow";
            this.openNow.Size = new System.Drawing.Size(138, 22);
            this.openNow.TabIndex = 4;
            this.openNow.Text = "立即打开软件";
            this.openNow.UseVisualStyleBackColor = true;
            // 
            // installDoneTip
            // 
            this.installDoneTip.AutoSize = true;
            this.installDoneTip.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.installDoneTip.Location = new System.Drawing.Point(28, 38);
            this.installDoneTip.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.installDoneTip.Name = "installDoneTip";
            this.installDoneTip.Size = new System.Drawing.Size(116, 25);
            this.installDoneTip.TabIndex = 0;
            this.installDoneTip.Text = "安装完成";
            // 
            // MainGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(791, 428);
            this.Controls.Add(this.mainTabPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainGUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "title";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainGUI_FormClosed);
            this.Load += new System.EventHandler(this.MainGUI_Load);
            this.mainTabPanel.ResumeLayout(false);
            this.initPage.ResumeLayout(false);
            this.licensePage.ResumeLayout(false);
            this.licensePage.PerformLayout();
            this.configPage.ResumeLayout(false);
            this.configPage.PerformLayout();
            this.options.ResumeLayout(false);
            this.options.PerformLayout();
            this.installPage.ResumeLayout(false);
            this.installPage.PerformLayout();
            this.processDonePage.ResumeLayout(false);
            this.processDonePage.PerformLayout();
            this.lastOptions.ResumeLayout(false);
            this.lastOptions.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl mainTabPanel;
        private System.Windows.Forms.TabPage initPage;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Button initPageNext;
        private System.Windows.Forms.Label description;
        private System.Windows.Forms.TabPage configPage;
        private System.Windows.Forms.TabPage installPage;
        private System.Windows.Forms.TabPage processDonePage;
        private System.Windows.Forms.TextBox pathValue;
        private System.Windows.Forms.Label pathLabel;
        private System.Windows.Forms.Button browse;
        private System.Windows.Forms.CheckBox addDesktopIcon;
        private System.Windows.Forms.GroupBox options;
        private System.Windows.Forms.TabPage licensePage;
        private System.Windows.Forms.Label licenseTip;
        private System.Windows.Forms.TextBox licenseContent;
        private System.Windows.Forms.CheckBox agree;
        private System.Windows.Forms.Button licensePageNext;
        private System.Windows.Forms.Button licensePageLast;
        private System.Windows.Forms.Button install;
        private System.Windows.Forms.Button configPageLast;
        private System.Windows.Forms.Label installTip;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Label processValue;
        private System.Windows.Forms.Button done;
        private System.Windows.Forms.GroupBox lastOptions;
        private System.Windows.Forms.Label installDoneTip;
        private System.Windows.Forms.CheckBox addBootOption;
        private System.Windows.Forms.CheckBox openNow;
        private System.Windows.Forms.Label currentFile;
    }
}

