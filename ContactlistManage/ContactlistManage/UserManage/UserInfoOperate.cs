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

namespace ContactlistManage.UserManage
{
    public partial class UserInfoOperate : FormBase
    {
        public UserInfoOperate()
        {
            InitializeComponent();
        }

        private void UserInfoOprate_Load(object sender, EventArgs e)
        {
            if (IsLoaded) return;
            IsLoaded = true;
            var user = GlobalData.Current.CurrentUser;
            userInfo.TxtName.Text = user.Name;
            userInfo.TxtEmail.Text = user.Email;
            userInfo.TxtAddress.Text = user.Address;
            userInfo.TxtCallPhone.Text = user.Callphone;
            userInfo.TxtTelephone.Text = user.Telephone;
            userInfo.DtBirthday.Text = string.IsNullOrEmpty(user.Birthday) ? DateTime.Now.Date.ToShortDateString() : user.Birthday;
            if (user.Favicon != null)
            {
                using (var myStream = new MemoryStream())
                {
                    foreach (byte a in user.Favicon)
                    {
                        myStream.WriteByte(a);
                    }
                    var myImage = Image.FromStream(myStream);
                    myStream.Close();
                    userInfo.PbFavicon.Image = myImage;
                }
            }
            userInfo.CbSex.SelectedValue = user.Sex;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (VerifyRequired(userInfo.TxtName, lbMessage, "名称"))
            {
                return;
            }
            HandleData(() =>
            {
                var user = new TB_User
                    {
                        Id = GlobalData.Current.CurrentUser.Id,
                        UName = GlobalData.Current.CurrentUser.UName,
                        Password = GlobalData.Current.CurrentUser.Password,
                        UType = GlobalData.Current.CurrentUser.UType,
                        Name = userInfo.TxtName.Text,
                        Email = userInfo.TxtEmail.Text,
                        Address = userInfo.TxtAddress.Text,
                        Callphone = userInfo.TxtCallPhone.Text,
                        Telephone = userInfo.TxtTelephone.Text,
                        Birthday = userInfo.DtBirthday.Text,
                        Sex = (int)userInfo.CbSex.SelectedValue,
                        Favicon = userInfo.ImageData
                    };
                user.Id = BLLOperate.AddOrModifyItem<TB_User>(user);
                GlobalData.Current.CurrentUser = user;
                DialogResult = DialogResult.OK;
                Close();
            }, (s) =>
            {
                lbMessage.ForeColor = Color.Red;
                lbMessage.Text = "操作失败";
            });
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
