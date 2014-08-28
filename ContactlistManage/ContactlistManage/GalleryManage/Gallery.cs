using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
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

        /// <summary>
        /// 控制删除按钮显示隐藏
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            MIDeletePhoto.Visible = true;
            if (listView1.SelectedItems.Count == 0)
            {
                MIDeletePhoto.Visible = false;
            }
        }

        /// <summary>
        /// 添加照片
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MIAddPhoto_Click(object sender, EventArgs e)
        {
            var openFileDialog = new OpenFileDialog { Filter = "图片|*.jpg;*.png;", Multiselect = true };
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                if (openFileDialog.FileNames.Any())
                {
                    foreach (var fileName in openFileDialog.FileNames)
                    {
                        if (BLLOperate.IsExistGalleryName(0, GlobalData.Current.CurrentUser.Id, Path.GetFileName(fileName)))
                        {
                            continue;
                        }
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
            }
        }

        /// <summary>
        /// 删除照片
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MIDeletePhoto_Click(object sender, EventArgs e)
        {
            HandleData(() =>
            {
                foreach (ListViewItem item in listView1.SelectedItems)
                {
                    var gallery = item.Tag as TB_Gallery;
                    BLLOperate.DeleteItem<TB_Gallery>(gallery.Id);
                    listView1.Items.Remove(listView1.SelectedItems[0]);
                }

            }, s => MessageBox.Show(this, s));
        }
    }
}
