using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Infrastructure;

namespace ContactlistManage
{
    public partial class BirthdayRemind : FormBase
    {
        public BirthdayRemind()
        {
            InitializeComponent();
        }

        public List<BirthdayContent> BirthdayContents { get; set; }

        private int _currentIndex;
        private void BirthdayRemind_Load(object sender, EventArgs e)
        {
            if (BirthdayContents.Count == 1)
            {
                btnPrev.Visible = false;
                btnNext.Visible = false;
            }
            else
            {
                btnPrev.Enabled = false;
            }
            label1.Text = BirthdayContents[_currentIndex].Content;
        }

        /// <summary>
        /// 上一个
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPrev_Click(object sender, EventArgs e)
        {
            _currentIndex--;
            if (_currentIndex == 0)
            {
                btnPrev.Enabled = false;
                btnNext.Enabled = true;
            }
            label1.Text = BirthdayContents[_currentIndex].Content;
        }

        /// <summary>
        /// 下一个
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnNext_Click(object sender, EventArgs e)
        {
            _currentIndex++;
            if (_currentIndex == BirthdayContents.Count - 1)
            {
                btnPrev.Enabled = true;
                btnNext.Enabled = false;
            }
            label1.Text = BirthdayContents[_currentIndex].Content;
        }

        private void BirthdayRemind_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show(this, "关闭后今日不再提醒！", "关闭提醒", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
            {
                GlobalData.Current.UserConfig.IsNotRemind = true;
            }
            else
            {
                GlobalData.Current.UserConfig.IsNotRemind = false;
            }
        }
    }
}
