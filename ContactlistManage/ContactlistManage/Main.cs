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
        public Main()
        {
            InitializeComponent();
            var addPMenu = new ContextMenu();
            addPMenu.MenuItems.Add("添加联系人组", AddGroup);
            tvItems.ContextMenu = addPMenu;
            if (GlobalData.Current.CurrentUser.UType != (int)UserType.Manage)
                MIUserManage.Visible = false;
        }

        private bool _isLoaded = false;
        private void Main_Load(object sender, EventArgs e)
        {
            if (_isLoaded) return;
            _isLoaded = true;
            SetUserInfo();
            LoadData(() =>
                {
                    foreach (var source in _contactPersonGroups.Where(p => p.ParentId == 0))
                    {
                        var treeNode = CreateGroupTreeNode(source);
                        treeNode.ContextMenu = CreateGroupContextMenu(treeNode);
                        tvItems.Nodes.Add(treeNode);
                        ForeachTreeNode(treeNode, source.Id);
                    }
                    tvItems.ExpandAll();
                });
        }

        private void SetUserInfo()
        {
            lbName.Text = string.Format("您好，{0}", string.IsNullOrEmpty(GlobalData.Current.CurrentUser.Name)
             ? GlobalData.Current.CurrentUser.UName
             : GlobalData.Current.CurrentUser.Name);
            if (GlobalData.Current.CurrentUser.Favicon != null)
            {
                using (var myStream = new MemoryStream())
                {
                    foreach (byte a in GlobalData.Current.CurrentUser.Favicon)
                    {
                        myStream.WriteByte(a);
                    }
                    var myImage = Image.FromStream(myStream);
                    myStream.Close();
                    pbImage.Image = myImage;
                }
            }
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
            var contactPersons = _contactPersons.Where(p => p.UType == parentId);
            foreach (var contactPerson in contactPersons)
            {
                var cpNode = CreateTreeNode(contactPerson);
                node.Nodes.Add(cpNode);
            }
        }

        #region ContactPerson
        /// <summary>
        /// 创建联系人树节点
        /// </summary>
        /// <param name="contactPerson"></param>
        /// <returns></returns>
        private TreeNode CreateTreeNode(TB_ContactPerson contactPerson)
        {
            var cpNode = new TreeNode(contactPerson.Name)
            {
                Tag = contactPerson,
                ToolTipText = string.Format("联系人：{0}", contactPerson.Name),
            };
            cpNode.ContextMenu = CreateContextMenu(cpNode);
            return cpNode;
        }

        /// <summary>
        /// 创建联系人右键菜单
        /// </summary>
        /// <param name="node"></param>
        /// <returns></returns>
        private ContextMenu CreateContextMenu(TreeNode node)
        {
            var addPMenu = new ContextMenu();
            addPMenu.MenuItems.Add("添加联系人", AddContactPerson);
            addPMenu.MenuItems.Add("修改联系人", ModifyContactPerson);
            addPMenu.MenuItems.Add("删除联系人", DeleteContactPerson);
            addPMenu.Popup += (s, ex) =>
            {
                tvItems.SelectedNode = node;
            };
            return addPMenu;
        }

        /// <summary>
        /// 创建联系人
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddContactPerson(object sender, EventArgs e)
        {
            var menuItem = sender as MenuItem;
            int uType = 0;
            if (tvItems.SelectedNode != null)
            {
                var contactPersonGroup = tvItems.SelectedNode.Tag as TB_ContactPersonGroup;
                if (contactPersonGroup != null)
                {
                    uType = contactPersonGroup.Id;
                }
                else
                {
                    var contactPerson = tvItems.SelectedNode.Tag as TB_ContactPerson;
                    if (contactPerson != null)
                    {
                        uType = contactPerson.UType;
                    }
                }
                var g = new ContactPersonOperate()
                {
                    Text = menuItem.Text,
                    ContactPerson = new TB_ContactPerson
                    {
                        UId = GlobalData.Current.CurrentUser.Id,
                        UType = uType
                    }
                };
                if (g.ShowDialog(this) == DialogResult.OK)
                {
                    if (tvItems.SelectedNode == null || tvItems.SelectedNode.Parent == null)
                        tvItems.Nodes.Add(CreateTreeNode(g.ContactPerson));
                    else
                        tvItems.SelectedNode.Parent.Nodes.Add(CreateTreeNode(g.ContactPerson));
                }
            }
        }

        /// <summary>
        /// 修改联系人
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ModifyContactPerson(object sender, EventArgs e)
        {
            var menuItem = sender as MenuItem;
            if (tvItems.SelectedNode != null)
            {
                var contactPerson = tvItems.SelectedNode.Tag as TB_ContactPerson;
                var g = new ContactPersonOperate()
                {
                    Text = menuItem.Text,
                    ContactPerson = contactPerson
                };
                var type = contactPerson.UType;
                if (g.ShowDialog(this) == DialogResult.OK)
                {
                    tvItems.SelectedNode.Text = g.ContactPerson.Name;
                    tvItems.SelectedNode.Tag = g.ContactPerson;
                    tvItems.SelectedNode.ToolTipText = string.Format("联系人：{0}", g.ContactPerson.Name);
                    var node = tvItems.SelectedNode;
                    if (type != g.ContactPerson.UType)
                    {
                        FindTreeNode(node, g.ContactPerson.UType);
                    }
                }
            }
        }

        /// <summary>
        /// 查找树节点
        /// </summary>
        /// <param name="newNode"></param>
        /// <param name="id"></param>
        private void FindTreeNode(TreeNode newNode, int id)
        {
            tvItems.Nodes.Remove(newNode);
            foreach (TreeNode node in tvItems.Nodes)
            {
                var gNode = node.Tag as TB_ContactPersonGroup;
                if (gNode != null && gNode.Id == id)
                {
                    node.Nodes.Add(newNode);
                    return;
                }
                else
                    FindTreeNode(node, newNode, id);
            }
        }

        private void FindTreeNode(TreeNode pNode, TreeNode newNode, int id)
        {
            foreach (TreeNode node in pNode.Nodes)
            {
                var gNode = node.Tag as TB_ContactPersonGroup;
                if (gNode != null && gNode.Id == id)
                {
                    node.Nodes.Add(newNode);
                    return;
                }
                else
                {
                    FindTreeNode(node, newNode, id);
                }
            }
        }

        /// <summary>
        /// 删除联系人
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DeleteContactPerson(object sender, EventArgs e)
        {
            if (tvItems.SelectedNode != null)
            {
                var contactPerson = tvItems.SelectedNode.Tag as TB_ContactPerson;
                HandleData(() =>
                {
                    BLLOperate.DeleteItem<TB_ContactPerson>(contactPerson.Id);
                    if (tvItems.SelectedNode.Parent == null)
                        tvItems.Nodes.Remove(tvItems.SelectedNode);
                    else
                        tvItems.SelectedNode.Parent.Nodes.Remove(tvItems.SelectedNode);
                }, s => MessageBox.Show(this, s));
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
            addPMenu.MenuItems.Add("添加同级联系人组", AddGroup);
            addPMenu.MenuItems.Add("添加子集联系人组", AddSubGroup);
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
        /// 添加同级联系人组
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddGroup(object sender, EventArgs e)
        {
            var menuItem = sender as MenuItem;
            string parentName = string.Empty;
            TB_ContactPersonGroup contactPersonGroup = null;
            if (tvItems.SelectedNode != null)
            {
                contactPersonGroup = tvItems.SelectedNode.Tag as TB_ContactPersonGroup;
                if (tvItems.SelectedNode.Parent != null) parentName = tvItems.SelectedNode.Parent.Text;
            }
            var g = new GroupOperate(parentName)
            {
                Text = menuItem.Text,
                ContactPersonGroup = new TB_ContactPersonGroup
                {
                    UId = GlobalData.Current.CurrentUser.Id,
                    ParentId = contactPersonGroup == null ? 0 : contactPersonGroup.ParentId
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
        /// 添加子集联系人组
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddSubGroup(object sender, EventArgs e)
        {
            var menuItem = sender as MenuItem;
            if (tvItems.SelectedNode != null)
            {
                var contactPersonGroup = tvItems.SelectedNode.Tag as TB_ContactPersonGroup;
                var g = new GroupOperate(contactPersonGroup.Name)
                {
                    Text = menuItem.Text,
                    ContactPersonGroup = new TB_ContactPersonGroup
                    {
                        UId = GlobalData.Current.CurrentUser.Id,
                        ParentId = contactPersonGroup.Id
                    }
                };
                if (g.ShowDialog(this) == DialogResult.OK)
                {
                    tvItems.SelectedNode.Nodes.Add(CreateGroupTreeNode(g.ContactPersonGroup));
                }
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
            string parentName = string.Empty;
            if (tvItems.SelectedNode != null)
            {
                var contactPersonGroup = tvItems.SelectedNode.Tag as TB_ContactPersonGroup;
                if (tvItems.SelectedNode.Parent != null) parentName = tvItems.SelectedNode.Parent.Text;
                var g = new GroupOperate(parentName)
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
                var contactPersonGroup = tvItems.SelectedNode.Tag as TB_ContactPersonGroup; ;
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
                _contactPersons = BLLOperate.GetContactPersonsByUId(GlobalData.Current.CurrentUser.Id);
                if (action != null) action();
            }, s => MessageBox.Show(this, s));
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.ExitThread();
            Application.Exit();
        }

        /// <summary>
        /// 注销
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MILogout_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        /// <summary>
        ///  管理用户
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MIUserManage_Click(object sender, EventArgs e)
        {
            var m = new UsersOperate();
            m.ShowDialog(this);
        }

        /// <summary>
        /// 管理相册
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MIGalleryManage_Click(object sender, EventArgs e)
        {
            var g = new Gallery();
            g.ShowDialog(this);
        }

        /// <summary>
        /// 修改密码
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MIModifyPassword_Click(object sender, EventArgs e)
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
    }
}
