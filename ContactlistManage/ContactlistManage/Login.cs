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

namespace ContactlistManage
{
    public partial class Login : Form
    {
        private readonly UserBLL _userBll;
        public Login()
        {
            InitializeComponent();
             _userBll = new UserBLL();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
        
        private void btnLogin_Click(object sender, EventArgs e)
        {
           var user= _userBll.UserLogin(txtUName.Text, txtPassword.Text);
            MessageBox.Show(user.Name);
        }
    }
}
