using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
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

        public List<FileInformation> SkinList
        {
            get { return GetSkin(); }
        }

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

        public SkinEngine SkinEngine { get; set; }

        public UserConfig UserConfig { get; set; }
    }
}
