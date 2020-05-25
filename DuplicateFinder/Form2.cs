using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.WindowsAPICodePack.Shell;

namespace DuplicateFinder
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        public Form2(IEnumerable<IGrouping<string, KeyValuePair<string, string>>> fileList)
        {

            InitializeComponent();
            int i = 1;
            listViewFiles.Columns.Add("Filename").Width = listViewFiles.Width - 300;
            listViewFiles.Columns.Add("Created On").Width = 200;
            listViewFiles.Columns.Add("Size (KB)").Width = 100;

            foreach (var x in fileList.Select(k => k.Key))
            {

                var key = fileList.Where(k => k.Key == x).First();
                var files = key.Select(k => k.Key);

                listViewFiles.Groups.Add(i.ToString(), i.ToString());
                
                foreach (string f in files)
                {
                    var item = new ListViewItem()
                    {
                        Group = listViewFiles.Groups[i.ToString()],
                        Text = f
                    };
                    item.SubItems.Add(File.GetCreationTime(f).ToString());
                    item.SubItems.Add((new FileInfo(f).Length / 1024).ToString());
                    listViewFiles.Items.Add(item);
                }
                listViewFiles.MultiSelect = true;
                listViewFiles.View = View.Details;

          
             
                i++;
            }
            listViewFiles.Sorting = SortOrder.Descending;
            listViewFiles.Sort();

        }

        private void listViewFiles_ItemActivate(object sender, EventArgs e)
        {
        }

        private void listViewFiles_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (listViewFiles.FocusedItem == null)
            {
                return;
            }
            string s = listViewFiles.FocusedItem.Text;
            if (File.Exists(s))
            {
            ShellFile shellFile = ShellFile.FromFilePath(s);
            Bitmap shellThumb = shellFile.Thumbnail.LargeBitmap;
            pictureBoxThumbnail.Image = shellThumb;
        }
    }

        private void btnKeepNewest_Click(object sender, EventArgs e)
        {
        
            ListView.ListViewItemCollection thisgroup = listViewFiles.FocusedItem.Group.Items;
            var groupitem = listViewFiles.FocusedItem.Group;
            int idx = thisgroup.Count;
            List<FileItem> itemList = new List<FileItem>();
            foreach (ListViewItem x in thisgroup)
            {
                itemList.Add(new FileItem()
                {
                    filePath = x.SubItems[0].Text,
                    createdOn = DateTime.Parse(x.SubItems[1].Text)
                });

            }

            var orderedList = itemList.OrderByDescending(o => o.createdOn).Select(s => s.filePath).ToArray();
            for (int i = 1; i < orderedList.Count(); i++)
            {
                File.Delete(orderedList[i]);
            }

            //listViewFiles.Groups.Remove(groupitem);
            for (int i = 0; i < idx; i++)
            {
                groupitem.Items[0].Remove();
            }

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (listViewFiles.FocusedItem == null)
            {
                return;
            }
            string s = listViewFiles.FocusedItem.Text;
            int newIdx = listViewFiles.FocusedItem.Index;
            //delete the file from disk - then remove the item. 
            try
            {
                File.Delete(s);
                listViewFiles.FocusedItem.Remove();
                listViewFiles.Items[newIdx].Focused = true;
              
            }
            catch (Exception ex)
            {
                //TODO Error handling
                MessageBox.Show("Failed to Delete File");
            }

        }

        private void btnIgnore_Click(object sender, EventArgs e)
        {
            var itemsRem = listViewFiles.FocusedItem.Group.Items.Count;
            for(int i=0; i<itemsRem; i++)
            {
                listViewFiles.FocusedItem.Group.Items[0].Remove();
            }
        }

        private void btnKeepNewestAllGroups_Click(object sender, EventArgs e)
        {
            var x = MessageBox.Show(
                String.Format("This will keep only the newest file for each of the {0} groups found. Are you sure?",
                    listViewFiles.Groups.Count), "Proceed?", MessageBoxButtons.YesNo);

            if (x == DialogResult.Yes)
            {
                int fileCount =0;
                long fileSize =0;
                int deleteFails =0;

                foreach (ListViewGroup group in listViewFiles.Groups)
                {
                    ListView.ListViewItemCollection thisgroup = group.Items;
                   // var groupitem = listViewFiles.FocusedItem.Group;
                    int idx = thisgroup.Count;
                    List<FileItem> itemList = new List<FileItem>();
                    foreach (ListViewItem li in thisgroup)
                    {
                        itemList.Add(new FileItem()
                        {
                            filePath = li.SubItems[0].Text,
                            createdOn = DateTime.Parse(li.SubItems[1].Text)
                        });

                    }

                    var orderedList = itemList.OrderByDescending(o => o.createdOn).Select(s => s.filePath).ToArray();
                    for (int i = 1; i < orderedList.Count(); i++)
                    {
                        try
                        {
                            fileSize = fileSize + (new FileInfo(orderedList[i]).Length) / 1024;
                            File.Delete(orderedList[i]);
                            fileCount++;
                        }
                        catch (Exception ex)
                        {
                            deleteFails++;
                        }
                    }

                    //listViewFiles.Groups.Remove(groupitem);
                    //for (int i = 0; i < idx; i++)
                    //{
                    //    group.Items[0].Remove();
                    //}

                }

                listViewFiles.Items.Clear();
                string fileSizeText;
                if (fileSize > 1024)
                {
                    fileSizeText = String.Format(fileSize / 1024 + "MB");
                }
                else
                {
                    fileSizeText = String.Format(fileSize + "KB");
                }
                if (deleteFails == 0)
                {
                    MessageBox.Show(String.Format("{0} Files Deleted. {1} Space cleared.", fileCount, fileSizeText));
                }
                else
                {
                    MessageBox.Show(String.Format("{0} Files Deleted. {1} Space cleared. {2} files could not be deleted", fileCount, fileSizeText, deleteFails));
                }
            }
            else
            {
                return;
            }
        }
    }
}
