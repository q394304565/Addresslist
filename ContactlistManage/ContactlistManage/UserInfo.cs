using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Windows.Forms;
using ContactlistManage.GalleryManage;
using Infrastructure;

namespace ContactlistManage
{
    public partial class UserInfo : UserControl
    {
        public UserInfo()
        {
            InitializeComponent();
            var sexs = new List<EnumerationModel>();
            foreach (var value in Enum.GetValues(typeof(SexType)))
            {
                var fi = typeof(SexType).GetField(value.ToString());
                if (fi != null)
                {
                    var arr = fi.GetCustomAttributes(typeof(DescriptionAttribute), true) as DescriptionAttribute[];
                    if (arr.Length > 0) sexs.Add(new EnumerationModel { Key = (int)value, Value = arr[0].Description });
                }
            }
            CbSex.DataSource = sexs;
            cbSex.DisplayMember = "Value";
            cbSex.ValueMember = "Key";
            dtBirthday.CustomFormat = "yyyy-MM-dd";
            pbFavicon.SizeMode = PictureBoxSizeMode.Zoom;
            var addPMenu = new ContextMenu();
            addPMenu.MenuItems.Add("从本地文件中添加", AddLocalPhoto);
            addPMenu.MenuItems.Add("从相册中添加", AddGalleryPhoto);
            pbFavicon.ContextMenu = addPMenu;
        }

        /// <summary>
        /// 添加本地图片
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddLocalPhoto(object sender, EventArgs e)
        {
            var openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog(this) == System.Windows.Forms.DialogResult.OK)
            {
                var fileName = openFileDialog.FileName;
                using (var fs = new FileStream(fileName, FileMode.Open))
                {
                    var image = new byte[fs.Length];
                    fs.Read(image, 0, (int)fs.Length);
                    ImageData = image;
                    using (var myStream = new MemoryStream())
                    {
                        foreach (byte a in image)
                        {
                            myStream.WriteByte(a);
                        }
                        var myImage = Image.FromStream(myStream);
                        myStream.Close();
                        pbFavicon.Image = myImage;
                    }
                }
            }
        }

        /// <summary>
        /// 添加相册照片
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddGalleryPhoto(object sender, EventArgs e)
        {
            var g = new Gallery();
            g.HideMenu();
            g.ShowDialog(this);
            if (g.Photo != null)
            {
                ImageData = g.Photo.GImage;
                using (var myStream = new MemoryStream())
                {
                    foreach (byte a in g.Photo.GImage)
                    {
                        myStream.WriteByte(a);
                    }
                    var myImage = Image.FromStream(myStream);
                    myStream.Close();
                    pbFavicon.Image = myImage;
                }
            }
        }

        public TextBox TxtName
        {
            get { return txtName; }
        }

        public TextBox TxtAddress
        {
            get { return txtAddress; }
        }

        public TextBox TxtEmail
        {
            get { return txtEmail; }
        }

        public ComboBox CbSex
        {
            get { return cbSex; }
        }

        public MaskedTextBox TxtTelephone
        {
            get { return txtTelephone; }
        }

        public MaskedTextBox TxtCallPhone
        {
            get { return txtCallPhone; }
        }

        public DateTimePicker DtBirthday
        {
            get { return dtBirthday; }
        }

        public PictureBox PbFavicon
        {
            get { return pbFavicon; }
        }

        public byte[] ImageData { get; set; }
    }
}
