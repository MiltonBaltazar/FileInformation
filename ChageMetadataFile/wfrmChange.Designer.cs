namespace ChageMetadataFile
{
    partial class wfrmChange
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(wfrmChange));
            this.lbwLista = new System.Windows.Forms.ListView();
            this.chlName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chlDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chlSize = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chlSizeKb = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnChange = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openDirecotryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.opcionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.replaceDateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDirectory = new System.Windows.Forms.TextBox();
            this.dtpCreateDate = new System.Windows.Forms.DateTimePicker();
            this.dtpCreateTime = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpModifiedTime = new System.Windows.Forms.DateTimePicker();
            this.dtpModifiedDate = new System.Windows.Forms.DateTimePicker();
            this.lblMsg = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnSetDirectory = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSizeBytes = new System.Windows.Forms.TextBox();
            this.txtSizeMB = new System.Windows.Forms.TextBox();
            this.btnExport = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtFileName = new System.Windows.Forms.TextBox();
            this.lblPropertyName = new System.Windows.Forms.Label();
            this.chlType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbwLista
            // 
            this.lbwLista.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.lbwLista.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbwLista.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chlName,
            this.chlDate,
            this.chlType,
            this.chlSize,
            this.chlSizeKb});
            this.lbwLista.GridLines = true;
            this.lbwLista.HideSelection = false;
            this.lbwLista.Location = new System.Drawing.Point(12, 103);
            this.lbwLista.MultiSelect = false;
            this.lbwLista.Name = "lbwLista";
            this.lbwLista.Size = new System.Drawing.Size(708, 216);
            this.lbwLista.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.lbwLista.TabIndex = 0;
            this.lbwLista.UseCompatibleStateImageBehavior = false;
            this.lbwLista.View = System.Windows.Forms.View.Details;
            this.lbwLista.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // chlName
            // 
            this.chlName.Text = "Name";
            this.chlName.Width = 348;
            // 
            // chlDate
            // 
            this.chlDate.Text = "Date modified";
            this.chlDate.Width = 127;
            // 
            // chlSize
            // 
            this.chlSize.Text = "Size";
            this.chlSize.Width = 66;
            // 
            // chlSizeKb
            // 
            this.chlSizeKb.Text = "Size KB";
            this.chlSizeKb.Width = 68;
            // 
            // btnChange
            // 
            this.btnChange.Location = new System.Drawing.Point(635, 46);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(66, 46);
            this.btnChange.TabIndex = 1;
            this.btnChange.Text = "Change";
            this.btnChange.UseVisualStyleBackColor = true;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.opcionesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(734, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openDirecotryToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openDirecotryToolStripMenuItem
            // 
            this.openDirecotryToolStripMenuItem.Name = "openDirecotryToolStripMenuItem";
            this.openDirecotryToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.openDirecotryToolStripMenuItem.Text = "Open Direcotry";
            this.openDirecotryToolStripMenuItem.Click += new System.EventHandler(this.openDirecotryToolStripMenuItem_Click);
            // 
            // opcionesToolStripMenuItem
            // 
            this.opcionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.replaceDateToolStripMenuItem});
            this.opcionesToolStripMenuItem.Name = "opcionesToolStripMenuItem";
            this.opcionesToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.opcionesToolStripMenuItem.Text = "Tools";
            // 
            // replaceDateToolStripMenuItem
            // 
            this.replaceDateToolStripMenuItem.Name = "replaceDateToolStripMenuItem";
            this.replaceDateToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.replaceDateToolStripMenuItem.Text = "Change all";
            this.replaceDateToolStripMenuItem.Click += new System.EventHandler(this.replaceDateToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Carpeta";
            // 
            // txtDirectory
            // 
            this.txtDirectory.Location = new System.Drawing.Point(69, 44);
            this.txtDirectory.Name = "txtDirectory";
            this.txtDirectory.Size = new System.Drawing.Size(363, 20);
            this.txtDirectory.TabIndex = 4;
            // 
            // dtpCreateDate
            // 
            this.dtpCreateDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.dtpCreateDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpCreateDate.Location = new System.Drawing.Point(427, 49);
            this.dtpCreateDate.Name = "dtpCreateDate";
            this.dtpCreateDate.Size = new System.Drawing.Size(88, 20);
            this.dtpCreateDate.TabIndex = 5;
            // 
            // dtpCreateTime
            // 
            this.dtpCreateTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.dtpCreateTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpCreateTime.Location = new System.Drawing.Point(521, 49);
            this.dtpCreateTime.Name = "dtpCreateTime";
            this.dtpCreateTime.Size = new System.Drawing.Size(99, 20);
            this.dtpCreateTime.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(364, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Create";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(364, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Modified";
            // 
            // dtpModifiedTime
            // 
            this.dtpModifiedTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.dtpModifiedTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpModifiedTime.Location = new System.Drawing.Point(521, 75);
            this.dtpModifiedTime.Name = "dtpModifiedTime";
            this.dtpModifiedTime.Size = new System.Drawing.Size(99, 20);
            this.dtpModifiedTime.TabIndex = 11;
            // 
            // dtpModifiedDate
            // 
            this.dtpModifiedDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.dtpModifiedDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpModifiedDate.Location = new System.Drawing.Point(427, 75);
            this.dtpModifiedDate.Name = "dtpModifiedDate";
            this.dtpModifiedDate.Size = new System.Drawing.Size(88, 20);
            this.dtpModifiedDate.TabIndex = 10;
            // 
            // lblMsg
            // 
            this.lblMsg.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblMsg.AutoSize = true;
            this.lblMsg.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMsg.ForeColor = System.Drawing.Color.Brown;
            this.lblMsg.Location = new System.Drawing.Point(379, 101);
            this.lblMsg.Name = "lblMsg";
            this.lblMsg.Size = new System.Drawing.Size(0, 15);
            this.lblMsg.TabIndex = 13;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(481, 44);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(87, 24);
            this.btnRefresh.TabIndex = 14;
            this.btnRefresh.Text = "Load";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnSetDirectory
            // 
            this.btnSetDirectory.Location = new System.Drawing.Point(439, 43);
            this.btnSetDirectory.Name = "btnSetDirectory";
            this.btnSetDirectory.Size = new System.Drawing.Size(36, 23);
            this.btnSetDirectory.TabIndex = 15;
            this.btnSetDirectory.Text = "...";
            this.btnSetDirectory.UseVisualStyleBackColor = true;
            this.btnSetDirectory.Click += new System.EventHandler(this.btnSetDirectory_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Size Bytes";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Size MB";
            // 
            // txtSizeBytes
            // 
            this.txtSizeBytes.Location = new System.Drawing.Point(95, 46);
            this.txtSizeBytes.Name = "txtSizeBytes";
            this.txtSizeBytes.ReadOnly = true;
            this.txtSizeBytes.Size = new System.Drawing.Size(84, 20);
            this.txtSizeBytes.TabIndex = 18;
            // 
            // txtSizeMB
            // 
            this.txtSizeMB.Location = new System.Drawing.Point(95, 71);
            this.txtSizeMB.Name = "txtSizeMB";
            this.txtSizeMB.ReadOnly = true;
            this.txtSizeMB.Size = new System.Drawing.Size(84, 20);
            this.txtSizeMB.TabIndex = 19;
            // 
            // btnExport
            // 
            this.btnExport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExport.ImageIndex = 0;
            this.btnExport.Location = new System.Drawing.Point(13, 74);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(96, 23);
            this.btnExport.TabIndex = 20;
            this.btnExport.Text = "Export csv";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtFileName);
            this.groupBox1.Controls.Add(this.lblPropertyName);
            this.groupBox1.Controls.Add(this.txtSizeMB);
            this.groupBox1.Controls.Add(this.txtSizeBytes);
            this.groupBox1.Controls.Add(this.lblMsg);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.dtpCreateTime);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.dtpCreateDate);
            this.groupBox1.Controls.Add(this.btnChange);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dtpModifiedDate);
            this.groupBox1.Controls.Add(this.dtpModifiedTime);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(12, 325);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(707, 124);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Properties";
            // 
            // txtFileName
            // 
            this.txtFileName.Location = new System.Drawing.Point(95, 19);
            this.txtFileName.Name = "txtFileName";
            this.txtFileName.ReadOnly = true;
            this.txtFileName.Size = new System.Drawing.Size(606, 20);
            this.txtFileName.TabIndex = 21;
            // 
            // lblPropertyName
            // 
            this.lblPropertyName.AutoSize = true;
            this.lblPropertyName.Location = new System.Drawing.Point(12, 22);
            this.lblPropertyName.Name = "lblPropertyName";
            this.lblPropertyName.Size = new System.Drawing.Size(57, 13);
            this.lblPropertyName.TabIndex = 20;
            this.lblPropertyName.Text = "File Name:";
            // 
            // chlType
            // 
            this.chlType.Text = "Type";
            // 
            // wfrmChange
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 455);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.btnSetDirectory);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.txtDirectory);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbwLista);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "wfrmChange";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "File Information";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lbwLista;
        private System.Windows.Forms.Button btnChange;
        private System.Windows.Forms.ColumnHeader chlName;
        private System.Windows.Forms.ColumnHeader chlDate;
        private System.Windows.Forms.ColumnHeader chlSize;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openDirecotryToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDirectory;
        private System.Windows.Forms.DateTimePicker dtpCreateDate;
        private System.Windows.Forms.DateTimePicker dtpCreateTime;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpModifiedTime;
        private System.Windows.Forms.DateTimePicker dtpModifiedDate;
        private System.Windows.Forms.Label lblMsg;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.ToolStripMenuItem opcionesToolStripMenuItem;
        private System.Windows.Forms.ColumnHeader chlSizeKb;
        private System.Windows.Forms.ToolStripMenuItem replaceDateToolStripMenuItem;
        private System.Windows.Forms.Button btnSetDirectory;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSizeBytes;
        private System.Windows.Forms.TextBox txtSizeMB;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtFileName;
        private System.Windows.Forms.Label lblPropertyName;
        private System.Windows.Forms.ColumnHeader chlType;
    }
}

