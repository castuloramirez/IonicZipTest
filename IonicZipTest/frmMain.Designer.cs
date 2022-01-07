namespace IonicZipTest
{
    partial class frmMain
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtFilePath = new System.Windows.Forms.TextBox();
            this.btnSelectFile = new System.Windows.Forms.Button();
            this.btnTestCompress = new System.Windows.Forms.Button();
            this.btnTestDecompress = new System.Windows.Forms.Button();
            this.txtLog = new System.Windows.Forms.RichTextBox();
            this.btnSelectDir = new System.Windows.Forms.Button();
            this.txtDirPath = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select file:";
            // 
            // txtFilePath
            // 
            this.txtFilePath.Location = new System.Drawing.Point(144, 19);
            this.txtFilePath.Name = "txtFilePath";
            this.txtFilePath.ReadOnly = true;
            this.txtFilePath.Size = new System.Drawing.Size(440, 22);
            this.txtFilePath.TabIndex = 1;
            // 
            // btnSelectFile
            // 
            this.btnSelectFile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSelectFile.Location = new System.Drawing.Point(590, 18);
            this.btnSelectFile.Name = "btnSelectFile";
            this.btnSelectFile.Size = new System.Drawing.Size(75, 25);
            this.btnSelectFile.TabIndex = 2;
            this.btnSelectFile.Text = "choose";
            this.btnSelectFile.UseVisualStyleBackColor = true;
            this.btnSelectFile.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // btnTestCompress
            // 
            this.btnTestCompress.Location = new System.Drawing.Point(26, 85);
            this.btnTestCompress.Name = "btnTestCompress";
            this.btnTestCompress.Size = new System.Drawing.Size(83, 27);
            this.btnTestCompress.TabIndex = 3;
            this.btnTestCompress.Text = "Zip test";
            this.btnTestCompress.UseVisualStyleBackColor = true;
            this.btnTestCompress.Click += new System.EventHandler(this.btnTestCompress_Click);
            // 
            // btnTestDecompress
            // 
            this.btnTestDecompress.Location = new System.Drawing.Point(132, 85);
            this.btnTestDecompress.Name = "btnTestDecompress";
            this.btnTestDecompress.Size = new System.Drawing.Size(114, 27);
            this.btnTestDecompress.TabIndex = 4;
            this.btnTestDecompress.Text = "Unzip test";
            this.btnTestDecompress.UseVisualStyleBackColor = true;
            this.btnTestDecompress.Click += new System.EventHandler(this.btnTestDecompress_Click);
            // 
            // txtLog
            // 
            this.txtLog.Location = new System.Drawing.Point(26, 118);
            this.txtLog.Name = "txtLog";
            this.txtLog.ReadOnly = true;
            this.txtLog.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.txtLog.Size = new System.Drawing.Size(639, 199);
            this.txtLog.TabIndex = 5;
            this.txtLog.Text = "";
            // 
            // btnSelectDir
            // 
            this.btnSelectDir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSelectDir.Location = new System.Drawing.Point(590, 51);
            this.btnSelectDir.Name = "btnSelectDir";
            this.btnSelectDir.Size = new System.Drawing.Size(75, 25);
            this.btnSelectDir.TabIndex = 8;
            this.btnSelectDir.Text = "choose";
            this.btnSelectDir.UseVisualStyleBackColor = true;
            this.btnSelectDir.Click += new System.EventHandler(this.btnSelectDir_Click);
            // 
            // txtDirPath
            // 
            this.txtDirPath.Location = new System.Drawing.Point(144, 52);
            this.txtDirPath.Name = "txtDirPath";
            this.txtDirPath.ReadOnly = true;
            this.txtDirPath.Size = new System.Drawing.Size(440, 22);
            this.txtDirPath.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Select folder:";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 336);
            this.Controls.Add(this.btnSelectDir);
            this.Controls.Add(this.txtDirPath);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtLog);
            this.Controls.Add(this.btnTestDecompress);
            this.Controls.Add(this.btnTestCompress);
            this.Controls.Add(this.btnSelectFile);
            this.Controls.Add(this.txtFilePath);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMain";
            this.Text = "Compression and decompression function test";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFilePath;
        private System.Windows.Forms.Button btnSelectFile;
        private System.Windows.Forms.Button btnTestCompress;
        private System.Windows.Forms.Button btnTestDecompress;
        private System.Windows.Forms.RichTextBox txtLog;
        private System.Windows.Forms.Button btnSelectDir;
        private System.Windows.Forms.TextBox txtDirPath;
        private System.Windows.Forms.Label label2;
    }
}

