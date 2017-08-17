using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace filedownloaderclient
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDownload_Click(object sender, EventArgs e)
        {
            if (sfdMain.ShowDialog() == DialogResult.OK)
            {
                var svrPath = new Uri(txtSvrPath.Text);
                var localPath = sfdMain.FileName;
                var wc = new WebClient();
                wc.DownloadProgressChanged += Wc_DownloadProgressChanged;
                wc.DownloadFileCompleted += Wc_DownloadFileCompleted;
                wc.DownloadFileAsync(svrPath, localPath);
            }        
        }

        private void Wc_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            lblStatus.Text = $"{e.ProgressPercentage.ToString()}%";
        }

        private void Wc_DownloadFileCompleted(object sender, AsyncCompletedEventArgs e)
        {
            MessageBox.Show("File downloaded");
        }
    }
}
