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
    public partial class wfrmReplaceDateAll : Form
    {
        private string path = string.Empty;
        public string DirectoryPath
        {
            get { return path; }
            set { path = value; }
        }

        public wfrmReplaceDateAll()
        {
            InitializeComponent();
        }

        private void ReplaceDateAll_Load(object sender, EventArgs e)
        {

        }

        private void btnReplace_Click(object sender, EventArgs e)
        {
            try
            {

                foreach (string file in Directory.GetFiles(@path))
                {
                    Common.ChangeDateFile(file, dtpCreateDate.Value, dtpCreateTime.Value, dtpModifiedDate.Value, dtpModifiedTime.Value);
                }

                string[] direcories;
                if (chkDirectory.Checked == true)
                {
                    direcories = Common.GetDirectories(@path).ToArray();
                }
                else
                {
                    direcories = Directory.GetDirectories(@path);
                }

             
                foreach (string dir in direcories)
                {
                    Common.ChangeDateDirectory(dir, dtpCreateDate.Value, dtpCreateTime.Value, dtpModifiedDate.Value, dtpModifiedTime.Value);
                   
                    foreach (string file in Directory.GetFiles(dir))
                    {
                        Common.ChangeDateFile(file, dtpCreateDate.Value, dtpCreateTime.Value, dtpModifiedDate.Value, dtpModifiedTime.Value);
                    }
                }
                MessageBox.Show("La modificación ha terminado.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


    }
}
