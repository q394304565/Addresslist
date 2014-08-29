using System;
using System.Drawing;
using System.Windows.Forms;
using Infrastructure;
using Model;

namespace ContactlistManage.GroupManage
{
    public partial class GroupOperate : FormBase
    {
        public TB_ContactPersonGroup ContactPersonGroup { get; set; }

        public GroupOperate()
        {
            InitializeComponent();
        }

        private void GroupOperate_Load(object sender, EventArgs e)
        {
            txtName.Text = ContactPersonGroup.Name;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (VerifyRequired(txtName, lbMessage, "名称"))
            {
                return;
            }
            if (BLLOperate.IsExistContactPersonGroupName(ContactPersonGroup.Id, GlobalData.Current.CurrentUser.Id, txtName.Text))
            {
                lbMessage.ForeColor = Color.Red;
                lbMessage.Text = "该联系人组已存在";
                return;
            }
            HandleData(() =>
            {
                ContactPersonGroup.Name = txtName.Text;
                ContactPersonGroup.Id = BLLOperate.AddOrModifyItem<TB_ContactPersonGroup>(ContactPersonGroup);
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
