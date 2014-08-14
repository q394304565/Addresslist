using System;
using System.Drawing;
using System.Windows.Forms;
using BLL;
using Infrastructure;
using Model;

namespace ContactlistManage
{
    public partial class Login : FormBase
    {
        public Login()
        {
            InitializeComponent();
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
                    MessageBox.Show(this, string.Format("欢迎{0}登录！", string.IsNullOrEmpty(user.Name) ? user.UName : user.Name));
                    Hide();
                    var main = new Main();
                    main.Show();
                }
                else
                {
                    MessageBox.Show(this, "登录失败，用户名或密码错误！");
                }
            }, s => MessageBox.Show(this, "登录失败,数据访问出错！"));
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
