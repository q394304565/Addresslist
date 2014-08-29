namespace ContactlistManage
{
    partial class BirthdayRemind
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPrev = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnKnow = new System.Windows.Forms.Button();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(227, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "明日为XXX的生日，别忘了送上生日祝福！";
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(246, 3);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 23);
            this.btnNext.TabIndex = 1;
            this.btnNext.Text = "下一个";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPrev
            // 
            this.btnPrev.Location = new System.Drawing.Point(165, 3);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(75, 23);
            this.btnPrev.TabIndex = 0;
            this.btnPrev.Text = "上一个";
            this.btnPrev.UseVisualStyleBackColor = true;
            this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btnNext);
            this.flowLayoutPanel1.Controls.Add(this.btnPrev);
            this.flowLayoutPanel1.Controls.Add(this.btnKnow);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(1, 54);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(324, 34);
            this.flowLayoutPanel1.TabIndex = 3;
            // 
            // btnKnow
            // 
            this.btnKnow.Location = new System.Drawing.Point(84, 3);
            this.btnKnow.Name = "btnKnow";
            this.btnKnow.Size = new System.Drawing.Size(75, 23);
            this.btnKnow.TabIndex = 2;
            this.btnKnow.Text = "知道了";
            this.btnKnow.UseVisualStyleBackColor = true;
            this.btnKnow.Click += new System.EventHandler(this.btnKnow_Click);
            // 
            // BirthdayRemind
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(323, 85);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BirthdayRemind";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "生日提醒";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.BirthdayRemind_FormClosing);
            this.Load += new System.EventHandler(this.BirthdayRemind_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPrev;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnKnow;
    }
}