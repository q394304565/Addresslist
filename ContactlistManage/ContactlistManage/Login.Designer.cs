namespace ContactlistManage
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUName = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnRegister = new System.Windows.Forms.Button();
            this.lbMessage = new System.Windows.Forms.Label();
            this.skinEngine1 = new Sunisoft.IrisSkin.SkinEngine(((System.ComponentModel.Component)(this)));
            this.cbRemindName = new System.Windows.Forms.CheckBox();
            this.cbRemindPassword = new System.Windows.Forms.CheckBox();
            this.lbtitle = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "用户名";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(65, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "密码";
            // 
            // txtUName
            // 
            this.txtUName.Location = new System.Drawing.Point(101, 100);
            this.txtUName.Name = "txtUName";
            this.txtUName.Size = new System.Drawing.Size(152, 21);
            this.txtUName.TabIndex = 2;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(100, 139);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(152, 21);
            this.txtPassword.TabIndex = 3;
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(74, 228);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(75, 23);
            this.btnLogin.TabIndex = 4;
            this.btnLogin.Text = "登录";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(174, 228);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(75, 23);
            this.btnRegister.TabIndex = 5;
            this.btnRegister.Text = "注册";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // lbMessage
            // 
            this.lbMessage.AutoSize = true;
            this.lbMessage.ForeColor = System.Drawing.Color.Red;
            this.lbMessage.Location = new System.Drawing.Point(70, 172);
            this.lbMessage.Name = "lbMessage";
            this.lbMessage.Size = new System.Drawing.Size(0, 12);
            this.lbMessage.TabIndex = 13;
            // 
            // skinEngine1
            // 
            this.skinEngine1.SerialNumber = "";
            this.skinEngine1.SkinFile = null;
            // 
            // cbRemindName
            // 
            this.cbRemindName.AutoSize = true;
            this.cbRemindName.Location = new System.Drawing.Point(74, 196);
            this.cbRemindName.Name = "cbRemindName";
            this.cbRemindName.Size = new System.Drawing.Size(84, 16);
            this.cbRemindName.TabIndex = 14;
            this.cbRemindName.Text = "记住用户名";
            this.cbRemindName.UseVisualStyleBackColor = true;
            // 
            // cbRemindPassword
            // 
            this.cbRemindPassword.AutoSize = true;
            this.cbRemindPassword.Location = new System.Drawing.Point(174, 196);
            this.cbRemindPassword.Name = "cbRemindPassword";
            this.cbRemindPassword.Size = new System.Drawing.Size(72, 16);
            this.cbRemindPassword.TabIndex = 15;
            this.cbRemindPassword.Text = "记住密码";
            this.cbRemindPassword.UseVisualStyleBackColor = true;
            this.cbRemindPassword.CheckedChanged += new System.EventHandler(this.cbRemindPassword_CheckedChanged);
            // 
            // lbtitle
            // 
            this.lbtitle.AutoSize = true;
            this.lbtitle.Font = new System.Drawing.Font("幼圆", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbtitle.Location = new System.Drawing.Point(87, 30);
            this.lbtitle.Name = "lbtitle";
            this.lbtitle.Size = new System.Drawing.Size(230, 29);
            this.lbtitle.TabIndex = 16;
            this.lbtitle.Text = "通讯录管理系统";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(24, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(48, 48);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(329, 263);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbtitle);
            this.Controls.Add(this.cbRemindPassword);
            this.Controls.Add(this.cbRemindName);
            this.Controls.Add(this.lbMessage);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "用户登录";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUName;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Label lbMessage;
        private Sunisoft.IrisSkin.SkinEngine skinEngine1;
        private System.Windows.Forms.CheckBox cbRemindName;
        private System.Windows.Forms.CheckBox cbRemindPassword;
        private System.Windows.Forms.Label lbtitle;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}