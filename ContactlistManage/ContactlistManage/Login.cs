using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using BLL;
using Infrastructure;
using Model;
using System.Linq;

namespace ContactlistManage
{
    public partial class Login : FormBase
    {
        public Login()
        {
            InitializeComponent();
            GlobalData.Current.SkinEngine = skinEngine1;
            GlobalData.Current.UserConfig = SQLiteOperate.GetUserConfig();
            if (GlobalData.Current.UserConfig != null)
            {
                cbRemindName.Checked = GlobalData.Current.UserConfig.IsSaveName;
                txtUName.Text = GlobalData.Current.UserConfig.IsSaveName ? GlobalData.Current.UserConfig.UserName : string.Empty;
                cbRemindPassword.Checked = GlobalData.Current.UserConfig.IsSavePassword;
                txtPassword.Text = GlobalData.Current.UserConfig.IsSavePassword ? GlobalData.Current.UserConfig.Password : string.Empty;
                if (!string.IsNullOrEmpty(GlobalData.Current.UserConfig.SkinName))
                {
                    var skin = GlobalData.Current.SkinList.FirstOrDefault(p => p.Name == GlobalData.Current.UserConfig.SkinName);
                    GlobalData.Current.SkinEngine.SkinFile = skin != null ? skin.FilePath : string.Empty;
                }
                else
                {
                    var skin = GlobalData.Current.SkinList.First();
                    GlobalData.Current.SkinEngine.SkinFile = skin != null ? skin.FilePath : string.Empty;
                }
            }
            else
            {
                GlobalData.Current.UserConfig = new UserConfig();
                SQLiteOperate.AddUserConfig(GlobalData.Current.UserConfig);
                var skin = GlobalData.Current.SkinList.First();
                GlobalData.Current.SkinEngine.SkinFile = skin != null ? skin.FilePath : string.Empty;
            }
        }

        private void cbRemindPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (cbRemindPassword.Checked)
            {
                cbRemindName.Checked = cbRemindPassword.Checked;
            }
        }

        /// <summary>
        /// 登录
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (VerifyRequired(txtUName))
            {
                lbMessage.ForeColor = Color.Red;
                lbMessage.Text = "用户名不能为空";
                return;
            }
            if (VerifyRequired(txtPassword))
            {
                lbMessage.ForeColor = Color.Red;
                lbMessage.Text = "密码不能为空";
                return;
            }
            HandleData(() =>
            {
                TB_User user = BLLOperate.UserLogin(txtUName.Text, txtPassword.Text);
                if (user != null)
                {
                    GlobalData.Current.CurrentUser = user;
                    GlobalData.Current.UserConfig = new UserConfig
                        {
                            IsSaveName = cbRemindName.Checked,
                            IsSavePassword = cbRemindPassword.Checked,
                            UserName = txtUName.Text,
                            Password = txtPassword.Text,
                        };
                    SQLiteOperate.ModifyUserConfig(GlobalData.Current.UserConfig);
                    MessageBox.Show(this, string.Format("欢迎{0}登录！", string.IsNullOrEmpty(user.Name) ? user.UName : user.Name));
                    Hide();
                    var main = new Main();
                    main.Show();
                }
                else
                {
                    lbMessage.ForeColor = Color.Red;
                    lbMessage.Text = "登录失败，用户名或密码错误";
                }
            }, s =>
                {
                    lbMessage.ForeColor = Color.Red;
                    lbMessage.Text = "登录失败，数据访问出错";
                });
        }

        /// <summary>
        /// 注册
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRegister_Click(object sender, EventArgs e)
        {
            var reg = new Register();
            Hide();
            if (reg.ShowDialog(this) == DialogResult.OK)
            {
                Hide();
                var main = new Main();
                main.Show();
            }
            else
            {
                Show();
            }
        }
    }
}
