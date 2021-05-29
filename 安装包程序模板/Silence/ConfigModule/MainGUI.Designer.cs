
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
			this.addBootOption = new System.Windows.Forms.CheckBox();
			this.openAfterSetup = new System.Windows.Forms.CheckBox();
			this.titleValue = new System.Windows.Forms.TextBox();
			this.done = new System.Windows.Forms.Button();
			this.runAfter = new System.Windows.Forms.Label();
			this.runafterValue = new System.Windows.Forms.TextBox();
			this.genUnsetup = new System.Windows.Forms.CheckBox();
			this.showInstallWindow = new System.Windows.Forms.CheckBox();
			this.runBeforeUnValue = new System.Windows.Forms.TextBox();
			this.runBeforeUn = new System.Windows.Forms.Label();
			this.publisherValue = new System.Windows.Forms.TextBox();
			this.publisherLabel = new System.Windows.Forms.Label();
			this.versionValue = new System.Windows.Forms.TextBox();
			this.versionLabel = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// title
			// 
			this.title.AutoSize = true;
			this.title.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.title.Location = new System.Drawing.Point(22, 28);
			this.title.Name = "title";
			this.title.Size = new System.Drawing.Size(85, 19);
			this.title.TabIndex = 0;
			this.title.Text = "程序名：";
			// 
			// dir
			// 
			this.dir.AutoSize = true;
			this.dir.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.dir.Location = new System.Drawing.Point(22, 70);
			this.dir.Name = "dir";
			this.dir.Size = new System.Drawing.Size(142, 19);
			this.dir.TabIndex = 0;
			this.dir.Text = "待打包文件夹：";
			// 
			// dirValue
			// 
			this.dirValue.Location = new System.Drawing.Point(160, 67);
			this.dirValue.Name = "dirValue";
			this.dirValue.Size = new System.Drawing.Size(186, 25);
			this.dirValue.TabIndex = 1;
			// 
			// selectDir
			// 
			this.selectDir.Location = new System.Drawing.Point(358, 67);
			this.selectDir.Name = "selectDir";
			this.selectDir.Size = new System.Drawing.Size(82, 27);
			this.selectDir.TabIndex = 2;
			this.selectDir.Text = "浏览";
			this.selectDir.UseVisualStyleBackColor = true;
			this.selectDir.Click += new System.EventHandler(this.selectDir_Click);
			// 
			// mainExe
			// 
			this.mainExe.AutoSize = true;
			this.mainExe.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.mainExe.Location = new System.Drawing.Point(22, 108);
			this.mainExe.Name = "mainExe";
			this.mainExe.Size = new System.Drawing.Size(123, 19);
			this.mainExe.TabIndex = 0;
			this.mainExe.Text = "主程序文件：";
			// 
			// mainExeValue
			// 
			this.mainExeValue.Location = new System.Drawing.Point(160, 106);
			this.mainExeValue.Name = "mainExeValue";
			this.mainExeValue.Size = new System.Drawing.Size(186, 25);
			this.mainExeValue.TabIndex = 2;
			// 
			// selectExe
			// 
			this.selectExe.Location = new System.Drawing.Point(358, 105);
			this.selectExe.Name = "selectExe";
			this.selectExe.Size = new System.Drawing.Size(82, 27);
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
			this.generateShortcut.Location = new System.Drawing.Point(26, 174);
			this.generateShortcut.Name = "generateShortcut";
			this.generateShortcut.Size = new System.Drawing.Size(132, 21);
			this.generateShortcut.TabIndex = 3;
			this.generateShortcut.Text = "生成快捷方式";
			this.generateShortcut.UseVisualStyleBackColor = true;
			this.generateShortcut.CheckedChanged += new System.EventHandler(this.generateShortcut_CheckedChanged);
			// 
			// shortcutList
			// 
			this.shortcutList.FormattingEnabled = true;
			this.shortcutList.ItemHeight = 15;
			this.shortcutList.Location = new System.Drawing.Point(27, 222);
			this.shortcutList.Name = "shortcutList";
			this.shortcutList.Size = new System.Drawing.Size(413, 79);
			this.shortcutList.TabIndex = 4;
			// 
			// remove
			// 
			this.remove.Location = new System.Drawing.Point(389, 189);
			this.remove.Name = "remove";
			this.remove.Size = new System.Drawing.Size(51, 27);
			this.remove.TabIndex = 2;
			this.remove.Text = "删除";
			this.remove.UseVisualStyleBackColor = true;
			this.remove.Click += new System.EventHandler(this.remove_Click);
			// 
			// add
			// 
			this.add.Location = new System.Drawing.Point(332, 189);
			this.add.Name = "add";
			this.add.Size = new System.Drawing.Size(51, 27);
			this.add.TabIndex = 2;
			this.add.Text = "增加";
			this.add.UseVisualStyleBackColor = true;
			this.add.Click += new System.EventHandler(this.add_Click);
			// 
			// clear
			// 
			this.clear.Location = new System.Drawing.Point(275, 189);
			this.clear.Name = "clear";
			this.clear.Size = new System.Drawing.Size(51, 27);
			this.clear.TabIndex = 2;
			this.clear.Text = "清空";
			this.clear.UseVisualStyleBackColor = true;
			this.clear.Click += new System.EventHandler(this.clear_Click);
			// 
			// listDes
			// 
			this.listDes.AutoSize = true;
			this.listDes.Location = new System.Drawing.Point(24, 201);
			this.listDes.Name = "listDes";
			this.listDes.Size = new System.Drawing.Size(202, 15);
			this.listDes.TabIndex = 5;
			this.listDes.Text = "要生成快捷方式的文件列表：";
			// 
			// installPath
			// 
			this.installPath.AutoSize = true;
			this.installPath.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.installPath.Location = new System.Drawing.Point(22, 311);
			this.installPath.Name = "installPath";
			this.installPath.Size = new System.Drawing.Size(104, 19);
			this.installPath.TabIndex = 0;
			this.installPath.Text = "安装路径：";
			// 
			// selectInstallPath
			// 
			this.selectInstallPath.Location = new System.Drawing.Point(358, 306);
			this.selectInstallPath.Name = "selectInstallPath";
			this.selectInstallPath.Size = new System.Drawing.Size(82, 27);
			this.selectInstallPath.TabIndex = 2;
			this.selectInstallPath.Text = "浏览";
			this.selectInstallPath.UseVisualStyleBackColor = true;
			this.selectInstallPath.Click += new System.EventHandler(this.selectInstallPath_Click);
			// 
			// installPathValue
			// 
			this.installPathValue.Location = new System.Drawing.Point(132, 307);
			this.installPathValue.Name = "installPathValue";
			this.installPathValue.Size = new System.Drawing.Size(214, 25);
			this.installPathValue.TabIndex = 3;
			// 
			// addBootOption
			// 
			this.addBootOption.AutoSize = true;
			this.addBootOption.Font = new System.Drawing.Font("宋体", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.addBootOption.Location = new System.Drawing.Point(249, 419);
			this.addBootOption.Name = "addBootOption";
			this.addBootOption.Size = new System.Drawing.Size(132, 21);
			this.addBootOption.TabIndex = 3;
			this.addBootOption.Text = "添加开机启动";
			this.addBootOption.UseVisualStyleBackColor = true;
			// 
			// openAfterSetup
			// 
			this.openAfterSetup.AutoSize = true;
			this.openAfterSetup.Font = new System.Drawing.Font("宋体", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.openAfterSetup.Location = new System.Drawing.Point(26, 419);
			this.openAfterSetup.Name = "openAfterSetup";
			this.openAfterSetup.Size = new System.Drawing.Size(183, 21);
			this.openAfterSetup.TabIndex = 3;
			this.openAfterSetup.Text = "安装完成后打开程序";
			this.openAfterSetup.UseVisualStyleBackColor = true;
			// 
			// titleValue
			// 
			this.titleValue.Location = new System.Drawing.Point(102, 25);
			this.titleValue.Name = "titleValue";
			this.titleValue.Size = new System.Drawing.Size(244, 25);
			this.titleValue.TabIndex = 0;
			// 
			// done
			// 
			this.done.Location = new System.Drawing.Point(371, 472);
			this.done.Name = "done";
			this.done.Size = new System.Drawing.Size(82, 32);
			this.done.TabIndex = 6;
			this.done.Text = "完成";
			this.done.UseVisualStyleBackColor = true;
			this.done.Click += new System.EventHandler(this.done_Click);
			// 
			// runAfter
			// 
			this.runAfter.AutoSize = true;
			this.runAfter.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.runAfter.Location = new System.Drawing.Point(22, 349);
			this.runAfter.Name = "runAfter";
			this.runAfter.Size = new System.Drawing.Size(142, 19);
			this.runAfter.TabIndex = 0;
			this.runAfter.Text = "安装完成运行：";
			// 
			// runafterValue
			// 
			this.runafterValue.Location = new System.Drawing.Point(160, 346);
			this.runafterValue.Name = "runafterValue";
			this.runafterValue.Size = new System.Drawing.Size(280, 25);
			this.runafterValue.TabIndex = 3;
			// 
			// genUnsetup
			// 
			this.genUnsetup.AutoSize = true;
			this.genUnsetup.Font = new System.Drawing.Font("宋体", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.genUnsetup.Location = new System.Drawing.Point(26, 446);
			this.genUnsetup.Name = "genUnsetup";
			this.genUnsetup.Size = new System.Drawing.Size(132, 21);
			this.genUnsetup.TabIndex = 3;
			this.genUnsetup.Text = "生成卸载程序";
			this.genUnsetup.UseVisualStyleBackColor = true;
			this.genUnsetup.CheckedChanged += new System.EventHandler(this.genUnsetup_CheckedChanged);
			// 
			// showInstallWindow
			// 
			this.showInstallWindow.AutoSize = true;
			this.showInstallWindow.Font = new System.Drawing.Font("宋体", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.showInstallWindow.Location = new System.Drawing.Point(26, 473);
			this.showInstallWindow.Name = "showInstallWindow";
			this.showInstallWindow.Size = new System.Drawing.Size(132, 21);
			this.showInstallWindow.TabIndex = 3;
			this.showInstallWindow.Text = "显示安装过程";
			this.showInstallWindow.UseVisualStyleBackColor = true;
			// 
			// runBeforeUnValue
			// 
			this.runBeforeUnValue.Location = new System.Drawing.Point(161, 380);
			this.runBeforeUnValue.Name = "runBeforeUnValue";
			this.runBeforeUnValue.Size = new System.Drawing.Size(280, 25);
			this.runBeforeUnValue.TabIndex = 8;
			// 
			// runBeforeUn
			// 
			this.runBeforeUn.AutoSize = true;
			this.runBeforeUn.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.runBeforeUn.Location = new System.Drawing.Point(23, 383);
			this.runBeforeUn.Name = "runBeforeUn";
			this.runBeforeUn.Size = new System.Drawing.Size(142, 19);
			this.runBeforeUn.TabIndex = 7;
			this.runBeforeUn.Text = "卸载之前运行：";
			// 
			// publisherValue
			// 
			this.publisherValue.Location = new System.Drawing.Point(102, 141);
			this.publisherValue.Name = "publisherValue";
			this.publisherValue.Size = new System.Drawing.Size(124, 25);
			this.publisherValue.TabIndex = 10;
			// 
			// publisherLabel
			// 
			this.publisherLabel.AutoSize = true;
			this.publisherLabel.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.publisherLabel.Location = new System.Drawing.Point(22, 143);
			this.publisherLabel.Name = "publisherLabel";
			this.publisherLabel.Size = new System.Drawing.Size(85, 19);
			this.publisherLabel.TabIndex = 9;
			this.publisherLabel.Text = "发布者：";
			// 
			// versionValue
			// 
			this.versionValue.Location = new System.Drawing.Point(312, 141);
			this.versionValue.Name = "versionValue";
			this.versionValue.Size = new System.Drawing.Size(128, 25);
			this.versionValue.TabIndex = 12;
			// 
			// versionLabel
			// 
			this.versionLabel.AutoSize = true;
			this.versionLabel.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.versionLabel.Location = new System.Drawing.Point(232, 144);
			this.versionLabel.Name = "versionLabel";
			this.versionLabel.Size = new System.Drawing.Size(85, 19);
			this.versionLabel.TabIndex = 11;
			this.versionLabel.Text = "版本号：";
			// 
			// MainGUI
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(465, 518);
			this.Controls.Add(this.versionValue);
			this.Controls.Add(this.publisherValue);
			this.Controls.Add(this.runBeforeUnValue);
			this.Controls.Add(this.versionLabel);
			this.Controls.Add(this.publisherLabel);
			this.Controls.Add(this.runBeforeUn);
			this.Controls.Add(this.runafterValue);
			this.Controls.Add(this.done);
			this.Controls.Add(this.installPathValue);
			this.Controls.Add(this.listDes);
			this.Controls.Add(this.shortcutList);
			this.Controls.Add(this.genUnsetup);
			this.Controls.Add(this.openAfterSetup);
			this.Controls.Add(this.showInstallWindow);
			this.Controls.Add(this.addBootOption);
			this.Controls.Add(this.generateShortcut);
			this.Controls.Add(this.mainExeValue);
			this.Controls.Add(this.dirValue);
			this.Controls.Add(this.clear);
			this.Controls.Add(this.add);
			this.Controls.Add(this.remove);
			this.Controls.Add(this.selectInstallPath);
			this.Controls.Add(this.selectExe);
			this.Controls.Add(this.selectDir);
			this.Controls.Add(this.runAfter);
			this.Controls.Add(this.installPath);
			this.Controls.Add(this.titleValue);
			this.Controls.Add(this.mainExe);
			this.Controls.Add(this.dir);
			this.Controls.Add(this.title);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "MainGUI";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "静默安装包-配置模块";
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
        private System.Windows.Forms.CheckBox addBootOption;
        private System.Windows.Forms.CheckBox openAfterSetup;
        private System.Windows.Forms.TextBox titleValue;
        private System.Windows.Forms.Button done;
        private System.Windows.Forms.Label runAfter;
        private System.Windows.Forms.TextBox runafterValue;
        public System.Windows.Forms.ListBox shortcutList;
        private System.Windows.Forms.CheckBox genUnsetup;
        private System.Windows.Forms.CheckBox showInstallWindow;
		private System.Windows.Forms.TextBox runBeforeUnValue;
		private System.Windows.Forms.Label runBeforeUn;
		private System.Windows.Forms.TextBox publisherValue;
		private System.Windows.Forms.Label publisherLabel;
		private System.Windows.Forms.TextBox versionValue;
		private System.Windows.Forms.Label versionLabel;
	}
}