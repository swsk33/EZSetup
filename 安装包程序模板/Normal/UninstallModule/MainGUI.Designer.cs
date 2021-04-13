
namespace InstallPack.UninstallModule
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
            this.uninstallTip = new System.Windows.Forms.Label();
            this.cancel = new System.Windows.Forms.Button();
            this.ok = new System.Windows.Forms.Button();
            this.uninstalling = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // uninstallTip
            // 
            this.uninstallTip.AutoSize = true;
            this.uninstallTip.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uninstallTip.Location = new System.Drawing.Point(45, 41);
            this.uninstallTip.Name = "uninstallTip";
            this.uninstallTip.Size = new System.Drawing.Size(324, 25);
            this.uninstallTip.TabIndex = 0;
            this.uninstallTip.Text = "即将进行该程序的卸载流程";
            // 
            // cancel
            // 
            this.cancel.Location = new System.Drawing.Point(371, 147);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(78, 31);
            this.cancel.TabIndex = 1;
            this.cancel.Text = "取消";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // ok
            // 
            this.ok.Location = new System.Drawing.Point(488, 147);
            this.ok.Name = "ok";
            this.ok.Size = new System.Drawing.Size(78, 31);
            this.ok.TabIndex = 1;
            this.ok.Text = "卸载";
            this.ok.UseVisualStyleBackColor = true;
            this.ok.Click += new System.EventHandler(this.ok_Click);
            // 
            // uninstalling
            // 
            this.uninstalling.AutoSize = true;
            this.uninstalling.ForeColor = System.Drawing.Color.Red;
            this.uninstalling.Location = new System.Drawing.Point(47, 92);
            this.uninstalling.Name = "uninstalling";
            this.uninstalling.Size = new System.Drawing.Size(97, 15);
            this.uninstalling.TabIndex = 2;
            this.uninstalling.Text = "卸载中。。。";
            this.uninstalling.Visible = false;
            // 
            // MainGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(607, 203);
            this.Controls.Add(this.uninstalling);
            this.Controls.Add(this.ok);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.uninstallTip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainGUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainGUI";
            this.Load += new System.EventHandler(this.MainGUI_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label uninstallTip;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.Button ok;
        private System.Windows.Forms.Label uninstalling;
    }
}