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
            this.tvItems = new System.Windows.Forms.TreeView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.pbImage = new System.Windows.Forms.PictureBox();
            this.lbName = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnManage = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).BeginInit();
            this.SuspendLayout();
            // 
            // tvItems
            // 
            this.tvItems.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tvItems.ImageIndex = 0;
            this.tvItems.ImageList = this.imageList1;
            this.tvItems.Location = new System.Drawing.Point(0, 85);
            this.tvItems.Name = "tvItems";
            this.tvItems.SelectedImageIndex = 0;
            this.tvItems.ShowNodeToolTips = true;
            this.tvItems.Size = new System.Drawing.Size(173, 520);
            this.tvItems.TabIndex = 0;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "UserIco.png");
            this.imageList1.Images.SetKeyName(1, "UsersIco.png");
            // 
            // pbImage
            // 
            this.pbImage.Image = ((System.Drawing.Image)(resources.GetObject("pbImage.Image")));
            this.pbImage.InitialImage = null;
            this.pbImage.Location = new System.Drawing.Point(4, 4);
            this.pbImage.Name = "pbImage";
            this.pbImage.Size = new System.Drawing.Size(77, 73);
            this.pbImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbImage.TabIndex = 1;
            this.pbImage.TabStop = false;
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Location = new System.Drawing.Point(88, 9);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(41, 12);
            this.lbName.TabIndex = 2;
            this.lbName.Text = "label1";
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(90, 24);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(75, 23);
            this.btnLogout.TabIndex = 3;
            this.btnLogout.Text = "注销";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnManage
            // 
            this.btnManage.Location = new System.Drawing.Point(90, 53);
            this.btnManage.Name = "btnManage";
            this.btnManage.Size = new System.Drawing.Size(75, 23);
            this.btnManage.TabIndex = 4;
            this.btnManage.Text = "管理信息";
            this.btnManage.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkGray;
            this.panel1.Location = new System.Drawing.Point(0, 82);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(173, 1);
            this.panel1.TabIndex = 5;
            this.panel1.TabStop = true;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(173, 605);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnManage);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.pbImage);
            this.Controls.Add(this.tvItems);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "通讯录管理";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView tvItems;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.PictureBox pbImage;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnManage;
        private System.Windows.Forms.Panel panel1;
    }
}