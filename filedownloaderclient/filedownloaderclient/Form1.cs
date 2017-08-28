using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace filedownloaderclient
{
    public partial class Form1 : Form
    {
        string _autoSavingPath;
        string _destinyPath;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnDownload_Click(object sender, EventArgs e)
        {
            if (sfdMain.ShowDialog() == DialogResult.OK)
            {
                var svrPath = txtSvrPath.Text;
                var localPath = sfdMain.FileName;
                DownloadFile(svrPath, localPath);
            }
        }        

        private void btnAutoCopy_Click(object sender, EventArgs e)
        {
            txtSvrPath.Text = Clipboard.ContainsText() ? Clipboard.GetText() :
                  String.Empty;
            txtFileName.Text = String.Empty;
            txtFileName.Focus();
        }

        private void btnSavingFolder_Click(object sender, EventArgs e)
        {
            if (fbdMain.ShowDialog() == DialogResult.OK)
            {
                _autoSavingPath = lblSavingPath.Text = fbdMain.SelectedPath;
            }
        }

        private void btnAutoSave_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(_autoSavingPath))
            {
                var fileCountOnSavingFolder = Directory.GetFiles(_autoSavingPath).Count();
                _destinyPath = $@"{_autoSavingPath}\{++fileCountOnSavingFolder}. {txtFileName.Text}.mp4";
                DownloadFile(txtSvrPath.Text, _destinyPath);
            }
            else MessageBox.Show("Set the autosaving folder first");
        }

        private void DownloadFile(string origin, string destinyName)
        {
            var svrPath = new Uri(origin);
            var wc = new WebClient();
            wc.DownloadProgressChanged += Wc_DownloadProgressChanged;
            wc.DownloadFileCompleted += Wc_DownloadFileCompleted;
            wc.DownloadFileAsync(svrPath, destinyName);
        }

        private void Wc_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e) =>
            txtStatus.Text = $"{e.ProgressPercentage.ToString()}%";

        private void Wc_DownloadFileCompleted(object sender, AsyncCompletedEventArgs e) =>
            txtStatus.Text = $"{_destinyPath} Download Finished";
    }
}
