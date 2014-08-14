using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Model;

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
    }
}
