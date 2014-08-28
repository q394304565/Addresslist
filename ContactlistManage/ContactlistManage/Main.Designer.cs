namespace ContactlistManage
{
    partial class Main
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnModifyUserInfo = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbName = new System.Windows.Forms.Label();
            this.pbImage = new System.Windows.Forms.PictureBox();
            this.tvItems = new System.Windows.Forms.TreeView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.管理个人信息ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MIUserManage = new System.Windows.Forms.ToolStripMenuItem();
            this.MIGalleryManage = new System.Windows.Forms.ToolStripMenuItem();
            this.MIModifyPassword = new System.Windows.Forms.ToolStripMenuItem();
            this.MILogout = new System.Windows.Forms.ToolStripMenuItem();
            this.cbSkin = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "UserIco.png");
            this.imageList1.Images.SetKeyName(1, "UsersIco.png");
            // 
            // btnModifyUserInfo
            // 
            this.btnModifyUserInfo.Location = new System.Drawing.Point(84, 80);
            this.btnModifyUserInfo.Name = "btnModifyUserInfo";
            this.btnModifyUserInfo.Size = new System.Drawing.Size(86, 23);
            this.btnModifyUserInfo.TabIndex = 8;
            this.btnModifyUserInfo.Text = "修改个人信息";
            this.btnModifyUserInfo.UseVisualStyleBackColor = true;
            this.btnModifyUserInfo.Click += new System.EventHandler(this.btnModifyUserInfo_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkGray;
            this.panel2.Location = new System.Drawing.Point(-1, 25);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(179, 1);
            this.panel2.TabIndex = 7;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkGray;
            this.panel1.Location = new System.Drawing.Point(0, 107);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(173, 1);
            this.panel1.TabIndex = 5;
            this.panel1.TabStop = true;
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Location = new System.Drawing.Point(88, 35);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(41, 12);
            this.lbName.TabIndex = 2;
            this.lbName.Text = "label1";
            // 
            // pbImage
            // 
            this.pbImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbImage.Image = ((System.Drawing.Image)(resources.GetObject("pbImage.Image")));
            this.pbImage.InitialImage = null;
            this.pbImage.Location = new System.Drawing.Point(4, 30);
            this.pbImage.Name = "pbImage";
            this.pbImage.Size = new System.Drawing.Size(77, 73);
            this.pbImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbImage.TabIndex = 1;
            this.pbImage.TabStop = false;
            // 
            // tvItems
            // 
            this.tvItems.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tvItems.ImageIndex = 0;
            this.tvItems.ImageList = this.imageList1;
            this.tvItems.ItemHeight = 24;
            this.tvItems.Location = new System.Drawing.Point(0, 112);
            this.tvItems.Name = "tvItems";
            this.tvItems.SelectedImageIndex = 0;
            this.tvItems.ShowNodeToolTips = true;
            this.tvItems.Size = new System.Drawing.Size(172, 492);
            this.tvItems.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.管理个人信息ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(0);
            this.menuStrip1.Size = new System.Drawing.Size(876, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 管理个人信息ToolStripMenuItem
            // 
            this.管理个人信息ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MIUserManage,
            this.MIGalleryManage,
            this.MIModifyPassword,
            this.MILogout});
            this.管理个人信息ToolStripMenuItem.Name = "管理个人信息ToolStripMenuItem";
            this.管理个人信息ToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.管理个人信息ToolStripMenuItem.Text = "管理";
            // 
            // MIUserManage
            // 
            this.MIUserManage.Name = "MIUserManage";
            this.MIUserManage.Size = new System.Drawing.Size(148, 22);
            this.MIUserManage.Text = "管理用户信息";
            this.MIUserManage.Click += new System.EventHandler(this.MIUserManage_Click);
            // 
            // MIGalleryManage
            // 
            this.MIGalleryManage.Name = "MIGalleryManage";
            this.MIGalleryManage.Size = new System.Drawing.Size(148, 22);
            this.MIGalleryManage.Text = "管理相册";
            this.MIGalleryManage.Click += new System.EventHandler(this.MIGalleryManage_Click);
            // 
            // MIModifyPassword
            // 
            this.MIModifyPassword.Name = "MIModifyPassword";
            this.MIModifyPassword.Size = new System.Drawing.Size(148, 22);
            this.MIModifyPassword.Text = "修改密码";
            this.MIModifyPassword.Click += new System.EventHandler(this.MIModifyPassword_Click);
            // 
            // MILogout
            // 
            this.MILogout.Name = "MILogout";
            this.MILogout.Size = new System.Drawing.Size(148, 22);
            this.MILogout.Text = "注销";
            this.MILogout.Click += new System.EventHandler(this.MILogout_Click);
            // 
            // cbSkin
            // 
            this.cbSkin.DisplayMember = "Name";
            this.cbSkin.FormattingEnabled = true;
            this.cbSkin.Location = new System.Drawing.Point(755, 0);
            this.cbSkin.Name = "cbSkin";
            this.cbSkin.Size = new System.Drawing.Size(121, 20);
            this.cbSkin.TabIndex = 9;
            this.cbSkin.SelectedIndexChanged += new System.EventHandler(this.cbSkin_SelectedIndexChanged);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(876, 607);
            this.Controls.Add(this.cbSkin);
            this.Controls.Add(this.btnModifyUserInfo);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.pbImage);
            this.Controls.Add(this.tvItems);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "通讯录管理";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView tvItems;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.PictureBox pbImage;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 管理个人信息ToolStripMenuItem;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ToolStripMenuItem MIUserManage;
        private System.Windows.Forms.ToolStripMenuItem MILogout;
        private System.Windows.Forms.ToolStripMenuItem MIGalleryManage;
        private System.Windows.Forms.Button btnModifyUserInfo;
        private System.Windows.Forms.ToolStripMenuItem MIModifyPassword;
        private System.Windows.Forms.ComboBox cbSkin;
    }
}