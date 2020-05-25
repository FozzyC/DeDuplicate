namespace DuplicateFinder
{
    partial class Form2
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnKeepNewest = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnIgnore = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.listViewFiles = new System.Windows.Forms.ListView();
            this.pictureBoxThumbnail = new System.Windows.Forms.PictureBox();
            this.btnKeepNewestAllGroups = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxThumbnail)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnKeepNewestAllGroups);
            this.panel1.Controls.Add(this.btnKeepNewest);
            this.panel1.Controls.Add(this.btnBack);
            this.panel1.Controls.Add(this.btnIgnore);
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Location = new System.Drawing.Point(1108, 597);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(498, 345);
            this.panel1.TabIndex = 1;
            // 
            // btnKeepNewest
            // 
            this.btnKeepNewest.Location = new System.Drawing.Point(0, 122);
            this.btnKeepNewest.Name = "btnKeepNewest";
            this.btnKeepNewest.Size = new System.Drawing.Size(137, 94);
            this.btnKeepNewest.TabIndex = 3;
            this.btnKeepNewest.Text = "Keep Newest In Selected";
            this.btnKeepNewest.UseVisualStyleBackColor = true;
            this.btnKeepNewest.Click += new System.EventHandler(this.btnKeepNewest_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(361, 251);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(137, 94);
            this.btnBack.TabIndex = 2;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnIgnore
            // 
            this.btnIgnore.Location = new System.Drawing.Point(190, 248);
            this.btnIgnore.Name = "btnIgnore";
            this.btnIgnore.Size = new System.Drawing.Size(137, 94);
            this.btnIgnore.TabIndex = 1;
            this.btnIgnore.Text = "Ignore Group";
            this.btnIgnore.UseVisualStyleBackColor = true;
            this.btnIgnore.Click += new System.EventHandler(this.btnIgnore_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(3, 3);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(137, 94);
            this.btnDelete.TabIndex = 0;
            this.btnDelete.Text = "Delete Selected";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // listViewFiles
            // 
            this.listViewFiles.Location = new System.Drawing.Point(12, 27);
            this.listViewFiles.Name = "listViewFiles";
            this.listViewFiles.Size = new System.Drawing.Size(1066, 864);
            this.listViewFiles.TabIndex = 2;
            this.listViewFiles.UseCompatibleStateImageBehavior = false;
            this.listViewFiles.ItemActivate += new System.EventHandler(this.listViewFiles_ItemActivate);
            this.listViewFiles.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.listViewFiles_ItemSelectionChanged);
            // 
            // pictureBoxThumbnail
            // 
            this.pictureBoxThumbnail.Location = new System.Drawing.Point(1108, 27);
            this.pictureBoxThumbnail.Name = "pictureBoxThumbnail";
            this.pictureBoxThumbnail.Size = new System.Drawing.Size(459, 367);
            this.pictureBoxThumbnail.TabIndex = 3;
            this.pictureBoxThumbnail.TabStop = false;
            // 
            // btnKeepNewestAllGroups
            // 
            this.btnKeepNewestAllGroups.Location = new System.Drawing.Point(3, 248);
            this.btnKeepNewestAllGroups.Name = "btnKeepNewestAllGroups";
            this.btnKeepNewestAllGroups.Size = new System.Drawing.Size(137, 94);
            this.btnKeepNewestAllGroups.TabIndex = 4;
            this.btnKeepNewestAllGroups.Text = "Keep Newest In All Groups";
            this.btnKeepNewestAllGroups.UseVisualStyleBackColor = true;
            this.btnKeepNewestAllGroups.Click += new System.EventHandler(this.btnKeepNewestAllGroups_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1618, 954);
            this.Controls.Add(this.pictureBoxThumbnail);
            this.Controls.Add(this.listViewFiles);
            this.Controls.Add(this.panel1);
            this.Name = "Form2";
            this.Text = "Review Duplicates";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxThumbnail)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnIgnore;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.ListView listViewFiles;
        private System.Windows.Forms.PictureBox pictureBoxThumbnail;
        private System.Windows.Forms.Button btnKeepNewest;
        private System.Windows.Forms.Button btnKeepNewestAllGroups;
    }
}