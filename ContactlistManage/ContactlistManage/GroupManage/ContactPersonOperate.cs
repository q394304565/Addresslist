using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BLL;
using Infrastructure;
using Model;

namespace ContactlistManage.GroupManage
{
    public partial class ContactPersonOperate : FormBase
    {
        public TB_ContactPerson ContactPerson { get; set; }
        public ContactPersonOperate()
        {
            InitializeComponent();
        }

        private void ContactPersonOperate_Load(object sender, EventArgs e)
        {
            userInfo.TxtName.Text = ContactPerson.Name;
            userInfo.TxtEmail.Text = ContactPerson.Email;
            userInfo.TxtAddress.Text = ContactPerson.Address;
            userInfo.TxtCallPhone.Text = ContactPerson.Callphone;
            userInfo.TxtTelephone.Text = ContactPerson.Telephone;
            userInfo.DtBirthday.Text = string.IsNullOrEmpty(ContactPerson.Birthday) ? DateTime.Now.Date.ToShortDateString() : ContactPerson.Birthday;
            if (ContactPerson.Favicon != null)
            {
                using (var myStream = new MemoryStream())
                {
                    foreach (byte a in ContactPerson.Favicon)
                    {
                        myStream.WriteByte(a);
                    }
                    var myImage = Image.FromStream(myStream);
                    myStream.Close();
                    userInfo.PbFavicon.Image = myImage;
                }
            }
            userInfo.CbSex.SelectedValue = ContactPerson.Sex;
            HandleData(() =>
                {
                    var contactPersonGroups = new List<TB_ContactPersonGroup>();
                    contactPersonGroups.Add(new TB_ContactPersonGroup { Id = 0, Name = "未分组" });
                    var groups = BLLOperate.GetContactPersonGroupsByUId(GlobalData.Current.CurrentUser.Id);
                    contactPersonGroups.AddRange(groups);
                    cbGroups.DataSource = contactPersonGroups;
                    cbGroups.DisplayMember = "Name";
                    cbGroups.ValueMember = "Id";
                    cbGroups.SelectedValue = ContactPerson.UType;
                });
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (VerifyRequired(userInfo.TxtName, lbMessage, "名称")
                || VerifyStringLength(userInfo.TxtName, 20, lbMessage, "名称")
                || VerifyStringLength(userInfo.TxtEmail, 40, lbMessage, "邮箱")
                || VerifyStringLength(userInfo.TxtAddress, 80, lbMessage, "地址")
                || VerifyCallPhone(userInfo.TxtCallPhone, lbMessage, "手机")
                || VerifyTelePhone(userInfo.TxtTelephone, lbMessage, "电话")
                || VerifyEmail(userInfo.TxtEmail, lbMessage, "邮箱"))
            {
                return;
            }
            if (VerifyRequired(userInfo.TxtCallPhone, lbMessage, "手机") && VerifyRequired(userInfo.TxtTelephone, lbMessage, "电话"))
                return;
            if (DateTime.Compare(userInfo.DtBirthday.Value,DateTime.Now)>0)
            {
                lbMessage.ForeColor = Color.Red;
                lbMessage.Text = "生日不得晚于今天";
                userInfo.DtBirthday.Focus();
            }

            if (BLLOperate.IsExistContactPersonName(ContactPerson.Id, GlobalData.Current.CurrentUser.Id, userInfo.TxtName.Text))
            {
                lbMessage.ForeColor = Color.Red;
                lbMessage.Text = "该联系人已存在";
                return;
            }
            HandleData(() =>
            {
                ContactPerson.Name = userInfo.TxtName.Text;
                ContactPerson.Email = userInfo.TxtEmail.Text;
                ContactPerson.Address = userInfo.TxtAddress.Text;
                ContactPerson.Callphone = userInfo.TxtCallPhone.Text;
                ContactPerson.Telephone = userInfo.TxtTelephone.Text;
                ContactPerson.Birthday = userInfo.DtBirthday.Text;
                ContactPerson.Sex = (int)userInfo.CbSex.SelectedValue;
                ContactPerson.Favicon = userInfo.ImageData;
                ContactPerson.UType = (int)cbGroups.SelectedValue;
                ContactPerson.Id = BLLOperate.AddOrModifyItem<TB_ContactPerson>(ContactPerson);
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
