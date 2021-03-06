﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DuplicateFinder
{
    public partial class Main : Form
    {
        List<string> listSearchMethod = new List<string>() {"Filename","Content"};
        List<string> imageExtensions = new List<string>() {".JPG",".JPEG",".PNG","NEF","RAW"};

        public Main()
        {
            InitializeComponent();
            txtFolder.Text = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
            cmbSearchMethod.DataSource = listSearchMethod;
            cmbSearchMethod.SelectedIndex = 1;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox1_MouseClick(object sender, MouseEventArgs e)
        {
        }

        private void btnSelectFolder_Click(object sender, EventArgs e)
        {
            //bring up folder search dialog.
            folderBrowserDialog1.SelectedPath = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures); ;
            folderBrowserDialog1.ShowDialog();
            txtFolder.Text = folderBrowserDialog1.SelectedPath;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            //Check folder is selected
            if (txtFolder.Text == null || !Directory.Exists(txtFolder.Text))
            {
                MessageBox.Show("Invalid Folder Selected");
                return;
            }

            

            SearchOption opt = SearchOption.TopDirectoryOnly;
            if (chkSubfolders.Checked) { opt = SearchOption.AllDirectories;}
            List<string> fileList = Directory.GetFiles(txtFolder.Text, "*.*", opt).ToList();

            Dictionary<string, string> fileDictionary =new Dictionary<string, string>();

            /*Set up the Progress Bar*/
           
            progressBar1.Visible = true;
            progressBar1.Minimum = 1;
            progressBar1.Maximum = fileList.Count;
            progressBar1.Value = 1;
            progressBar1.Step = 1;



            if (cmbSearchMethod.Text == "Content")
            {
                foreach (var f in fileList)
                {
                    if (chkEXIF.Checked && imageExtensions.Contains(Path.GetExtension(f).ToUpper()))
                    {
                        try
                        {
                            //convert to bitmap to remove EXIF data. 
                            Bitmap bmp = (Bitmap)Image.FromFile(f);
                            byte[] hash;

                            using (MemoryStream ms = new MemoryStream())
                            {
                                bmp.Save(ms, ImageFormat.Bmp);
                                using (var md5 = MD5.Create())

                                    hash = md5.ComputeHash(ms);

                                fileDictionary.Add(f, System.Text.Encoding.Default.GetString(hash));
                                progressBar1.PerformStep();
                            }
                        }
                        catch
                        {
                            //TODO Logging
                        }
                    }
                    else
                        try
                        {
                            {
                       
                            //Hash the file and store to dict
                            byte[] hash;
                            using (var md5 = MD5.Create())
                            using (var stream = File.OpenRead(f))
                                hash = md5.ComputeHash(stream);

                            fileDictionary.Add(f, System.Text.Encoding.Default.GetString(hash));
                            progressBar1.PerformStep();
                        }
                        }
                    catch
                    {
                            //TODO Logging
                        }
                }
            }
            else if(cmbSearchMethod.Text == "Filename")
            {
                foreach (var f in fileList)
                {              
                    fileDictionary.Add(f, Path.GetFileName(f));
                }
            }
            // all files hashed, compare the hashes to find duplicates and report back the duplicate filenames. 
            IEnumerable<IGrouping<string, KeyValuePair<string,string>>> y = fileDictionary.GroupBy(x => x.Value).Where(x => x.Count() > 1);
            // now I have a list of hashes that definitely have dupes - but they need grouping further (to link them together) 

            if (y.Count() == 0)
            {
                MessageBox.Show("No Duplicates Found");
                return;
            }

                Form2 frmForm2 = new Form2(y);
                frmForm2.FormClosed += new FormClosedEventHandler(frmForm2_FormClosed);
                frmForm2.Show();
                this.Hide();
                progressBar1.Hide();

        }

        void frmForm2_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }

        private void folderBrowserDialog1_HelpRequest(object sender, EventArgs e)
        {

        }

        private void cmbSearchMethod_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbSearchMethod.Text == "Filename")
            {
                chkSubfolders.Checked = true;
                chkSubfolders.Enabled = false;
            }
            else
            {
                chkSubfolders.Enabled = true;
            }
        }
    }
}
