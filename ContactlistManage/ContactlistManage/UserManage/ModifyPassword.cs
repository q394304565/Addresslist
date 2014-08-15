using System;
using System.Drawing;
using System.Windows.Forms;
using Infrastructure;

namespace ContactlistManage.UserManage
{
    public partial class ModifyPassword : FormBase
    {
        public ModifyPassword()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            var oldPassword = txtOldPassword.Text;
            var newPassword = txtNewPassword.Text;
            var affirmPassword = txtAffirmPassword.Text;
            if (VerifyRequired(txtOldPassword, lbMessage, "旧密码")
                || VerifyRequired(txtNewPassword, lbMessage, "新密码")
                || VerifyStringLength(txtNewPassword, 16, lbMessage, "新密码"))
            {
                return;
            }
            if (oldPassword.Trim() != GlobalData.Current.CurrentUser.Password)
            {
                lbMessage.ForeColor = Color.Red;
                lbMessage.Text = "旧密码不匹配";
                txtOldPassword.Focus();
                return;
            }
            if (oldPassword == newPassword)
            {
                lbMessage.ForeColor = Color.Red;
                lbMessage.Text = "新密码不能与旧密码相同";
                txtNewPassword.Focus();
                return;
            }
            if (affirmPassword != newPassword)
            {
                lbMessage.ForeColor = Color.Red;
                lbMessage.Text = "确认密码与新密码不符";
                txtAffirmPassword.Focus();
                return;
            }
            HandleData(() =>
            {
                var succeed = BLLOperate.ModifyPassword(GlobalData.Current.CurrentUser.Id, newPassword);
                if (succeed)
                {
                    GlobalData.Current.CurrentUser.Password = newPassword;
                    MessageBox.Show(this, "修改成功！");
                    Close();
                }
                else
                {
                    lbMessage.ForeColor = Color.Red;
                    lbMessage.Text = "修改失败";
                }
            }, s =>
            {
                lbMessage.ForeColor = Color.Red;
                lbMessage.Text = "修改失败";
            });
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
