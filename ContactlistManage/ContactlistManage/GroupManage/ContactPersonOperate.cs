using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BLL;
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
            userInfo.TxtEmail.Text = ContactPerson.Name;
            userInfo.TxtAddress.Text = ContactPerson.Name;
            userInfo.TxtCallPhone.Text = ContactPerson.Name;
            userInfo.TxtTelephone.Text = ContactPerson.Name;
            userInfo.DtBirthday.Text = ContactPerson.Name;
            userInfo.PbFavicon.Text = ContactPerson.Name;
            userInfo.CbSex.Text = ContactPerson.Name;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (VerifyRequired(userInfo.TxtName, lbMessage, "名称"))
            {
                return;
            }
            HandleData(() =>
            {
                ContactPerson.Name = userInfo.TxtName.Text;
                ContactPerson.Id = BLLOperate.AddOrModifyItem<TB_ContactPersonGroup>(ContactPerson);
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
