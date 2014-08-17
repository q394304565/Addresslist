using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Infrastructure;
using Model;

namespace ContactlistManage.GalleryManage
{
    public partial class Gallery : FormBase
    {
        public Gallery()
        {
            InitializeComponent();
        }

        public TB_Gallery Photo { get { return listView1.SelectedItems.Count > 0 ? listView1.SelectedItems[0].Tag as TB_Gallery : null; } }

        private void Gallery_Load(object sender, EventArgs e)
        {
            if (IsLoaded) return;
            IsLoaded = true;
            GetGallery(listView1);
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            MIDeletePhoto.Enabled = true;
            if (listView1.SelectedItems.Count == 0 || listView1.SelectedItems.Count > 1)
            {
                MIDeletePhoto.Enabled = false;
            }
        }

        /// <summary>
        /// 添加照片
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MIAddPhoto_Click(object sender, EventArgs e)
        {
            var openFileDialog = new OpenFileDialog { Filter = "图片|*.jpg;*.png;" };
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                var fileName = openFileDialog.FileName;
                using (var fs = new FileStream(fileName, FileMode.Open))
                {
                    var image = new byte[fs.Length];
                    fs.Read(image, 0, (int)fs.Length);
                    if (image.Length != 0)
                    {
                        HandleData(() =>
                        {
                            var photo = new TB_Gallery()
                            {
                                UId = GlobalData.Current.CurrentUser.Id,
                                Name = Path.GetFileName(fileName),
                                GImage = image
                            };
                            BLLOperate.AddOrModifyItem<TB_Gallery>(photo);
                            var myImage = Image.FromStream(fs);
                            listView1.BeginUpdate();
                            listView1.LargeImageList.Images.Add(myImage);
                            listView1.Items.Add(photo.Name, listView1.LargeImageList.Images.Count - 1).Tag = photo;
                            listView1.EndUpdate();
                        }, s => MessageBox.Show(this, s));
                    }
                }
            }
        }

        private void MIDeletePhoto_Click(object sender, EventArgs e)
        {
            var gallery = listView1.SelectedItems[0].Tag as TB_Gallery;
            HandleData(() =>
            {
                BLLOperate.DeleteItem<TB_Gallery>(gallery.Id);
                listView1.Items.Remove(listView1.SelectedItems[0]);
            }, s => MessageBox.Show(this, s));
        }
    }
}
