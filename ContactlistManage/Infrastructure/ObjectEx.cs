using System;
using System.ComponentModel;
using System.IO;
using System.Reflection;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Serialization;

namespace Infrastructure
{
    public static class ObjectEx
    {
        /// <summary>
        /// 复制属性
        /// </summary>
        /// <typeparam name="T">类型</typeparam>
        /// <param name="obj">自己</param>
        /// <param name="fromObj">来源</param>
        /// <returns></returns>
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

        /// <summary>
        /// 转换成byte[]
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public static byte[] ToBinary(object obj)
        {
            using (var ms = new MemoryStream())
            {
                var formatter = new BinaryFormatter();
                formatter.Serialize(ms, obj);
                ms.Close();
                return ms.ToArray();
            }
        }

        /// <summary>
        /// 转换成对应类型
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="bt"></param>
        /// <returns></returns>
        public static T FromBinary<T>(byte[] bt)
        {
            using (var ms = new MemoryStream())
            {
                ms.Write(bt, 0, bt.Length);
                ms.Seek(0, SeekOrigin.Begin);
                var formatter = new BinaryFormatter();
                var ret = (T)formatter.Deserialize(ms);
                ms.Close();
                return ret;
            }
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