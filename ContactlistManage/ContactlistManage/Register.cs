using System;
using System.Drawing;
using System.Windows.Forms;
using BLL;
using Infrastructure;
using Model;

namespace ContactlistManage
{
    public partial class Register : FormBase
    {
        public Register()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 注册
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRegister_Click(object sender, EventArgs e)
        {
            var uName = txtUName.Text;
            var password = txtPassword.Text;
            var affirmPassword = txtAffirmPassword.Text;
            if (VerifyRequired(txtUName, lbMessage, "用户名")
                || VerifyRequired(txtPassword, lbMessage, "密码")
                || VerifyStringLength(txtUName, 16, lbMessage, "用户名")
                || VerifyStringLength(txtPassword, 16, lbMessage, "密码"))
            {
                return;
            }
            if (affirmPassword != password)
            {
                lbMessage.ForeColor = Color.Red;
                lbMessage.Text = "确认密码与密码不符";
                txtAffirmPassword.Focus();
                return;
            }
            if (CheckUserName())
                return;
            HandleData(() =>
            {
                var user = BLLOperate.Register(new TB_User
                {
                    UName = uName.Trim(),
                    Name = "",
                    Password = password.Trim()
                });
                if (user != null)
                {
                    GlobalData.Current.CurrentUser = user;
                    MessageBox.Show(this, string.Format("注册成功,欢迎{0}登录！", user.UName.ToLower()));
                    DialogResult = DialogResult.OK;
                    Close();
                }
                else
                {
                    lbMessage.ForeColor = Color.Red;
                    lbMessage.Text = "注册失败";
                }
            }, s =>
            {
                lbMessage.ForeColor = Color.Red;
                lbMessage.Text = "注册失败";
            });
        }

        /// <summary>
        /// 取消
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// 检查用户名
        /// </summary>
        /// <returns></returns>
        private bool CheckUserName()
        {
            bool isExist = false;
            HandleData(() =>
            {
                if (BLLOperate.CheckUserName(txtUName.Text.Trim()))
                {
                    lbMessage.ForeColor = Color.Red;
                    lbMessage.Text = "该用户名已被占用";
                    txtUName.Focus();
                    isExist = true;
                    return;
                }
                lbMessage.Text = "该用户名可用";
                lbMessage.ForeColor = Color.Green;
            }, s =>
            {
                lbMessage.ForeColor = Color.Red;
                lbMessage.Text = "检查用户名失败";
                isExist = true;
            });
            return isExist;
        }

        /// <summary>
        /// 检查用户名
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCheckUserName_Click(object sender, EventArgs e)
        {
            if (VerifyRequired(txtUName, lbMessage, "用户名"))
            {
                return;
            }
            CheckUserName();
        }
    }
}
