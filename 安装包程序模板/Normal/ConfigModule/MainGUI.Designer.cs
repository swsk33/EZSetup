
namespace InstallPack.ConfigModule
{
    partial class MainGUI
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
			this.title = new System.Windows.Forms.Label();
			this.dir = new System.Windows.Forms.Label();
			this.dirValue = new System.Windows.Forms.TextBox();
			this.selectDir = new System.Windows.Forms.Button();
			this.mainExe = new System.Windows.Forms.Label();
			this.mainExeValue = new System.Windows.Forms.TextBox();
			this.selectExe = new System.Windows.Forms.Button();
			this.generateShortcut = new System.Windows.Forms.CheckBox();
			this.shortcutList = new System.Windows.Forms.ListBox();
			this.remove = new System.Windows.Forms.Button();
			this.add = new System.Windows.Forms.Button();
			this.clear = new System.Windows.Forms.Button();
			this.listDes = new System.Windows.Forms.Label();
			this.installPath = new System.Windows.Forms.Label();
			this.selectInstallPath = new System.Windows.Forms.Button();
			this.installPathValue = new System.Windows.Forms.TextBox();
			this.license = new System.Windows.Forms.Label();
			this.licenseText = new System.Windows.Forms.TextBox();
			this.loadFromFile = new System.Windows.Forms.Button();
			this.addBootOption = new System.Windows.Forms.CheckBox();
			this.openAfterSetup = new System.Windows.Forms.CheckBox();
			this.titleValue = new System.Windows.Forms.TextBox();
			this.done = new System.Windows.Forms.Button();
			this.runAfter = new System.Windows.Forms.Label();
			this.runafterValue = new System.Windows.Forms.TextBox();
			this.genUnsetup = new System.Windows.Forms.CheckBox();
			this.publishLabel = new System.Windows.Forms.Label();
			this.versionLabel = new System.Windows.Forms.Label();
			this.publisherValue = new System.Windows.Forms.TextBox();
			this.versionValue1 = new System.Windows.Forms.TextBox();
			this.runBeforeUn = new System.Windows.Forms.Label();
			this.runBeforeUnValue = new System.Windows.Forms.TextBox();
			this.versionValue2 = new System.Windows.Forms.TextBox();
			this.versionValue3 = new System.Windows.Forms.TextBox();
			this.versionValue4 = new System.Windows.Forms.TextBox();
			this.dot1 = new System.Windows.Forms.Label();
			this.dot2 = new System.Windows.Forms.Label();
			this.dot3 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// title
			// 
			this.title.AutoSize = true;
			this.title.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.title.Location = new System.Drawing.Point(16, 22);
			this.title.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.title.Name = "title";
			this.title.Size = new System.Drawing.Size(67, 15);
			this.title.TabIndex = 0;
			this.title.Text = "程序名：";
			// 
			// dir
			// 
			this.dir.AutoSize = true;
			this.dir.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.dir.Location = new System.Drawing.Point(16, 50);
			this.dir.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.dir.Name = "dir";
			this.dir.Size = new System.Drawing.Size(112, 15);
			this.dir.TabIndex = 0;
			this.dir.Text = "待打包文件夹：";
			// 
			// dirValue
			// 
			this.dirValue.Location = new System.Drawing.Point(120, 48);
			this.dirValue.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.dirValue.Name = "dirValue";
			this.dirValue.Size = new System.Drawing.Size(147, 21);
			this.dirValue.TabIndex = 1;
			// 
			// selectDir
			// 
			this.selectDir.Location = new System.Drawing.Point(275, 48);
			this.selectDir.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.selectDir.Name = "selectDir";
			this.selectDir.Size = new System.Drawing.Size(62, 22);
			this.selectDir.TabIndex = 1;
			this.selectDir.Text = "浏览";
			this.selectDir.UseVisualStyleBackColor = true;
			this.selectDir.Click += new System.EventHandler(this.selectDir_Click);
			// 
			// mainExe
			// 
			this.mainExe.AutoSize = true;
			this.mainExe.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.mainExe.Location = new System.Drawing.Point(16, 77);
			this.mainExe.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.mainExe.Name = "mainExe";
			this.mainExe.Size = new System.Drawing.Size(97, 15);
			this.mainExe.TabIndex = 0;
			this.mainExe.Text = "主程序文件：";
			// 
			// mainExeValue
			// 
			this.mainExeValue.Location = new System.Drawing.Point(120, 76);
			this.mainExeValue.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.mainExeValue.Name = "mainExeValue";
			this.mainExeValue.Size = new System.Drawing.Size(147, 21);
			this.mainExeValue.TabIndex = 2;
			// 
			// selectExe
			// 
			this.selectExe.Location = new System.Drawing.Point(275, 75);
			this.selectExe.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.selectExe.Name = "selectExe";
			this.selectExe.Size = new System.Drawing.Size(62, 22);
			this.selectExe.TabIndex = 2;
			this.selectExe.Text = "浏览";
			this.selectExe.UseVisualStyleBackColor = true;
			this.selectExe.Click += new System.EventHandler(this.selectExe_Click);
			// 
			// generateShortcut
			// 
			this.generateShortcut.AutoSize = true;
			this.generateShortcut.Checked = true;
			this.generateShortcut.CheckState = System.Windows.Forms.CheckState.Checked;
			this.generateShortcut.Font = new System.Drawing.Font("宋体", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.generateShortcut.Location = new System.Drawing.Point(20, 155);
			this.generateShortcut.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.generateShortcut.Name = "generateShortcut";
			this.generateShortcut.Size = new System.Drawing.Size(110, 18);
			this.generateShortcut.TabIndex = 5;
			this.generateShortcut.Text = "生成快捷方式";
			this.generateShortcut.UseVisualStyleBackColor = true;
			this.generateShortcut.CheckedChanged += new System.EventHandler(this.generateShortcut_CheckedChanged);
			// 
			// shortcutList
			// 
			this.shortcutList.FormattingEnabled = true;
			this.shortcutList.ItemHeight = 12;
			this.shortcutList.Location = new System.Drawing.Point(20, 193);
			this.shortcutList.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.shortcutList.Name = "shortcutList";
			this.shortcutList.Size = new System.Drawing.Size(311, 52);
			this.shortcutList.TabIndex = 4;
			this.shortcutList.TabStop = false;
			// 
			// remove
			// 
			this.remove.Location = new System.Drawing.Point(292, 167);
			this.remove.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.remove.Name = "remove";
			this.remove.Size = new System.Drawing.Size(38, 22);
			this.remove.TabIndex = 6;
			this.remove.TabStop = false;
			this.remove.Text = "删除";
			this.remove.UseVisualStyleBackColor = true;
			this.remove.Click += new System.EventHandler(this.remove_Click);
			// 
			// add
			// 
			this.add.Location = new System.Drawing.Point(249, 167);
			this.add.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.add.Name = "add";
			this.add.Size = new System.Drawing.Size(38, 22);
			this.add.TabIndex = 5;
			this.add.Text = "增加";
			this.add.UseVisualStyleBackColor = true;
			this.add.Click += new System.EventHandler(this.add_Click);
			// 
			// clear
			// 
			this.clear.Location = new System.Drawing.Point(206, 167);
			this.clear.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.clear.Name = "clear";
			this.clear.Size = new System.Drawing.Size(38, 22);
			this.clear.TabIndex = 6;
			this.clear.TabStop = false;
			this.clear.Text = "清空";
			this.clear.UseVisualStyleBackColor = true;
			this.clear.Click += new System.EventHandler(this.clear_Click);
			// 
			// listDes
			// 
			this.listDes.AutoSize = true;
			this.listDes.Location = new System.Drawing.Point(18, 177);
			this.listDes.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.listDes.Name = "listDes";
			this.listDes.Size = new System.Drawing.Size(161, 12);
			this.listDes.TabIndex = 5;
			this.listDes.Text = "要生成快捷方式的文件列表：";
			// 
			// installPath
			// 
			this.installPath.AutoSize = true;
			this.installPath.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.installPath.Location = new System.Drawing.Point(16, 254);
			this.installPath.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.installPath.Name = "installPath";
			this.installPath.Size = new System.Drawing.Size(112, 15);
			this.installPath.TabIndex = 0;
			this.installPath.Text = "默认安装路径：";
			// 
			// selectInstallPath
			// 
			this.selectInstallPath.Location = new System.Drawing.Point(268, 250);
			this.selectInstallPath.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.selectInstallPath.Name = "selectInstallPath";
			this.selectInstallPath.Size = new System.Drawing.Size(62, 22);
			this.selectInstallPath.TabIndex = 6;
			this.selectInstallPath.Text = "浏览";
			this.selectInstallPath.UseVisualStyleBackColor = true;
			this.selectInstallPath.Click += new System.EventHandler(this.selectInstallPath_Click);
			// 
			// installPathValue
			// 
			this.installPathValue.Location = new System.Drawing.Point(120, 250);
			this.installPathValue.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.installPathValue.Name = "installPathValue";
			this.installPathValue.Size = new System.Drawing.Size(140, 21);
			this.installPathValue.TabIndex = 6;
			// 
			// license
			// 
			this.license.AutoSize = true;
			this.license.Font = new System.Drawing.Font("宋体", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.license.Location = new System.Drawing.Point(17, 279);
			this.license.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.license.Name = "license";
			this.license.Size = new System.Drawing.Size(77, 14);
			this.license.TabIndex = 0;
			this.license.Text = "协议内容：";
			// 
			// licenseText
			// 
			this.licenseText.Location = new System.Drawing.Point(20, 300);
			this.licenseText.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.licenseText.Multiline = true;
			this.licenseText.Name = "licenseText";
			this.licenseText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.licenseText.Size = new System.Drawing.Size(311, 53);
			this.licenseText.TabIndex = 7;
			// 
			// loadFromFile
			// 
			this.loadFromFile.Font = new System.Drawing.Font("宋体", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.loadFromFile.Location = new System.Drawing.Point(291, 278);
			this.loadFromFile.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.loadFromFile.Name = "loadFromFile";
			this.loadFromFile.Size = new System.Drawing.Size(39, 18);
			this.loadFromFile.TabIndex = 7;
			this.loadFromFile.Text = "导入";
			this.loadFromFile.UseVisualStyleBackColor = true;
			this.loadFromFile.Click += new System.EventHandler(this.loadFromFile_Click);
			// 
			// addBootOption
			// 
			this.addBootOption.AutoSize = true;
			this.addBootOption.Font = new System.Drawing.Font("宋体", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.addBootOption.Location = new System.Drawing.Point(202, 426);
			this.addBootOption.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.addBootOption.Name = "addBootOption";
			this.addBootOption.Size = new System.Drawing.Size(138, 18);
			this.addBootOption.TabIndex = 12;
			this.addBootOption.Text = "显示添加开机启动";
			this.addBootOption.UseVisualStyleBackColor = true;
			// 
			// openAfterSetup
			// 
			this.openAfterSetup.AutoSize = true;
			this.openAfterSetup.Font = new System.Drawing.Font("宋体", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.openAfterSetup.Location = new System.Drawing.Point(20, 426);
			this.openAfterSetup.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.openAfterSetup.Name = "openAfterSetup";
			this.openAfterSetup.Size = new System.Drawing.Size(180, 18);
			this.openAfterSetup.TabIndex = 10;
			this.openAfterSetup.Text = "显示安装完成后打开程序";
			this.openAfterSetup.UseVisualStyleBackColor = true;
			// 
			// titleValue
			// 
			this.titleValue.Location = new System.Drawing.Point(76, 20);
			this.titleValue.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.titleValue.Name = "titleValue";
			this.titleValue.Size = new System.Drawing.Size(191, 21);
			this.titleValue.TabIndex = 0;
			this.titleValue.TextChanged += new System.EventHandler(this.titleValue_TextChanged);
			// 
			// done
			// 
			this.done.Location = new System.Drawing.Point(272, 459);
			this.done.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.done.Name = "done";
			this.done.Size = new System.Drawing.Size(62, 26);
			this.done.TabIndex = 13;
			this.done.Text = "完成";
			this.done.UseVisualStyleBackColor = true;
			this.done.Click += new System.EventHandler(this.done_Click);
			// 
			// runAfter
			// 
			this.runAfter.AutoSize = true;
			this.runAfter.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.runAfter.Location = new System.Drawing.Point(16, 364);
			this.runAfter.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.runAfter.Name = "runAfter";
			this.runAfter.Size = new System.Drawing.Size(180, 15);
			this.runAfter.TabIndex = 0;
			this.runAfter.Text = "安装完成运行命令/程序：";
			// 
			// runafterValue
			// 
			this.runafterValue.Location = new System.Drawing.Point(187, 362);
			this.runafterValue.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.runafterValue.Name = "runafterValue";
			this.runafterValue.Size = new System.Drawing.Size(144, 21);
			this.runafterValue.TabIndex = 8;
			// 
			// genUnsetup
			// 
			this.genUnsetup.AutoSize = true;
			this.genUnsetup.Font = new System.Drawing.Font("宋体", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.genUnsetup.Location = new System.Drawing.Point(20, 447);
			this.genUnsetup.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.genUnsetup.Name = "genUnsetup";
			this.genUnsetup.Size = new System.Drawing.Size(138, 18);
			this.genUnsetup.TabIndex = 11;
			this.genUnsetup.Text = "生成一个卸载程序";
			this.genUnsetup.UseVisualStyleBackColor = true;
			this.genUnsetup.CheckedChanged += new System.EventHandler(this.genUnsetup_CheckedChanged);
			// 
			// publishLabel
			// 
			this.publishLabel.AutoSize = true;
			this.publishLabel.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.publishLabel.Location = new System.Drawing.Point(16, 107);
			this.publishLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.publishLabel.Name = "publishLabel";
			this.publishLabel.Size = new System.Drawing.Size(67, 15);
			this.publishLabel.TabIndex = 0;
			this.publishLabel.Text = "发布者：";
			// 
			// versionLabel
			// 
			this.versionLabel.AutoSize = true;
			this.versionLabel.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.versionLabel.Location = new System.Drawing.Point(17, 132);
			this.versionLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.versionLabel.Name = "versionLabel";
			this.versionLabel.Size = new System.Drawing.Size(67, 15);
			this.versionLabel.TabIndex = 0;
			this.versionLabel.Text = "版本号：";
			// 
			// publisherValue
			// 
			this.publisherValue.Location = new System.Drawing.Point(83, 104);
			this.publisherValue.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.publisherValue.Name = "publisherValue";
			this.publisherValue.Size = new System.Drawing.Size(184, 21);
			this.publisherValue.TabIndex = 3;
			// 
			// versionValue1
			// 
			this.versionValue1.Location = new System.Drawing.Point(83, 129);
			this.versionValue1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.versionValue1.Name = "versionValue1";
			this.versionValue1.Size = new System.Drawing.Size(30, 21);
			this.versionValue1.TabIndex = 4;
			// 
			// runBeforeUn
			// 
			this.runBeforeUn.AutoSize = true;
			this.runBeforeUn.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.runBeforeUn.Location = new System.Drawing.Point(16, 394);
			this.runBeforeUn.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.runBeforeUn.Name = "runBeforeUn";
			this.runBeforeUn.Size = new System.Drawing.Size(180, 15);
			this.runBeforeUn.TabIndex = 0;
			this.runBeforeUn.Text = "卸载之前运行命令/程序：";
			// 
			// runBeforeUnValue
			// 
			this.runBeforeUnValue.Enabled = false;
			this.runBeforeUnValue.Location = new System.Drawing.Point(187, 392);
			this.runBeforeUnValue.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.runBeforeUnValue.Name = "runBeforeUnValue";
			this.runBeforeUnValue.Size = new System.Drawing.Size(144, 21);
			this.runBeforeUnValue.TabIndex = 9;
			// 
			// versionValue2
			// 
			this.versionValue2.Location = new System.Drawing.Point(124, 129);
			this.versionValue2.Margin = new System.Windows.Forms.Padding(2);
			this.versionValue2.Name = "versionValue2";
			this.versionValue2.Size = new System.Drawing.Size(32, 21);
			this.versionValue2.TabIndex = 4;
			// 
			// versionValue3
			// 
			this.versionValue3.Location = new System.Drawing.Point(167, 129);
			this.versionValue3.Margin = new System.Windows.Forms.Padding(2);
			this.versionValue3.Name = "versionValue3";
			this.versionValue3.Size = new System.Drawing.Size(32, 21);
			this.versionValue3.TabIndex = 4;
			// 
			// versionValue4
			// 
			this.versionValue4.Location = new System.Drawing.Point(210, 129);
			this.versionValue4.Margin = new System.Windows.Forms.Padding(2);
			this.versionValue4.Name = "versionValue4";
			this.versionValue4.Size = new System.Drawing.Size(33, 21);
			this.versionValue4.TabIndex = 4;
			// 
			// dot1
			// 
			this.dot1.AutoSize = true;
			this.dot1.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.dot1.Location = new System.Drawing.Point(113, 136);
			this.dot1.Name = "dot1";
			this.dot1.Size = new System.Drawing.Size(14, 14);
			this.dot1.TabIndex = 14;
			this.dot1.Text = ".";
			// 
			// dot2
			// 
			this.dot2.AutoSize = true;
			this.dot2.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.dot2.Location = new System.Drawing.Point(156, 136);
			this.dot2.Name = "dot2";
			this.dot2.Size = new System.Drawing.Size(14, 14);
			this.dot2.TabIndex = 14;
			this.dot2.Text = ".";
			// 
			// dot3
			// 
			this.dot3.AutoSize = true;
			this.dot3.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.dot3.Location = new System.Drawing.Point(199, 136);
			this.dot3.Name = "dot3";
			this.dot3.Size = new System.Drawing.Size(14, 14);
			this.dot3.TabIndex = 15;
			this.dot3.Text = ".";
			// 
			// MainGUI
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(349, 494);
			this.Controls.Add(this.versionValue2);
			this.Controls.Add(this.versionValue4);
			this.Controls.Add(this.versionValue3);
			this.Controls.Add(this.versionValue1);
			this.Controls.Add(this.dot3);
			this.Controls.Add(this.dot2);
			this.Controls.Add(this.dot1);
			this.Controls.Add(this.runBeforeUnValue);
			this.Controls.Add(this.runafterValue);
			this.Controls.Add(this.publisherValue);
			this.Controls.Add(this.done);
			this.Controls.Add(this.licenseText);
			this.Controls.Add(this.installPathValue);
			this.Controls.Add(this.listDes);
			this.Controls.Add(this.shortcutList);
			this.Controls.Add(this.genUnsetup);
			this.Controls.Add(this.openAfterSetup);
			this.Controls.Add(this.addBootOption);
			this.Controls.Add(this.generateShortcut);
			this.Controls.Add(this.mainExeValue);
			this.Controls.Add(this.dirValue);
			this.Controls.Add(this.clear);
			this.Controls.Add(this.add);
			this.Controls.Add(this.remove);
			this.Controls.Add(this.loadFromFile);
			this.Controls.Add(this.selectInstallPath);
			this.Controls.Add(this.selectExe);
			this.Controls.Add(this.selectDir);
			this.Controls.Add(this.runBeforeUn);
			this.Controls.Add(this.runAfter);
			this.Controls.Add(this.license);
			this.Controls.Add(this.installPath);
			this.Controls.Add(this.versionLabel);
			this.Controls.Add(this.titleValue);
			this.Controls.Add(this.publishLabel);
			this.Controls.Add(this.mainExe);
			this.Controls.Add(this.dir);
			this.Controls.Add(this.title);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "MainGUI";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "普通安装包-配置模块";
			this.Load += new System.EventHandler(this.MainGUI_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Label dir;
        private System.Windows.Forms.TextBox dirValue;
        private System.Windows.Forms.Button selectDir;
        private System.Windows.Forms.Label mainExe;
        private System.Windows.Forms.TextBox mainExeValue;
        private System.Windows.Forms.Button selectExe;
        private System.Windows.Forms.CheckBox generateShortcut;
        private System.Windows.Forms.Button remove;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.Label listDes;
        private System.Windows.Forms.Label installPath;
        private System.Windows.Forms.Button selectInstallPath;
        private System.Windows.Forms.TextBox installPathValue;
        private System.Windows.Forms.Label license;
        private System.Windows.Forms.TextBox licenseText;
        private System.Windows.Forms.Button loadFromFile;
        private System.Windows.Forms.CheckBox addBootOption;
        private System.Windows.Forms.CheckBox openAfterSetup;
        private System.Windows.Forms.TextBox titleValue;
        private System.Windows.Forms.Button done;
        private System.Windows.Forms.Label runAfter;
        private System.Windows.Forms.TextBox runafterValue;
        public System.Windows.Forms.ListBox shortcutList;
        private System.Windows.Forms.CheckBox genUnsetup;
		private System.Windows.Forms.Label publishLabel;
		private System.Windows.Forms.Label versionLabel;
		private System.Windows.Forms.TextBox publisherValue;
		private System.Windows.Forms.TextBox versionValue1;
		private System.Windows.Forms.Label runBeforeUn;
		private System.Windows.Forms.TextBox runBeforeUnValue;
		private System.Windows.Forms.TextBox versionValue2;
		private System.Windows.Forms.TextBox versionValue3;
		private System.Windows.Forms.TextBox versionValue4;
		private System.Windows.Forms.Label dot1;
		private System.Windows.Forms.Label dot2;
		private System.Windows.Forms.Label dot3;
	}
}