using Ionic.Zip;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace IonicZipTest
{
    public partial class frmMain : Form
    {
        private const string DEFAULT_ZIP_FILE_NAME = "TestZip.zip";
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Multiselect = false;

            if (ofd.ShowDialog(this) != DialogResult.OK)
            {
                return;
            }

            txtFilePath.Text = ofd.FileName;

            LogOperate("Selected File:" + ofd.FileName);
        }

        private void LogOperate(string opt)
        {
            this.txtLog.Text += string.Format("\r\n[{0}]：{1}", DateTime.Now.ToString(), opt);
        }

        private void btnTestCompress_Click(object sender, EventArgs e)
        {
            using (var zip = new ZipFile(Encoding.Default))
            {
                if (System.IO.File.Exists(txtFilePath.Text))
                {
                    zip.AddFile(txtFilePath.Text);
                }

                if (Directory.Exists(txtDirPath.Text))
                {
                    DirectoryInfo di = new DirectoryInfo(txtDirPath.Text);
                    zip.AddDirectory(di.FullName,di.Name);
                }
                
                zip.Save(DEFAULT_ZIP_FILE_NAME);
                LogOperate("Compressed File:"+ DEFAULT_ZIP_FILE_NAME);

                System.Diagnostics.Process.Start("explorer.exe", Application.StartupPath);
            }
        }

        private void btnTestDecompress_Click(object sender, EventArgs e)
        {
            using (var zip = new ZipFile(DEFAULT_ZIP_FILE_NAME))
            {
                zip.ExtractAll(Application.StartupPath,true);
                LogOperate("Decompressed File:testzip.zip");
            }
        }

        private void btnSelectDir_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog(this) != DialogResult.OK)
            {
                return;
            }

            txtDirPath.Text = fbd.SelectedPath;

            LogOperate("Selected Dir:" + fbd.SelectedPath);
        }
    }
}
