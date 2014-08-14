using System;
using System.ComponentModel;
using System.Reflection;
using System.Xml.Serialization;

namespace Infrastructure
{
    public static class ObjectEx
    {
        public static T CopyFromEx<T>(this T obj, object fromObj)
        {
            PropertyInfo[] pies = obj.GetType().GetProperties();
            foreach (PropertyInfo pi in pies)
            {
                if (pi.GetGetMethod().IsVirtual)
                    continue;
                object[] objs = pi.GetCustomAttributes(typeof (BrowsableAttribute), false);
                if (objs.Length == 1 && ((BrowsableAttribute) objs[0]).Browsable == false)
                    continue;
                objs = pi.GetCustomAttributes(typeof (XmlIgnoreAttribute), false);
                if (objs.Length == 1)
                    continue;
                PropertyInfo pi2 = fromObj.GetType().GetProperty(pi.Name);
                if (pi2 != null && pi.CanWrite)
                {
                    pi.SetValue(obj, pi2.GetValue(fromObj, null), null);
                }
            }
            return obj;
        }

        #region 类型转换
        public static int? ToInt32(this object obj)
        {
            int? ret = null;
            try
            {
                ret = Convert.ToInt32(obj);
            }
            catch (Exception)
            {
                
            }
            return ret;
        }
        public static decimal? ToDecimal(this object obj)
        {
            decimal? ret = null;
            try
            {
                ret = Convert.ToDecimal(obj);
            }
            catch (Exception)
            {

            }
            return ret;
        }
        #endregion
    }
}