﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Model;

namespace ContactlistManage.GroupManage
{
    public partial class GroupOperate : FormBase
    {
        public TB_ContactPersonGroup ContactPersonGroup { get; set; }

        public GroupOperate(string pName)
        {
            InitializeComponent();
            lbParentName.Text = pName;
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