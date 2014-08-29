using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Model;
using Sunisoft.IrisSkin;

namespace Infrastructure
{
    public class GlobalData
    {
        private static GlobalData _globalData;
        public static GlobalData Current
        {
            get { return _globalData ?? (_globalData = new GlobalData()); }
        }

        public TB_User CurrentUser { get; set; }

        private object _bllOperate;
        public T BllOperate<T>() where T : class,new()
        {
            if (_bllOperate != null)
            {
                return _bllOperate as T;
            }
            else
            {
                _bllOperate = new T();
                return _bllOperate as T;
            }
        }

        /// <summary>
        /// 皮肤列表
        /// </summary>
        public List<FileInformation> SkinList
        {
            get { return GetSkin(); }
        }

        /// <summary>
        /// 获取皮肤列表
        /// </summary>
        /// <returns></returns>
        public List<FileInformation> GetSkin()
        {
            var path = Path.Combine(Environment.CurrentDirectory + "\\Skin");
            if (!Directory.Exists(path))
                Directory.CreateDirectory(path);
            var files = Directory.GetFiles(path, "*.ssk", SearchOption.AllDirectories);
            var fileinfos = new List<FileInformation>();
            foreach (var file in files)
            {
                fileinfos.Add(new FileInformation { Name = Path.GetFileNameWithoutExtension(file), FilePath = file });
            }
            return fileinfos;
        }


        /// <summary>
        /// 设置图像
        /// </summary>
        /// <param name="pictureBox"></param>
        /// <param name="bytes"></param>
        public void SetImage(PictureBox pictureBox, byte[] bytes)
        {
            using (var myStream = new MemoryStream())
            {
                foreach (byte a in bytes)
                {
                    myStream.WriteByte(a);
                }
                var myImage = Image.FromStream(myStream);
                myStream.Close();
                pictureBox.Image = myImage;
            }
        }

        /// <summary>
        /// 获取性别
        /// </summary>
        /// <param name="sexType"></param>
        /// <returns></returns>
        public string GetSex(int sexType)
        {
            switch ((SexType)sexType)
            {
                case SexType.Lady:
                    return "女";
                case SexType.Man:
                    return "男";
                default:
                    return "无";
            }
        }

        public SkinEngine SkinEngine { get; set; }

        /// <summary>
        /// 用户配置信息
        /// </summary>
        public UserConfig UserConfig { get; set; }
    }
}
