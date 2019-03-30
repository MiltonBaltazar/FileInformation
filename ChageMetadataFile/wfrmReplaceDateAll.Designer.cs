namespace ChageMetadataFile
{
    partial class wfrmReplaceDateAll
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
            this.btnReplace = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpModifiedTime = new System.Windows.Forms.DateTimePicker();
            this.dtpModifiedDate = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpCreateTime = new System.Windows.Forms.DateTimePicker();
            this.dtpCreateDate = new System.Windows.Forms.DateTimePicker();
            this.chkDirectory = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // btnReplace
            // 
            this.btnReplace.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReplace.Location = new System.Drawing.Point(182, 82);
            this.btnReplace.Name = "btnReplace";
            this.btnReplace.Size = new System.Drawing.Size(87, 32);
            this.btnReplace.TabIndex = 11;
            this.btnReplace.Text = "Replace";
            this.btnReplace.UseVisualStyleBackColor = true;
            this.btnReplace.Click += new System.EventHandler(this.btnReplace_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Modified";
            // 
            // dtpModifiedTime
            // 
            this.dtpModifiedTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpModifiedTime.Location = new System.Drawing.Point(170, 47);
            this.dtpModifiedTime.Name = "dtpModifiedTime";
            this.dtpModifiedTime.Size = new System.Drawing.Size(99, 20);
            this.dtpModifiedTime.TabIndex = 17;
            // 
            // dtpModifiedDate
            // 
            this.dtpModifiedDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpModifiedDate.Location = new System.Drawing.Point(76, 47);
            this.dtpModifiedDate.Name = "dtpModifiedDate";
            this.dtpModifiedDate.Size = new System.Drawing.Size(88, 20);
            this.dtpModifiedDate.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Create";
            // 
            // dtpCreateTime
            // 
            this.dtpCreateTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpCreateTime.Location = new System.Drawing.Point(170, 21);
            this.dtpCreateTime.Name = "dtpCreateTime";
            this.dtpCreateTime.Size = new System.Drawing.Size(99, 20);
            this.dtpCreateTime.TabIndex = 14;
            // 
            // dtpCreateDate
            // 
            this.dtpCreateDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpCreateDate.Location = new System.Drawing.Point(76, 21);
            this.dtpCreateDate.Name = "dtpCreateDate";
            this.dtpCreateDate.Size = new System.Drawing.Size(88, 20);
            this.dtpCreateDate.TabIndex = 13;
            // 
            // chkDirectory
            // 
            this.chkDirectory.AutoSize = true;
            this.chkDirectory.Location = new System.Drawing.Point(16, 82);
            this.chkDirectory.Name = "chkDirectory";
            this.chkDirectory.Size = new System.Drawing.Size(135, 17);
            this.chkDirectory.TabIndex = 19;
            this.chkDirectory.Text = "Aplicar a subdirectorios";
            this.chkDirectory.UseVisualStyleBackColor = true;
            // 
            // wfrmReplaceDateAll
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(285, 131);
            this.Controls.Add(this.chkDirectory);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtpModifiedTime);
            this.Controls.Add(this.dtpModifiedDate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtpCreateTime);
            this.Controls.Add(this.dtpCreateDate);
            this.Controls.Add(this.btnReplace);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "wfrmReplaceDateAll";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Replace All";
            this.Load += new System.EventHandler(this.ReplaceDateAll_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnReplace;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpModifiedTime;
        private System.Windows.Forms.DateTimePicker dtpModifiedDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpCreateTime;
        private System.Windows.Forms.DateTimePicker dtpCreateDate;
        private System.Windows.Forms.CheckBox chkDirectory;
    }
}