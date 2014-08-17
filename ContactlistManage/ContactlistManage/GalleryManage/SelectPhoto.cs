using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Infrastructure;
using Model;

namespace ContactlistManage.GalleryManage
{
    public partial class SelectPhoto : FormBase
    {
        public SelectPhoto()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        public TB_Gallery Photo { get { return listView1.SelectedItems.Count > 0 ? listView1.SelectedItems[0].Tag as TB_Gallery : null; } }

        private void SelectPhoto_Load(object sender, EventArgs e)
        {
            if (IsLoaded) return;
            IsLoaded = true;
            GetGallery(listView1);
        }

        public bool ThumbnailCallback() { return false; }
    }
}
