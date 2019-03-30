using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace ChageMetadataFile
{
    public partial class wfrmChange : Form
    {
        private string gDirectory = string.Empty;
        private string gCurrentFile = string.Empty;
        private string gFileType = string.Empty;

        public wfrmChange()
        {
            InitializeComponent();
        }

        private void openDirecotryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SelectDirectory();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.lbwLista.SelectedItems.Count > 0)
            {
                gCurrentFile = Path.Combine(gDirectory, this.lbwLista.SelectedItems[0].Text);
                gFileType = this.lbwLista.SelectedItems[0].SubItems[2].Text;

                if (gFileType == "File")
                {
                    FileInfo finfo = new FileInfo(@gCurrentFile);
                    dtpCreateDate.Value = finfo.CreationTime;
                    dtpCreateTime.Value = finfo.CreationTime;
                    dtpModifiedDate.Value = finfo.LastWriteTime;
                    dtpModifiedTime.Value = finfo.LastWriteTime;
                    txtSizeBytes.Text = finfo.Length.ToString();
                    txtSizeMB.Text = GetKb(finfo.Length);
                    lblPropertyName.Text = "File Name:";
                    txtFileName.Text = finfo.Name;
                    lblMsg.Text = string.Empty;
                }
                else
                {
                    long vSizeDir = GetDirectorySize(@gCurrentFile);
                    DirectoryInfo finfo = new DirectoryInfo(@gCurrentFile);
                    dtpCreateDate.Value = finfo.CreationTime;
                    dtpCreateTime.Value = finfo.CreationTime;
                    dtpModifiedDate.Value = finfo.LastWriteTime;
                    dtpModifiedTime.Value = finfo.LastWriteTime;
                    txtSizeBytes.Text = vSizeDir.ToString();
                    txtSizeMB.Text = GetKb(vSizeDir);
                    lblPropertyName.Text = "Directory Name:";
                    txtFileName.Text = finfo.Name;
                    lblMsg.Text = string.Empty; 
                }
            }
        }
        public static long GetDirectorySize(string path)
        {
            string[] files = Directory.GetFiles(path);
            string[] subdirectories = Directory.GetDirectories(path);

            long size = files.Sum(x => new FileInfo(x).Length);
            foreach (string s in subdirectories)
                size += GetDirectorySize(s);

            return size;
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            
            if (File.Exists(gCurrentFile))
            {
                Common.ChangeDateFile(gCurrentFile, dtpCreateDate.Value, dtpCreateTime.Value, dtpModifiedDate.Value, dtpModifiedTime.Value); 
            }
            else if (Directory.Exists(gCurrentFile))
            {
                Common.ChangeDateDirectory(gCurrentFile, dtpCreateDate.Value, dtpCreateTime.Value, dtpModifiedDate.Value, dtpModifiedTime.Value);
            }
            else
            {
                return;
            }

            lblMsg.Text = "Archivo modificado correctamente";
            LoadFilesInListView();
        }

        private string GetKb(long bytes)
        {
            return Convert.ToString((Math.Round(bytes / 1024f, 2))) + " KB";
        }
        private void LoadFilesInListView()
        {
            try
            {
                if(!Directory.Exists(gDirectory))
                {
                    MessageBox.Show("El directorio indicado no es válido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                lbwLista.Items.Clear();
                string[] files = Directory.GetFiles(gDirectory);
                if(files.Length > 0 )
                {
                    foreach (string file in files)
                    {
                        FileInfo finfo = new FileInfo(@file);
                        ListViewItem item = new ListViewItem(finfo.Name);
                        item.SubItems.Add(finfo.LastWriteTime.ToString());
                        item.SubItems.Add("File");
                        item.SubItems.Add(finfo.Length.ToString());
                        item.SubItems.Add(GetKb(finfo.Length));
                        lbwLista.Items.Add(item);
                    }
                }

                string[] dirs = Directory.GetDirectories(gDirectory);
                if(dirs.Length > 0)
                {
                    foreach (string dir in dirs)
                    {
                        DirectoryInfo finfo = new DirectoryInfo(dir);
                        ListViewItem item = new ListViewItem(finfo.Name);
                        item.SubItems.Add(finfo.LastWriteTime.ToString());
                        item.SubItems.Add("DIR");
                        item.SubItems.Add("");
                        item.SubItems.Add("");
                        lbwLista.Items.Add(item);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void SelectDirectory()
        {
            using (FolderBrowserDialog ofd = new FolderBrowserDialog())
            {
                ofd.ShowDialog();
                if (!string.IsNullOrEmpty(ofd.SelectedPath))
                {
                    gDirectory = ofd.SelectedPath;
                    txtDirectory.Text = gDirectory;
                    LoadFilesInListView();
                }
            }
        }

        private void replaceDateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            wfrmReplaceDateAll frmreplace = new wfrmReplaceDateAll();
            frmreplace.DirectoryPath = gDirectory;
            frmreplace.ShowDialog();
        }

        private void btnSetDirectory_Click(object sender, EventArgs e)
        {
            SelectDirectory();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            gDirectory = txtDirectory.Text;
            LoadFilesInListView();
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            string[] files = Directory.GetFiles(txtDirectory.Text);
            string[] dirs = Directory.GetDirectories(txtDirectory.Text);

            if (files.Length <= 0 && dirs.Length <= 0)
            {
                MessageBox.Show("No hay archivos o carpetas en la ruta indicada", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            SaveFileDialog sfd = new SaveFileDialog();
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                StringBuilder str = new StringBuilder();

                str.Append("NOMBRE");
                str.Append(";");
                str.Append("DIRECTORIO");
                str.Append(";");
                str.Append("FECHA CREACION");
                str.Append(";");
                str.Append("FECHA MODIFICACION");
                str.Append(";");
                str.Append("SIZE BYTES");
                str.Append(";");
                str.Append("SIZE MB");
                str.Append(";");
                str.AppendLine();
                foreach (string file in files)
                {
                    FileInfo finfo = new FileInfo(@file);
                    str.Append(finfo.Name);
                    str.Append(";");
                    str.Append(finfo.Directory);
                    str.Append(";");
                    str.Append(finfo.CreationTime.ToString("dd/mm/yyyy hh:mi:ss"));
                    str.Append(";");
                    str.Append(finfo.LastWriteTime.ToString("dd/mm/yyyy hh:mi:ss"));
                    str.Append(";");
                    str.Append(finfo.Length.ToString());
                    str.Append(";");
                    str.Append(GetKb(finfo.Length));
                    str.Append(";");
                    str.AppendLine();
                }

                foreach (string dir in dirs)
                {
                    DirectoryInfo finfo = new DirectoryInfo(dir);
                    str.AppendLine(finfo.Name);
                    str.Append(";");
                    str.Append(finfo.Parent);
                    str.Append(";");
                    str.Append(finfo.CreationTime.ToString("dd/mm/yyyy hh:mi:ss"));
                    str.Append(";");
                    str.Append(finfo.LastWriteTime.ToString("dd/mm/yyyy hh:mi:ss"));
                    str.Append(";");
                    str.Append(";");
                    str.Append(";");
                    str.AppendLine();
                }

                string ruta = sfd.FileName;
                FileStream archivo1 = File.OpenWrite(ruta);
                string cadenaTexto = str.ToString();
                byte[] bytes = Encoding.ASCII.GetBytes(cadenaTexto);
                int no_bytes = bytes.Length;
                archivo1.Write(bytes, 0, no_bytes);
                archivo1.Close();
                archivo1.Dispose();
                MessageBox.Show("CSV generado correctamente.");
            }
        }
         
    }
}
