namespace ContactlistManage.UserManage
{
    partial class UsersOperate
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.UName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Birthday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CallPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TelePhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Adress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Favicon = new System.Windows.Forms.DataGridViewImageColumn();
            this.ResetPassword = new System.Windows.Forms.DataGridViewButtonColumn();
            this.DeleteUser = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.UName,
            this.LName,
            this.Birthday,
            this.Sex,
            this.CallPhone,
            this.TelePhone,
            this.Email,
            this.Adress,
            this.Favicon,
            this.ResetPassword,
            this.DeleteUser});
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(728, 406);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dataGridView1_RowsAdded);
            // 
            // UName
            // 
            this.UName.DataPropertyName = "Name";
            this.UName.HeaderText = "姓名";
            this.UName.Name = "UName";
            this.UName.ReadOnly = true;
            // 
            // LName
            // 
            this.LName.DataPropertyName = "UName";
            this.LName.HeaderText = "用户名";
            this.LName.Name = "LName";
            this.LName.ReadOnly = true;
            // 
            // Birthday
            // 
            this.Birthday.DataPropertyName = "Birthday";
            this.Birthday.HeaderText = "生日";
            this.Birthday.Name = "Birthday";
            this.Birthday.ReadOnly = true;
            // 
            // Sex
            // 
            this.Sex.DataPropertyName = "Sex";
            this.Sex.HeaderText = "性别";
            this.Sex.Name = "Sex";
            this.Sex.ReadOnly = true;
            // 
            // CallPhone
            // 
            this.CallPhone.DataPropertyName = "CallPhone";
            this.CallPhone.HeaderText = "手机";
            this.CallPhone.Name = "CallPhone";
            this.CallPhone.ReadOnly = true;
            // 
            // TelePhone
            // 
            this.TelePhone.DataPropertyName = "TelePhone";
            this.TelePhone.HeaderText = "电话";
            this.TelePhone.Name = "TelePhone";
            this.TelePhone.ReadOnly = true;
            // 
            // Email
            // 
            this.Email.DataPropertyName = "Email";
            this.Email.HeaderText = "邮箱";
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            // 
            // Adress
            // 
            this.Adress.DataPropertyName = "Adress";
            this.Adress.HeaderText = "地址";
            this.Adress.Name = "Adress";
            this.Adress.ReadOnly = true;
            // 
            // Favicon
            // 
            this.Favicon.DataPropertyName = "Favicon";
            this.Favicon.HeaderText = "头像";
            this.Favicon.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Favicon.Name = "Favicon";
            this.Favicon.ReadOnly = true;
            // 
            // ResetPassword
            // 
            this.ResetPassword.HeaderText = "重置密码";
            this.ResetPassword.Name = "ResetPassword";
            this.ResetPassword.ReadOnly = true;
            this.ResetPassword.Text = "重置密码";
            this.ResetPassword.UseColumnTextForButtonValue = true;
            // 
            // DeleteUser
            // 
            this.DeleteUser.HeaderText = "删除用户";
            this.DeleteUser.Name = "DeleteUser";
            this.DeleteUser.ReadOnly = true;
            this.DeleteUser.Text = "删除用户";
            this.DeleteUser.UseColumnTextForButtonValue = true;
            // 
            // UsersOperate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(728, 406);
            this.Controls.Add(this.dataGridView1);
            this.Name = "UsersOperate";
            this.Text = "用户管理";
            this.Load += new System.EventHandler(this.UsersOperate_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn UName;
        private System.Windows.Forms.DataGridViewTextBoxColumn LName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Birthday;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sex;
        private System.Windows.Forms.DataGridViewTextBoxColumn CallPhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn TelePhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Adress;
        private System.Windows.Forms.DataGridViewImageColumn Favicon;
        private System.Windows.Forms.DataGridViewButtonColumn ResetPassword;
        private System.Windows.Forms.DataGridViewButtonColumn DeleteUser;

    }
}