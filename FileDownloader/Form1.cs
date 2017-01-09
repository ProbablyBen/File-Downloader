using System;
using System.ComponentModel;
using System.IO;
using System.Net;
using System.Windows.Forms;

namespace FileDownloader
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        #region Moveable Form
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        private void Form1_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
        #endregion
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This tool was designed to download files efficiently using C# and .NET framework");
        }
        private void lblSaveClick_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();

            saveFileDialog1.Filter = "All files (*.*)|*.*";
            saveFileDialog1.RestoreDirectory = true;
            saveFileDialog1.ShowDialog();
            txtSaveDestination.Text = saveFileDialog1.FileName;
        }
        private void btnDownload_Click(object sender, EventArgs e)
        {
            #region Convert URL to URI
            Uri uri;
            try
            {
                uri = new Uri(txtURL.Text);
            }
            catch (ArgumentNullException)
            {
                MessageBox.Show("Please enter a link!", "Error");
                return;
            }
            catch (UriFormatException)
            {
                MessageBox.Show("Please enter a valid URL!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            #endregion
            Console.WriteLine("Successfully converted the URL to a Uri");
            #region Check if DIR exists
            int filenameIndex = txtSaveDestination.Text.LastIndexOf('\\');
            string DIR = txtSaveDestination.Text.Substring(0, filenameIndex + 1);
            Console.WriteLine("DIR: {0}", DIR);
            if (!Directory.Exists(DIR))
            {
                MessageBox.Show("There was an error writing to the directory.\nPerhaps it was deleted?", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            #endregion
            Console.WriteLine("Directory is still valid");
            #region Start Download
            DownloadFile(uri, txtSaveDestination.Text);
            #endregion
            btnDownload.Enabled = false;
        }
        private void DownloadFile(Uri sourceUrl, string targetFolder)
        {
            WebClient downloader = new WebClient();
            downloader.DownloadFileCompleted += new AsyncCompletedEventHandler(Downloader_DownloadFileCompleted);
            downloader.DownloadProgressChanged += new DownloadProgressChangedEventHandler(Downloader_DownloadProgressChanged);
            try
            {
                downloader.DownloadFileAsync(sourceUrl, targetFolder);
            }
            catch(InvalidOperationException)
            {
                MessageBox.Show("There was an error writing to the file");
                btnDownload.Enabled = true;
            }
            
        }
        private void Downloader_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            pbDownload.Value = e.ProgressPercentage;
            lblProgress.Text = "Progress: " + Convert.ToString(e.ProgressPercentage) + "%";
        }
        private void Downloader_DownloadFileCompleted(object sender, AsyncCompletedEventArgs e)
        {
            lblProgress.Text = Convert.ToString(100) + "%";
            btnDownload.Enabled = true;
        }

    }
}
