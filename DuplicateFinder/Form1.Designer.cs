namespace DuplicateFinder
{
    partial class Main
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
            this.lblFolder = new System.Windows.Forms.Label();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.txtFolder = new System.Windows.Forms.TextBox();
            this.lblSubfolders = new System.Windows.Forms.Label();
            this.chkSubfolders = new System.Windows.Forms.CheckBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lblSearchMethod = new System.Windows.Forms.Label();
            this.cmbSearchMethod = new System.Windows.Forms.ComboBox();
            this.btnSelectFolder = new System.Windows.Forms.Button();
            this.chkEXIF = new System.Windows.Forms.CheckBox();
            this.lblEXIF = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // lblFolder
            // 
            this.lblFolder.AutoSize = true;
            this.lblFolder.Location = new System.Drawing.Point(19, 24);
            this.lblFolder.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFolder.Name = "lblFolder";
            this.lblFolder.Size = new System.Drawing.Size(76, 13);
            this.lblFolder.TabIndex = 0;
            this.lblFolder.Text = "Search Folder:";
            // 
            // folderBrowserDialog1
            // 
            this.folderBrowserDialog1.HelpRequest += new System.EventHandler(this.folderBrowserDialog1_HelpRequest);
            // 
            // txtFolder
            // 
            this.txtFolder.Location = new System.Drawing.Point(99, 24);
            this.txtFolder.Margin = new System.Windows.Forms.Padding(2);
            this.txtFolder.Name = "txtFolder";
            this.txtFolder.Size = new System.Drawing.Size(210, 20);
            this.txtFolder.TabIndex = 1;
            this.txtFolder.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBox1_MouseClick);
            this.txtFolder.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lblSubfolders
            // 
            this.lblSubfolders.AutoSize = true;
            this.lblSubfolders.Location = new System.Drawing.Point(189, 66);
            this.lblSubfolders.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSubfolders.Name = "lblSubfolders";
            this.lblSubfolders.Size = new System.Drawing.Size(94, 13);
            this.lblSubfolders.TabIndex = 2;
            this.lblSubfolders.Text = "Search Subfolders";
            // 
            // chkSubfolders
            // 
            this.chkSubfolders.AutoSize = true;
            this.chkSubfolders.Location = new System.Drawing.Point(293, 67);
            this.chkSubfolders.Margin = new System.Windows.Forms.Padding(2);
            this.chkSubfolders.Name = "chkSubfolders";
            this.chkSubfolders.Size = new System.Drawing.Size(15, 14);
            this.chkSubfolders.TabIndex = 3;
            this.chkSubfolders.UseVisualStyleBackColor = true;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(248, 105);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(96, 45);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lblSearchMethod
            // 
            this.lblSearchMethod.AutoSize = true;
            this.lblSearchMethod.Location = new System.Drawing.Point(13, 45);
            this.lblSearchMethod.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSearchMethod.Name = "lblSearchMethod";
            this.lblSearchMethod.Size = new System.Drawing.Size(83, 13);
            this.lblSearchMethod.TabIndex = 5;
            this.lblSearchMethod.Text = "Search Method:";
            // 
            // cmbSearchMethod
            // 
            this.cmbSearchMethod.FormattingEnabled = true;
            this.cmbSearchMethod.Location = new System.Drawing.Point(99, 45);
            this.cmbSearchMethod.Margin = new System.Windows.Forms.Padding(2);
            this.cmbSearchMethod.Name = "cmbSearchMethod";
            this.cmbSearchMethod.Size = new System.Drawing.Size(210, 21);
            this.cmbSearchMethod.TabIndex = 6;
            this.cmbSearchMethod.SelectedIndexChanged += new System.EventHandler(this.cmbSearchMethod_SelectedIndexChanged);
            // 
            // btnSelectFolder
            // 
            this.btnSelectFolder.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelectFolder.Location = new System.Drawing.Point(313, 24);
            this.btnSelectFolder.Margin = new System.Windows.Forms.Padding(2);
            this.btnSelectFolder.Name = "btnSelectFolder";
            this.btnSelectFolder.Size = new System.Drawing.Size(31, 20);
            this.btnSelectFolder.TabIndex = 7;
            this.btnSelectFolder.Text = "...";
            this.btnSelectFolder.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSelectFolder.UseVisualStyleBackColor = true;
            this.btnSelectFolder.Click += new System.EventHandler(this.btnSelectFolder_Click);
            // 
            // chkEXIF
            // 
            this.chkEXIF.AutoSize = true;
            this.chkEXIF.Location = new System.Drawing.Point(293, 84);
            this.chkEXIF.Margin = new System.Windows.Forms.Padding(2);
            this.chkEXIF.Name = "chkEXIF";
            this.chkEXIF.Size = new System.Drawing.Size(15, 14);
            this.chkEXIF.TabIndex = 9;
            this.chkEXIF.UseVisualStyleBackColor = true;
            // 
            // lblEXIF
            // 
            this.lblEXIF.AutoSize = true;
            this.lblEXIF.Location = new System.Drawing.Point(220, 84);
            this.lblEXIF.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEXIF.Name = "lblEXIF";
            this.lblEXIF.Size = new System.Drawing.Size(63, 13);
            this.lblEXIF.TabIndex = 8;
            this.lblEXIF.Text = "Ignore EXIF";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(12, 126);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(231, 23);
            this.progressBar1.TabIndex = 10;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 161);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.chkEXIF);
            this.Controls.Add(this.lblEXIF);
            this.Controls.Add(this.btnSelectFolder);
            this.Controls.Add(this.cmbSearchMethod);
            this.Controls.Add(this.lblSearchMethod);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.chkSubfolders);
            this.Controls.Add(this.lblSubfolders);
            this.Controls.Add(this.txtFolder);
            this.Controls.Add(this.lblFolder);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Main";
            this.Text = "Duplicate Finder";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFolder;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.TextBox txtFolder;
        private System.Windows.Forms.Label lblSubfolders;
        private System.Windows.Forms.CheckBox chkSubfolders;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lblSearchMethod;
        private System.Windows.Forms.ComboBox cmbSearchMethod;
        private System.Windows.Forms.Button btnSelectFolder;
        private System.Windows.Forms.CheckBox chkEXIF;
        private System.Windows.Forms.Label lblEXIF;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}

