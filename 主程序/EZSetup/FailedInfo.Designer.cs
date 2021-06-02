
namespace EZSetup
{
	partial class FailedInfo
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FailedInfo));
			this.failedTitle = new System.Windows.Forms.Label();
			this.stdOutLabel = new System.Windows.Forms.Label();
			this.stdErrLabel = new System.Windows.Forms.Label();
			this.stdOutValue = new System.Windows.Forms.TextBox();
			this.stdErrValue = new System.Windows.Forms.TextBox();
			this.close = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// failedTitle
			// 
			this.failedTitle.AutoSize = true;
			this.failedTitle.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.failedTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
			this.failedTitle.Location = new System.Drawing.Point(56, 19);
			this.failedTitle.Name = "failedTitle";
			this.failedTitle.Size = new System.Drawing.Size(370, 19);
			this.failedTitle.TabIndex = 0;
			this.failedTitle.Text = "安装包构建失败，以下是错误信息以供参考";
			// 
			// stdOutLabel
			// 
			this.stdOutLabel.AutoSize = true;
			this.stdOutLabel.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.stdOutLabel.ForeColor = System.Drawing.Color.ForestGreen;
			this.stdOutLabel.Location = new System.Drawing.Point(13, 52);
			this.stdOutLabel.Name = "stdOutLabel";
			this.stdOutLabel.Size = new System.Drawing.Size(109, 19);
			this.stdOutLabel.TabIndex = 1;
			this.stdOutLabel.Text = "标准输出：";
			// 
			// stdErrLabel
			// 
			this.stdErrLabel.AutoSize = true;
			this.stdErrLabel.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.stdErrLabel.ForeColor = System.Drawing.Color.Red;
			this.stdErrLabel.Location = new System.Drawing.Point(13, 251);
			this.stdErrLabel.Name = "stdErrLabel";
			this.stdErrLabel.Size = new System.Drawing.Size(109, 19);
			this.stdErrLabel.TabIndex = 1;
			this.stdErrLabel.Text = "标准错误：";
			// 
			// stdOutValue
			// 
			this.stdOutValue.BackColor = System.Drawing.Color.DimGray;
			this.stdOutValue.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.stdOutValue.ForeColor = System.Drawing.Color.Lime;
			this.stdOutValue.Location = new System.Drawing.Point(31, 85);
			this.stdOutValue.Multiline = true;
			this.stdOutValue.Name = "stdOutValue";
			this.stdOutValue.ReadOnly = true;
			this.stdOutValue.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.stdOutValue.Size = new System.Drawing.Size(426, 148);
			this.stdOutValue.TabIndex = 2;
			this.stdOutValue.WordWrap = false;
			// 
			// stdErrValue
			// 
			this.stdErrValue.BackColor = System.Drawing.Color.DimGray;
			this.stdErrValue.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.stdErrValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
			this.stdErrValue.Location = new System.Drawing.Point(31, 287);
			this.stdErrValue.Multiline = true;
			this.stdErrValue.Name = "stdErrValue";
			this.stdErrValue.ReadOnly = true;
			this.stdErrValue.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.stdErrValue.Size = new System.Drawing.Size(426, 159);
			this.stdErrValue.TabIndex = 2;
			this.stdErrValue.WordWrap = false;
			// 
			// close
			// 
			this.close.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.close.Location = new System.Drawing.Point(199, 464);
			this.close.Name = "close";
			this.close.Size = new System.Drawing.Size(82, 39);
			this.close.TabIndex = 3;
			this.close.Text = "关闭";
			this.close.UseVisualStyleBackColor = true;
			this.close.Click += new System.EventHandler(this.close_Click);
			// 
			// FailedInfo
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(486, 518);
			this.Controls.Add(this.close);
			this.Controls.Add(this.stdErrValue);
			this.Controls.Add(this.stdOutValue);
			this.Controls.Add(this.stdErrLabel);
			this.Controls.Add(this.stdOutLabel);
			this.Controls.Add(this.failedTitle);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "FailedInfo";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "错误信息";
			this.TopMost = true;
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label failedTitle;
		private System.Windows.Forms.Label stdOutLabel;
		private System.Windows.Forms.Label stdErrLabel;
		private System.Windows.Forms.TextBox stdOutValue;
		private System.Windows.Forms.TextBox stdErrValue;
		private System.Windows.Forms.Button close;
	}
}