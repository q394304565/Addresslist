using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BLL;
using Infrastructure;

namespace ContactlistManage
{
    public class FormBase : Form
    {
        protected BLLOperate BLLOperate { get { return GlobalData.Current.BllOperate<BLLOperate>(); } }

        /// <summary>
        /// 验证非空
        /// </summary>
        /// <param name="textBox"></param>
        /// <param name="message"></param>
        /// <param name="name"></param>
        /// <returns></returns>
        protected bool VerifyRequired(TextBox textBox, Label message = null, string name = null)
        {
            if (string.IsNullOrWhiteSpace(textBox.Text))
            {
                if (message != null)
                {
                    message.ForeColor = Color.Red;
                    message.Text = string.Format("{0}不能为空", name);
                }
                textBox.Focus();
                return true;
            }
            return false;
        }

        /// <summary>
        /// 验证字符长度
        /// </summary>
        /// <param name="textBox"></param>
        /// <param name="length"></param>
        /// <param name="message"></param>
        /// <param name="name"></param>
        /// <returns></returns>
        protected bool VerifyStringLength(TextBox textBox, int length, Label message = null, string name = null)
        {
            if (textBox.Text.Length >= length)
            {
                if (message != null)
                {
                    message.ForeColor = Color.Red;
                    message.Text = string.Format("{0}长度不能超过{1}个字符", name, length);
                }
                textBox.Focus();
                return true;
            }
            return false;
        }

        /// <summary>
        /// 处理数据
        /// </summary>
        /// <param name="action">处理方法</param>
        /// <param name="errorAction">错误处理方法</param>
        protected void HandleData(Action action, Action<string> errorAction = null)
        {
            try
            {
                if (action != null) action();
            }
            catch (Exception ex)
            {
                if (errorAction != null)
                {
                    errorAction(ex.Message);
                }
            }
        }


    }
}
