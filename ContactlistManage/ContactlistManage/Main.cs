using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ContactlistManage.GalleryManage;
using ContactlistManage.GroupManage;
using ContactlistManage.UserManage;
using Infrastructure;
using Model;

namespace ContactlistManage
{
    public partial class Main : FormBase
    {
        private List<TB_ContactPersonGroup> _contactPersonGroups;
        private List<TB_ContactPerson> _contactPersons;
        readonly TreeNode _treeNode = new TreeNode("全部分组") { Tag = new TB_ContactPersonGroup { Id = 0 } };
        public Main()
        {
            InitializeComponent();
            tvItems.Nodes.Add(_treeNode);

            var addPMenu = new ContextMenu();
            addPMenu.MenuItems.Add("添加联系人组", AddGroup);
            addPMenu.MenuItems.Add("删除全部联系人组", DelAllGroup);
            addPMenu.MenuItems.Add("添加联系人", AddContactPerson);
            _treeNode.ContextMenu = addPMenu;
            if (GlobalData.Current.CurrentUser.UType != (int)UserType.Manage)
                btnUserManage.Visible = false;
            cDataGridView.AutoGenerateColumns = false;
        }

        private void Main_Load(object sender, EventArgs e)
        {
            if (IsLoaded) return;
            SetUserInfo();
            LoadData(() =>
                {
                    foreach (var source in _contactPersonGroups.Where(p => p.ParentId == 0))
                    {
                        var treeNode = CreateGroupTreeNode(source);
                        treeNode.ContextMenu = CreateGroupContextMenu(treeNode);
                        _treeNode.Nodes.Add(treeNode);
                        ForeachTreeNode(treeNode, source.Id);
                    }
                    tvItems.ExpandAll();
                    //设置分组列表
                    var contactPersonGroups = new List<TB_ContactPersonGroup>();
                    contactPersonGroups.Add(new TB_ContactPersonGroup { Id = 0, Name = "未分组" });
                    contactPersonGroups.AddRange(_contactPersonGroups);
                    cbGroup.DataSource = contactPersonGroups;
                    cbGroup.DisplayMember = "Name";
                    if (GlobalData.Current.UserConfig.IsNotRemind)
                    {
                        var birthdayContents = CheckBirthdays();
                        if (birthdayContents.Count > 0)
                        {
                            var remind = new BirthdayRemind { BirthdayContents = birthdayContents };
                            remind.Show(this);
                        }
                    }
                });
            cbSkin.DataSource = GlobalData.Current.SkinList;
            IsLoaded = true;
            cbSkin.SelectedItem = null;
            if (!string.IsNullOrEmpty(GlobalData.Current.UserConfig.SkinName))
            {
                var skin = GlobalData.Current.SkinList.FindIndex(p => p.Name == GlobalData.Current.UserConfig.SkinName);
                if (skin >= 0)
                {
                    cbSkin.SelectedIndex = skin;
                }
            }
            else
            {
                cbSkin.SelectedIndex = 0;
            }
            tvItems.SelectedNode = _treeNode;
        }

        private void SetUserInfo()
        {
            lbName.Text = string.Format("欢迎{0}使用通讯录管理系统", string.IsNullOrEmpty(GlobalData.Current.CurrentUser.Name)
             ? GlobalData.Current.CurrentUser.UName
             : GlobalData.Current.CurrentUser.Name);
            if (GlobalData.Current.CurrentUser.Favicon != null)
            {
                GlobalData.Current.SetImage(pbImage, GlobalData.Current.CurrentUser.Favicon);
            }
        }

        /// <summary>
        /// 检查联系人生日
        /// </summary>
        /// <returns></returns>
        private List<BirthdayContent> CheckBirthdays()
        {
            var birthdayContents = new List<BirthdayContent>();
            GetContactPersonsByUIdAndTypeId(0);
            if (_contactPersons == null)
                return new List<BirthdayContent>();
            foreach (var birthday in _contactPersons)
            {
                if (string.IsNullOrEmpty(birthday.Birthday)) continue;
                var date = Convert.ToDateTime(birthday.Birthday);
                int age = DateTime.Now.Year - date.Year;
                var noewBirthday = Convert.ToDateTime(DateTime.Now.Year + "-" + date.Month + "-" + date.Day);
                var days = noewBirthday.Subtract(DateTime.Now.Date).TotalDays;
                if (days <= 1 && days > 0)
                {
                    birthdayContents.Add(new BirthdayContent
                    {
                        Guid = Guid.NewGuid(),
                        Birthday = date.Month + "-" + date.Day,
                        Content = string.Format("明日{0}为{1}的{2}岁生日，别忘了送上生日祝福！", date.Month + "-" + date.Day, birthday.Name, age)
                    });
                }
                else if (days <= 0 && days > -1)
                {
                    birthdayContents.Add(new BirthdayContent
                    {
                        Guid = Guid.NewGuid(),
                        Birthday = date.Month + "-" + date.Day,
                        Content = string.Format("今天{0}为{1}的{2}岁生日，别忘了送上生日祝福！", date.Month + "-" + date.Day, birthday.Name, age)
                    });
                }
            }
            return birthdayContents;
        }

        /// <summary>
        /// 递归添加树节点
        /// </summary>
        /// <param name="node"></param>
        /// <param name="parentId"></param>
        private void ForeachTreeNode(TreeNode node, int parentId)
        {
            foreach (var source in _contactPersonGroups.Where(p => p.ParentId == parentId))
            {
                var treeNode = CreateGroupTreeNode(source);
                node.Nodes.Add(treeNode);
                ForeachTreeNode(treeNode, source.Id);
            }
        }

        #region ContactPerson
        /// <summary>
        /// 创建联系人
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddContactPerson(object sender, EventArgs e)
        {
            var menuItem = sender as MenuItem;
            if (tvItems.SelectedNode != null)
            {
                var contactPersonGroup = tvItems.SelectedNode.Tag as TB_ContactPersonGroup;
                if (contactPersonGroup != null)
                {
                    var g = new ContactPersonOperate()
                    {
                        Text = menuItem.Text,
                        ContactPerson = new TB_ContactPerson
                        {
                            UId = GlobalData.Current.CurrentUser.Id,
                            UType = contactPersonGroup.Id
                        }
                    };
                    if (g.ShowDialog(this) == DialogResult.OK)
                    {
                        tvItems_AfterSelect(null, null);
                    }
                }
            }
        }
        #endregion

        #region ContactPersonGroup
        /// <summary>
        /// 创建联系人组右键菜单
        /// </summary>
        /// <param name="node"></param>
        /// <returns></returns>
        private ContextMenu CreateGroupContextMenu(TreeNode node)
        {
            var addPMenu = new ContextMenu();
            addPMenu.MenuItems.Add("添加联系人组", AddGroup);
            addPMenu.MenuItems.Add("修改联系人组", ModifyGroup);
            addPMenu.MenuItems.Add("删除联系人组", DeleteGroup);
            addPMenu.MenuItems.Add("添加联系人", AddContactPerson);
            addPMenu.Popup += (s, ex) =>
            {
                tvItems.SelectedNode = node;
            };
            return addPMenu;
        }

        /// <summary>
        /// 创建联系人组树节点
        /// </summary>
        /// <param name="source"></param>
        /// <returns></returns>
        private TreeNode CreateGroupTreeNode(TB_ContactPersonGroup source)
        {
            var treeNode = new TreeNode(source.Name)
            {
                Tag = source,
                ImageIndex = 1,
                SelectedImageIndex = 1,
                ToolTipText = string.Format("联系人组：{0}", source.Name)
            };
            treeNode.ContextMenu = CreateGroupContextMenu(treeNode);
            return treeNode;
        }

        /// <summary>
        /// 删除全部联系人组
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DelAllGroup(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// 添加联系人组
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddGroup(object sender, EventArgs e)
        {
            var menuItem = sender as MenuItem;
            var g = new GroupOperate
            {
                Text = menuItem.Text,
                ContactPersonGroup = new TB_ContactPersonGroup
                {
                    UId = GlobalData.Current.CurrentUser.Id,
                    ParentId = 0
                }
            };
            if (g.ShowDialog(this) == DialogResult.OK)
            {
                if (tvItems.SelectedNode == null || tvItems.SelectedNode.Parent == null)
                    tvItems.Nodes.Add(CreateGroupTreeNode(g.ContactPersonGroup));
                else
                    tvItems.SelectedNode.Parent.Nodes.Add(CreateGroupTreeNode(g.ContactPersonGroup));
            }
        }

        /// <summary>
        /// 修改联系人组
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ModifyGroup(object sender, EventArgs e)
        {
            var menuItem = sender as MenuItem;
            if (tvItems.SelectedNode != null)
            {
                var contactPersonGroup = tvItems.SelectedNode.Tag as TB_ContactPersonGroup;
                var g = new GroupOperate
                {
                    Text = menuItem.Text,
                    ContactPersonGroup = contactPersonGroup
                };
                if (g.ShowDialog(this) == DialogResult.OK)
                {
                    tvItems.SelectedNode.Text = g.ContactPersonGroup.Name;
                    tvItems.SelectedNode.Tag = g.ContactPersonGroup;
                    tvItems.SelectedNode.ToolTipText = string.Format("联系人组：{0}", g.ContactPersonGroup.Name);
                }
            }
        }

        /// <summary>
        /// 删除联系人组
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DeleteGroup(object sender, EventArgs e)
        {
            if (tvItems.SelectedNode != null)
            {
                var contactPersonGroup = tvItems.SelectedNode.Tag as TB_ContactPersonGroup;
                HandleData(() =>
                    {
                        BLLOperate.DeleteItem<TB_ContactPersonGroup>(contactPersonGroup.Id);
                        if (tvItems.SelectedNode.Parent == null)
                            tvItems.Nodes.Remove(tvItems.SelectedNode);
                        else
                            tvItems.SelectedNode.Parent.Nodes.Remove(tvItems.SelectedNode);
                    }, s => MessageBox.Show(this, s));
            }
        }
        #endregion

        /// <summary>
        /// 加载数据源
        /// </summary>
        /// <param name="action"></param>
        private void LoadData(Action action = null)
        {
            HandleData(() =>
            {
                _contactPersonGroups = BLLOperate.GetContactPersonGroupsByUId(GlobalData.Current.CurrentUser.Id);
                if (action != null) action();
            }, s => MessageBox.Show(this, s));
        }

        /// <summary>
        /// 获取联系人
        /// </summary>
        private void GetContactPersonsByUIdAndTypeId(int type)
        {
            HandleData(() =>
            {
                if (type == 0)
                    _contactPersons = BLLOperate.GetContactPersonsByUId(GlobalData.Current.CurrentUser.Id);
                else
                    _contactPersons = BLLOperate.GetContactPersonsByUIdAndTypeId(GlobalData.Current.CurrentUser.Id, type);
                cDataGridView.DataSource = _contactPersons;
            }, s => MessageBox.Show(this, s));
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.ExitThread();
            Application.Exit();
        }

        #region 顶头菜单按钮操作
        /// <summary>
        /// 注销
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLogout_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        /// <summary>
        ///  管理用户
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnUserManage_Click(object sender, EventArgs e)
        {
            var m = new UsersOperate();
            m.ShowDialog(this);
        }

        /// <summary>
        /// 管理相册
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnGalleryManage_Click(object sender, EventArgs e)
        {
            var g = new Gallery();
            g.ShowDialog(this);
        }

        /// <summary>
        /// 修改密码
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnModifyPassword_Click(object sender, EventArgs e)
        {
            var m = new ModifyPassword();
            m.ShowDialog(this);
        }

        /// <summary>
        /// 修改个人信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnModifyUserInfo_Click(object sender, EventArgs e)
        {
            var m = new UserInfoOperate();
            if (m.ShowDialog(this) == DialogResult.OK)
            {
                SetUserInfo();
            }
        }

        #endregion

        /// <summary>
        /// 皮肤更换
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbSkin_SelectedIndexChanged(object sender, EventArgs e)
        {
            var fileInfo = cbSkin.SelectedItem as FileInformation;
            if (fileInfo == null || !IsLoaded) return;
            GlobalData.Current.UserConfig.SkinName = fileInfo.Name;
            SQLiteOperate.ModifyUserConfig(GlobalData.Current.UserConfig);
            GlobalData.Current.SkinEngine.SkinFile = fileInfo.FilePath;
        }

        private void cDataGridView_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            Sex.DataPropertyName = null;

            for (int i = e.RowIndex; i < e.RowIndex + e.RowCount; i++)
            {
                // 通过行（或项）的绑定对象拿到性别
                // 判断该如何显示，此处的DataBoungItem相当于Tag是在绑定数据源时自动绑定的（当然，它是只读的……）
                cDataGridView.Rows[i].Cells[Sex.Index].Value = GlobalData.Current.GetSex((cDataGridView.Rows[i].DataBoundItem as TB_ContactPerson).Sex);
            }
        }

        private void cDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var contactPerson = cDataGridView.Rows[e.RowIndex].DataBoundItem as TB_ContactPerson;
            if (e.ColumnIndex < 0 || cDataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value == null) return;
            string buttonText = cDataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
            HandleData(() =>
            {
                switch (buttonText)
                {
                    case "修改":
                        var g = new ContactPersonOperate()
                        {
                            Text = "修改联系人",
                            ContactPerson = contactPerson
                        };
                        if (g.ShowDialog(this) == DialogResult.OK)
                        {
                            tvItems_AfterSelect(null, null);
                        }
                        break;
                    case "删除":
                        if (MessageBox.Show(this, "确定删除联系人？", "删除联系人", MessageBoxButtons.OKCancel) == DialogResult.OK)
                        {
                            var id = BLLOperate.DeleteItem<TB_ContactPerson>(contactPerson.Id);
                            MessageBox.Show(this, id > 0 ? "删除成功！" : "删除失败");
                            tvItems_AfterSelect(null, null);
                        }
                        break;
                }

            }, s => MessageBox.Show(this, s));
        }

        /// <summary>
        /// 联系人信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            var rows = cDataGridView.SelectedRows;
            if (rows.Count == 0) return;
            var contactPerson = rows[0].DataBoundItem as TB_ContactPerson;
            lbPName.Text = contactPerson.Name;
            lbSex.Text = GlobalData.Current.GetSex(contactPerson.Sex);
            lbBirthday.Text = contactPerson.Birthday;
            lbTelephone.Text = contactPerson.Telephone;
            lbCellPhone.Text = contactPerson.Callphone;
            lbEmail.Text = contactPerson.Email;
            lbAddress.Text = contactPerson.Address;
            if (!string.IsNullOrEmpty(contactPerson.Birthday))
            {
                var date = Convert.ToDateTime(contactPerson.Birthday);
                lbAge.Text = string.Format("{0}岁", DateTime.Now.Year - date.Year);
            }
            if (contactPerson.Favicon != null)
            {
                GlobalData.Current.SetImage(pbFavicon, contactPerson.Favicon);
            }
        }

        /// <summary>
        /// 联系人组被选择
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tvItems_AfterSelect(object sender, TreeViewEventArgs e)
        {
            var nodeItem = tvItems.SelectedNode;
            var group = nodeItem.Tag as TB_ContactPersonGroup;
            GetContactPersonsByUIdAndTypeId(group.Id);
        }

        /// <summary>
        /// 搜索
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSearch.Text))
            {
                MessageBox.Show(this, "请输入");
                return;
            }
            var items = cDataGridView.DataSource as List<TB_ContactPerson>;
            cDataGridView.ClearSelection();
            var index = items.FindIndex(p => p.Name.Contains(txtSearch.Text)
                || p.Telephone.Contains(txtSearch.Text)
                || p.Callphone.Contains(txtSearch.Text)
                || p.Email.Contains(txtSearch.Text));
            if (index >= 0)
            {
                cDataGridView.Rows[index].Selected = true;
            }
            else
            {
                MessageBox.Show(this, "未找到联系人！");
            }
        }

        /// <summary>
        /// 删除选中
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDelSelected_Click(object sender, EventArgs e)
        {
            if (cDataGridView.SelectedRows.Count == 0) return;
            if (MessageBox.Show(this, "确定删除选中的联系人？", "删除联系人", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                HandleData(() =>
                {
                    foreach (DataGridViewRow selectedRow in cDataGridView.SelectedRows)
                    {
                        var contactPerson = selectedRow.DataBoundItem as TB_ContactPerson;
                        BLLOperate.DeleteItem<TB_ContactPerson>(contactPerson.Id);
                    }
                    MessageBox.Show(this, "删除成功！");
                    tvItems_AfterSelect(null, null);
                }, s => MessageBox.Show(this, s));
            }
        }

        /// <summary>
        /// 转移分组
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbGroup_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cDataGridView.SelectedRows.Count == 0) return;
            HandleData(() =>
            {
                foreach (DataGridViewRow selectedRow in cDataGridView.SelectedRows)
                {
                    var contactPerson = selectedRow.DataBoundItem as TB_ContactPerson;
                    BLLOperate.AddOrModifyItem<TB_ContactPerson>(contactPerson);
                }
                MessageBox.Show(this, "转移成功！");
                tvItems_AfterSelect(null, null);
            }, s => MessageBox.Show(this, s));
        }

        /// <summary>
        /// 批量导入
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBatchImport_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// 导出选中
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnExportSelected_Click(object sender, EventArgs e)
        {
            if (cDataGridView.SelectedRows.Count == 0) return;
            try
            {
                var saveFileDialog = new SaveFileDialog { Filter = "Excel 97 - 2003 工作薄(*.xls)|*.xls" }; ;
                if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
                {

                    using (var fs = new FileStream(saveFileDialog.FileName, FileMode.Create, FileAccess.Write))
                    {
                        byte[] bytes = Encoding.UTF8.GetBytes(DataGridToXmlSpreadSheet(cDataGridView.SelectedRows));
                        fs.Write(bytes, 0, bytes.Length);
                        fs.Close();
                    }
                }

                MessageBox.Show(this, "导出成功！");
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "导出失败,请检查文件是否被占用");
            }
        }

        private string DataGridToXmlSpreadSheet(DataGridViewSelectedRowCollection rows)
        {
            const string start =
                "<?xml version=\"1.0\"?><?mso-application progid=\"Excel.Sheet\"?><Workbook xmlns=\"urn:schemas-microsoft-com:office:spreadsheet\" xmlns:o=\"urn:schemas-microsoft-com:office:office\" xmlns:x=\"urn:schemas-microsoft-com:office:excel\" xmlns:ss=\"urn:schemas-microsoft-com:office:spreadsheet\" xmlns:html=\"http://www.w3.org/TR/REC-html40\">";

            var styles = new StringBuilder();
            var ws = new StringBuilder();
            var colsstr = new StringBuilder();
            var rowsstr = new StringBuilder();

            var columnValueHeaders = new List<string>
                                                {
                                                    "Id",
                                                    "Name",
                                                    "UType",
                                                    "Sex",
                                                    "Birthday",
                                                    "Callphone",
                                                    "Telephone",
                                                    "Email",
                                                    "Address",
                                                };
            var columnHeaders = new List<string>
                                    {
                                        "编号",
                                        "姓名",
                                        "组类别",
                                        "性别",
                                        "生日",
                                        "手机",
                                        "电话",
                                        "邮箱",
                                        "地址",
                                    };
            ws.Append(
                string.Format(
                    "<Worksheet ss:Name=\"Sheet1\"><Table ss:ExpandedColumnCount=\"{0}\" ss:ExpandedRowCount=\"{1}\" ss:DefaultColumnWidth=\"54\" ss:DefaultRowHeight=\"14.0625\">"
                    , columnValueHeaders.Count, rows.Count + 1));

            styles.Append("<Styles>");
            rowsstr.Append("<Row ss:AutoFitHeight=\"0\">");
            for (int i = 0; i < columnHeaders.Count; i++)
            {
                styles.Append(string.Format("<Style ss:ID=\"sheader{0}\"><Alignment ss:Vertical=\"{1}\"/>", i,
                            "Center"));
                styles.Append("<Borders><Border ss:Position=\"Bottom\" ss:LineStyle=\"Continuous\" ss:Weight=\"1\"/>");
                styles.Append("<Border ss:Position=\"Left\" ss:LineStyle=\"Continuous\" ss:Weight=\"1\"/>");
                styles.Append("<Border ss:Position=\"Right\" ss:LineStyle=\"Continuous\" ss:Weight=\"1\"/>");
                styles.Append("<Border ss:Position=\"Top\" ss:LineStyle=\"Continuous\" ss:Weight=\"1\"/>");
                styles.Append("</Borders>");
                styles.Append(
                    string.Format(
                        "<Font ss:FontName=\"宋体\" x:CharSet=\"134\" ss:Size=\"12\" ss:Bold=\"1\"/><Interior/></Style>"));
                rowsstr.Append(
                    string.Format("<Cell ss:StyleID=\"sheader{0}\"><Data ss:Type=\"String\" >{1}</Data></Cell>",
                                  i, columnHeaders[i]));
            }
            rowsstr.Append("</Row>");

            styles.Append(string.Format("<Style ss:ID=\"s{0}_{1}\"><Alignment ss:Vertical=\"{2}\"/>", 1,
                                1, "Center"));
            styles.Append(
                "<Borders><Border ss:Position=\"Bottom\" ss:LineStyle=\"Continuous\" ss:Weight=\"1\"/>");
            styles.Append("<Border ss:Position=\"Left\" ss:LineStyle=\"Continuous\" ss:Weight=\"1\"/>");
            styles.Append("<Border ss:Position=\"Right\" ss:LineStyle=\"Continuous\" ss:Weight=\"1\"/>");
            styles.Append("<Border ss:Position=\"Top\" ss:LineStyle=\"Continuous\" ss:Weight=\"1\"/>");
            styles.Append("</Borders>");
            styles.Append(
                string.Format("<Font ss:FontName=\"宋体\" x:CharSet=\"134\" ss:Size=\"12\"/><Interior/></Style>"));

            for (int row = 0; row < rows.Count; row++)
            {
                rowsstr.Append("<Row ss:AutoFitHeight=\"0\">");
                for (int j = 0; j < columnValueHeaders.Count; j++)
                {
                    string type = "String";
                    try
                    {
                        var data = rows[row].DataBoundItem as TB_ContactPerson;
                        var value = typeof(TB_ContactPerson).GetProperty(columnValueHeaders[j]).GetValue(data, null);
                        if (columnValueHeaders[j] == "Sex")
                        {
                            value = GlobalData.Current.GetSex(Convert.ToInt32(value));
                        }
                        else if (columnValueHeaders[j] == "UType")
                        {
                            var group = _contactPersonGroups.FirstOrDefault(p => p.Id == Convert.ToInt32(value));
                            value = group != null ? group.Name : "未分组";
                        }
                        rowsstr.Append(string.Format("<Cell ss:StyleID=\"s{1}_{2}\"><Data ss:Type=\"{3}\" >{0}</Data></Cell>", value ?? "", 1, 1, type));
                    }
                    catch (Exception)
                    {
                        rowsstr.Append(string.Format("<Cell ss:StyleID=\"s{1}_{2}\"><Data ss:Type=\"{3}\" >{0}</Data></Cell>", "", 1, 1, type));
                    }
                }
                rowsstr.Append("</Row>");
            }
            styles.Append("</Styles>");
            ws.Append(colsstr);
            ws.Append(rowsstr);
            ws.Append("</Table></Worksheet>");
            const string end = "</Workbook>";
            var total = new StringBuilder();
            total.Append(start);
            total.Append(styles);
            total.Append(ws);
            total.Append(end);
            return total.ToString();
        }

        private bool IsNumber(object value)
        {
            if (value == null)
                return false;
            var i = 0;
            var j = 0.0;
            return int.TryParse(value.ToString(), out i) ||
                double.TryParse(value.ToString(), out j);
        }

    }
}
