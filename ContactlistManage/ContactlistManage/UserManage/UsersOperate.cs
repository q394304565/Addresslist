using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Infrastructure;
using Model;

namespace ContactlistManage.UserManage
{
    public partial class UsersOperate : FormBase
    {
        public UsersOperate()
        {
            InitializeComponent();
            dataGridView1.AutoGenerateColumns = false;
        }

        private void UsersOperate_Load(object sender, EventArgs e)
        {
            LoadUsers();
        }

        void LoadUsers()
        {
            HandleData(() =>
            {
                dataGridView1.DataSource = BLLOperate.GetItems<TB_User>().Where(p => p.Id != GlobalData.Current.CurrentUser.Id).ToList();
            }, s => MessageBox.Show(this, s));
        }

        private void dataGridView1_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            // 如果能通过对象拿到性别，可以采用如下做法显示对应中文

            // 取消对列属性的绑定
            Sex.DataPropertyName = null;

            for (int i = e.RowIndex; i < e.RowIndex + e.RowCount; i++)
            {
                // 通过行（或项）的绑定对象拿到性别
                // 判断该如何显示，此处的DataBoungItem相当于Tag是在绑定数据源时自动绑定的（当然，它是只读的……）
                string sex;
                switch ((SexType)(dataGridView1.Rows[i].DataBoundItem as TB_User).Sex)
                {
                    case SexType.Lady:
                        sex = "女";
                        break;
                    case SexType.Man:
                        sex = "男";
                        break;
                    default:
                        sex = "无";
                        break;
                }
                dataGridView1.Rows[i].Cells[Sex.Index].Value = sex;
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var user = dataGridView1.Rows[e.RowIndex].DataBoundItem as TB_User;
            string buttonText = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
            HandleData(() =>
            {
                switch (buttonText)
                {
                    case "重置密码":
                        var succeed = BLLOperate.ModifyPassword(user.Id, "1");
                        MessageBox.Show(this, succeed ? "重置成功！" : "重置失败");
                        break;
                    case "删除用户":
                        var id = BLLOperate.DeleteItem<TB_User>(user.Id);
                        MessageBox.Show(this, id > 0 ? "删除成功！" : "删除失败");
                        LoadUsers();
                        break;
                }

            }, s => MessageBox.Show(this, s));
        }
    }
}
