using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using BLL;
using Infrastructure;
using Model;

namespace ContactlistManage
{
    public class FormBase : Form
    {
        protected bool IsLoaded;
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

        private bool RegexVerifyValue(string regex, TextBoxBase textBox, Label message = null, string name = null)
        {
            if (!string.IsNullOrWhiteSpace(textBox.Text))
            {
                var str = textBox.Text.Trim();
                var reg = new Regex(regex);
                if (!reg.IsMatch(str))
                {
                    if (message != null)
                    {
                        message.ForeColor = Color.Red;
                        message.Text = string.Format("{0}格式有误", name);
                    }
                    textBox.Focus();
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// 验证手机号
        /// </summary>
        /// <param name="textBox"></param>
        /// <param name="message"></param>
        /// <param name="name"></param>
        /// <returns></returns>
        protected bool VerifyCallPhone(TextBoxBase textBox, Label message = null, string name = null)
        {
            return RegexVerifyValue(@"^1\d{10}$", textBox, message, name);
        }

        /// <summary>
        /// 验证电话号码
        /// </summary>
        /// <param name="textBox"></param>
        /// <param name="message"></param>
        /// <param name="name"></param>
        /// <returns></returns>
        protected bool VerifyTelePhone(TextBoxBase textBox, Label message = null, string name = null)
        {
            return RegexVerifyValue(@"^\d{9,12}$", textBox, message, name);
        }

        /// <summary>
        /// 验证电子邮箱
        /// </summary>
        /// <param name="textBox"></param>
        /// <param name="message"></param>
        /// <param name="name"></param>
        /// <returns></returns>
        protected bool VerifyEmail(TextBox textBox, Label message = null, string name = null)
        {
            return RegexVerifyValue("/^([a-zA-Z0-9_-])+@([a-zA-Z0-9_-])+(.[a-zA-Z0-9_-])+/", textBox, message, name);
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

        public FormBase()
        {
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBase));
            Icon = ((Icon)(resources.GetObject("$this.Icon")));
        }

        /// <summary>
        /// 相册列表
        /// </summary>
        /// <param name="listView1"></param>
        /// <returns></returns>
        public void GetGallery(ListView listView1)
        {
            HandleData(() =>
            {
                var gallerys = BLLOperate.GetGalleryByUId(GlobalData.Current.CurrentUser.Id);
                var imageList = new ImageList()
                {
                    ImageSize = new Size(80, 80),
                    ColorDepth = ColorDepth.Depth32Bit
                };
                listView1.BeginUpdate();
                for (int i = 0; i < gallerys.Count; i++)
                {
                    using (var myStream = new MemoryStream())
                    {
                        foreach (byte a in gallerys[i].GImage)
                        {
                            myStream.WriteByte(a);
                        }
                        var myImage = Image.FromStream(myStream);
                        Image.GetThumbnailImageAbort myCallback = ThumbnailCallback;
                        imageList.Images.Add(myImage.GetThumbnailImage(80, 80, myCallback, IntPtr.Zero));
                        myStream.Close();
                    }
                    listView1.Items.Add(gallerys[i].Name, i).Tag = gallerys[i];
                }
                listView1.LargeImageList = imageList;
                listView1.EndUpdate();
            }, s => MessageBox.Show(this, s));
        }

        private bool ThumbnailCallback() { return false; }
    }
}
