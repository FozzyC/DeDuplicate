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
            this.SuspendLayout();
            // 
            // lblFolder
            // 
            this.lblFolder.AutoSize = true;
            this.lblFolder.Location = new System.Drawing.Point(29, 37);
            this.lblFolder.Name = "lblFolder";
            this.lblFolder.Size = new System.Drawing.Size(113, 20);
            this.lblFolder.TabIndex = 0;
            this.lblFolder.Text = "Search Folder:";
            // 
            // folderBrowserDialog1
            // 
            this.folderBrowserDialog1.HelpRequest += new System.EventHandler(this.folderBrowserDialog1_HelpRequest);
            // 
            // txtFolder
            // 
            this.txtFolder.Location = new System.Drawing.Point(149, 37);
            this.txtFolder.Name = "txtFolder";
            this.txtFolder.Size = new System.Drawing.Size(313, 26);
            this.txtFolder.TabIndex = 1;
            this.txtFolder.Text = "C:\\TemporaryCF";
            this.txtFolder.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBox1_MouseClick);
            this.txtFolder.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lblSubfolders
            // 
            this.lblSubfolders.AutoSize = true;
            this.lblSubfolders.Location = new System.Drawing.Point(284, 102);
            this.lblSubfolders.Name = "lblSubfolders";
            this.lblSubfolders.Size = new System.Drawing.Size(150, 20);
            this.lblSubfolders.TabIndex = 2;
            this.lblSubfolders.Text = "Search Subfolders?";
            // 
            // chkSubfolders
            // 
            this.chkSubfolders.AutoSize = true;
            this.chkSubfolders.Location = new System.Drawing.Point(440, 103);
            this.chkSubfolders.Name = "chkSubfolders";
            this.chkSubfolders.Size = new System.Drawing.Size(22, 21);
            this.chkSubfolders.TabIndex = 3;
            this.chkSubfolders.UseVisualStyleBackColor = true;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(367, 142);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(95, 35);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lblSearchMethod
            // 
            this.lblSearchMethod.AutoSize = true;
            this.lblSearchMethod.Location = new System.Drawing.Point(20, 69);
            this.lblSearchMethod.Name = "lblSearchMethod";
            this.lblSearchMethod.Size = new System.Drawing.Size(122, 20);
            this.lblSearchMethod.TabIndex = 5;
            this.lblSearchMethod.Text = "Search Method:";
            // 
            // cmbSearchMethod
            // 
            this.cmbSearchMethod.FormattingEnabled = true;
            this.cmbSearchMethod.Location = new System.Drawing.Point(149, 69);
            this.cmbSearchMethod.Name = "cmbSearchMethod";
            this.cmbSearchMethod.Size = new System.Drawing.Size(313, 28);
            this.cmbSearchMethod.TabIndex = 6;
            this.cmbSearchMethod.SelectedIndexChanged += new System.EventHandler(this.cmbSearchMethod_SelectedIndexChanged);
            // 
            // btnSelectFolder
            // 
            this.btnSelectFolder.Location = new System.Drawing.Point(469, 37);
            this.btnSelectFolder.Name = "btnSelectFolder";
            this.btnSelectFolder.Size = new System.Drawing.Size(47, 26);
            this.btnSelectFolder.TabIndex = 7;
            this.btnSelectFolder.Text = "...";
            this.btnSelectFolder.UseVisualStyleBackColor = true;
            this.btnSelectFolder.Click += new System.EventHandler(this.btnSelectFolder_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 228);
            this.Controls.Add(this.btnSelectFolder);
            this.Controls.Add(this.cmbSearchMethod);
            this.Controls.Add(this.lblSearchMethod);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.chkSubfolders);
            this.Controls.Add(this.lblSubfolders);
            this.Controls.Add(this.txtFolder);
            this.Controls.Add(this.lblFolder);
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
    }
}

