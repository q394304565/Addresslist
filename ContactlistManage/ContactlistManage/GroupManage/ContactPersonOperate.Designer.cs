namespace ContactlistManage.GroupManage
{
    partial class ContactPersonOperate
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.lbMessage = new System.Windows.Forms.Label();
            this.userInfo = new ContactlistManage.UserInfo();
            this.lbName = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(215, 263);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(125, 263);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 6;
            this.btnOK.Text = "确定";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // lbMessage
            // 
            this.lbMessage.AutoSize = true;
            this.lbMessage.ForeColor = System.Drawing.Color.Red;
            this.lbMessage.Location = new System.Drawing.Point(41, 232);
            this.lbMessage.Name = "lbMessage";
            this.lbMessage.Size = new System.Drawing.Size(0, 12);
            this.lbMessage.TabIndex = 8;
            // 
            // userInfo
            // 
            this.userInfo.AutoSize = true;
            this.userInfo.Location = new System.Drawing.Point(2, 40);
            this.userInfo.Name = "userInfo";
            this.userInfo.Size = new System.Drawing.Size(432, 188);
            this.userInfo.TabIndex = 0;
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Location = new System.Drawing.Point(8, 21);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(65, 12);
            this.lbName.TabIndex = 9;
            this.lbName.Text = "联系组名称";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(80, 12);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(169, 20);
            this.comboBox1.TabIndex = 10;
            // 
            // ContactPersonOperate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 298);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.lbMessage);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.userInfo);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ContactPersonOperate";
            this.Text = "联系人";
            this.Load += new System.EventHandler(this.ContactPersonOperate_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Label lbMessage;
        private UserInfo userInfo;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}