namespace ContactlistManage
{
    partial class UserInfo
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserInfo));
            this.label1 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cbSex = new System.Windows.Forms.ComboBox();
            this.dtBirthday = new System.Windows.Forms.DateTimePicker();
            this.pbFavicon = new System.Windows.Forms.PictureBox();
            this.txtTelephone = new System.Windows.Forms.MaskedTextBox();
            this.txtCallPhone = new System.Windows.Forms.MaskedTextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbFavicon)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "姓名";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(43, 3);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(205, 21);
            this.txtName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "电话";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "手机";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 6;
            this.label4.Text = "邮箱";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 65);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 12);
            this.label5.TabIndex = 8;
            this.label5.Text = "生日";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(43, 164);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(366, 21);
            this.txtAddress.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 173);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 12);
            this.label6.TabIndex = 10;
            this.label6.Text = "住址";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 38);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 12);
            this.label7.TabIndex = 12;
            this.label7.Text = "性别";
            // 
            // cbSex
            // 
            this.cbSex.FormattingEnabled = true;
            this.cbSex.Location = new System.Drawing.Point(43, 30);
            this.cbSex.Name = "cbSex";
            this.cbSex.Size = new System.Drawing.Size(205, 20);
            this.cbSex.TabIndex = 13;
            // 
            // dtBirthday
            // 
            this.dtBirthday.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtBirthday.Location = new System.Drawing.Point(43, 56);
            this.dtBirthday.Name = "dtBirthday";
            this.dtBirthday.Size = new System.Drawing.Size(205, 21);
            this.dtBirthday.TabIndex = 14;
            // 
            // pbFavicon
            // 
            this.pbFavicon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbFavicon.Image = ((System.Drawing.Image)(resources.GetObject("pbFavicon.Image")));
            this.pbFavicon.Location = new System.Drawing.Point(254, 3);
            this.pbFavicon.Name = "pbFavicon";
            this.pbFavicon.Size = new System.Drawing.Size(155, 155);
            this.pbFavicon.TabIndex = 15;
            this.pbFavicon.TabStop = false;
            // 
            // txtTelephone
            // 
            this.txtTelephone.Location = new System.Drawing.Point(43, 82);
            this.txtTelephone.Mask = "9000-00000000";
            this.txtTelephone.Name = "txtTelephone";
            this.txtTelephone.Size = new System.Drawing.Size(205, 21);
            this.txtTelephone.TabIndex = 16;
            this.txtTelephone.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // txtCallPhone
            // 
            this.txtCallPhone.Location = new System.Drawing.Point(43, 109);
            this.txtCallPhone.Mask = "000-00000000";
            this.txtCallPhone.Name = "txtCallPhone";
            this.txtCallPhone.Size = new System.Drawing.Size(205, 21);
            this.txtCallPhone.TabIndex = 17;
            this.txtCallPhone.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(43, 137);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(205, 21);
            this.txtEmail.TabIndex = 7;
            // 
            // UserInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.txtCallPhone);
            this.Controls.Add(this.txtTelephone);
            this.Controls.Add(this.pbFavicon);
            this.Controls.Add(this.dtBirthday);
            this.Controls.Add(this.cbSex);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label1);
            this.Name = "UserInfo";
            this.Size = new System.Drawing.Size(416, 190);
            ((System.ComponentModel.ISupportInitialize)(this.pbFavicon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbSex;
        private System.Windows.Forms.DateTimePicker dtBirthday;
        private System.Windows.Forms.PictureBox pbFavicon;
        private System.Windows.Forms.MaskedTextBox txtTelephone;
        private System.Windows.Forms.MaskedTextBox txtCallPhone;
        private System.Windows.Forms.TextBox txtEmail;
    }
}
