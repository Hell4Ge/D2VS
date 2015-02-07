using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.Security.Cryptography;
using System.Net;
using System.Threading;
using System.IO;
using System.IO.Compression;
using ICSharpCode.SharpZipLib.Zip;

namespace D2VS
{
    public partial class Form1 : Form
    {
        private String D2Path;
        public static readonly String version = "1.1";
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void BTN_SELECT_PATH_Click(object sender, EventArgs e)
        {
            var dr = DiabloPathBrowser.ShowDialog();
            if (dr == DialogResult.OK)
            {
              //  if (!isValidPath(DiabloPathBrowser.SelectedPath))
              //      MessageBox.Show("Path error", "The path you selected is wrong", MessageBoxButtons.OK, MessageBoxIcon.Error);

                TB_D2Path.Text = DiabloPathBrowser.SelectedPath;
                this.D2Path = DiabloPathBrowser.SelectedPath;
            }
        }

        private bool isValidPath(String path)
        {
            if(System.IO.File.Exists(path + "\\Game.exe") && System.IO.File.Exists(path + "\\Diablo II.exe"))
                return true;

            return false;
        }

        private void BTN_Gate_Click(object sender, EventArgs e)
        {
            var ge = new GateEditor();
            ge.Show();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            String msg = "Ten program może nie działać z wersją pobraną z serwera battle.net\nBy program działał sprawnie należy mieć wersję instalowaną z płyt CD lub wirtualnej płyty";
            String msg2 = "Pamiętaj za pomocą czego łączysz się z daną krainą, jeżeli zaczniesz masowo zmieniać wersję i wejdziesz z d2loaderem na Europę nie odpowiadam za głupotę ludzką oraz zbanowane konta";

            MessageBox.Show(msg, "D2CT v"+version, MessageBoxButtons.OK, MessageBoxIcon.Information);
            MessageBox.Show(msg2, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            String zipPath = this.D2Path + "\\" + CB_Patch.SelectedItem.ToString() + ".zip";

            
            if (File.Exists(zipPath) && Patches.UpdateHash.isLegit(zipPath)) // skip downloading and extract patch
            {
                applyPatch(CB_Patch.SelectedItem.ToString());
            }
            else
            {
                startDownload(CB_Patch.SelectedItem.ToString(), TB_D2Path.Text);
            }
        }

        private void startDownload(String ver, String path)
        {
            Thread thread = new Thread(() => {
                WebClient client = new WebClient();
                client.Proxy = null;
                client.DownloadProgressChanged += new DownloadProgressChangedEventHandler(client_DownloadProgressChanged);
                client.DownloadFileCompleted += new AsyncCompletedEventHandler(client_DownloadFileCompleted);
                client.DownloadFileAsync(new Uri("http://www.hell4ge.nazwa.pl//personal//d2t//D2VS//patches//" + ver + ".zip"), path + "\\" + ver + ".zip");
            });
            thread.Start();
        }
        private void client_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            this.BeginInvoke((MethodInvoker)delegate {
                double bytesIn = double.Parse(e.BytesReceived.ToString());
                double totalBytes = double.Parse(e.TotalBytesToReceive.ToString());
                double percentage = bytesIn / totalBytes * 100;
                PB_Download.Value = int.Parse(Math.Truncate(percentage).ToString());
            });
        }
        private void client_DownloadFileCompleted(object sender, AsyncCompletedEventArgs e)
        {
            this.BeginInvoke((MethodInvoker)delegate {

                applyPatch(CB_Patch.SelectedItem.ToString());

                MessageBox.Show("Patch applied", CB_Patch.SelectedItem.ToString());

                PB_Download.Value = 0;
            });
        }
 
        private void applyPatch(String ver)
        {
            FastZip zip = new FastZip();
            String version = ver;
            String zipPatchPath = this.D2Path + "\\" + version + ".zip";

            zip.ExtractZip(zipPatchPath, this.D2Path, null);

            String fileName = "";
            String destFile = "";
            String sourcePath = this.D2Path + "\\" + version;   // Patch files
            String targetPath = this.D2Path;                    // D2 folder
            if (System.IO.Directory.Exists(sourcePath))
            {
                string[] files = System.IO.Directory.GetFiles(sourcePath);

                // Copy the files and overwrite destination files if they already exist.
                foreach (string s in files)
                {
                    // Use static Path methods to extract only the file name from the path.
                    fileName = System.IO.Path.GetFileName(s);
                    destFile = System.IO.Path.Combine(targetPath, fileName);
                    System.IO.File.Copy(s, destFile, true);
                }
            }
        }

        private void BTN_Run_Click(object sender, EventArgs e)
        {
            Process.Start(DiabloPathBrowser.SelectedPath + "\\Game.exe");
        }

    }
}
