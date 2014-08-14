using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Linq;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using Infrastructure;

namespace Model
{
    public class DbHelper
    {
        static readonly string StrSql = ConfigurationManager.ConnectionStrings["SqlConnection"].ToString();
        static readonly SqlConnection Conn = new SqlConnection(StrSql);
        public static SqlConnection Sqlconn()
        {
            if (Conn.State == ConnectionState.Open)
            {
                Conn.Close();
                Conn.Open();
            }
            else if (Conn.State == ConnectionState.Closed)
            {
                Conn.Open();
            }
            else if (Conn.State == ConnectionState.Broken)
            {
                Conn.Close();
                Conn.Open();
            }
            return Conn;
        }

        /// <summary>
        /// 处理Sql
        /// </summary>
        /// <param name="sql">sql语句</param>
        /// <param name="parameters">参数</param>
        /// <returns></returns>
        public static int ExecuteCommand(string sql, SqlParameter[] parameters = null)//执行数据库单向操作：insert、update、delete
        {
            var cmd = new SqlCommand(sql, Sqlconn());
            if (parameters != null)
                cmd.Parameters.AddRange(parameters);
            return cmd.ExecuteNonQuery();
        }

        /// <summary>
        /// 获取表集合
        /// </summary>
        /// <typeparam name="T">表类型</typeparam>
        /// <returns></returns>
        public static List<T> GetTable<T>() where T : class//select
        {
            using (var dc = new DataContext(Sqlconn()))
            {
                return dc.GetTable<T>().Where(p => !((IModel)p).Deleted).ToList();
            }
        }

        /// <summary>
        /// 新增或修改表一行数据
        /// </summary>
        /// <typeparam name="T">表类型</typeparam>
        /// <param name="item">一行表数据</param>
        /// <returns></returns>
        public static int AddOrModifyItem<T>(IModel item) where T : class//AddOrModifyItem
        {
            using (var dc = new DataContext(Sqlconn()))
            {
                var table = dc.GetTable<T>();
                if (item.Id == 0)
                {
                    table.InsertOnSubmit(item as T);
                }
                else
                {
                    var oldItem = table.FirstOrDefault(p => ((IModel)p).Id == item.Id && !((IModel)p).Deleted);
                    if (oldItem != null)
                    {
                        oldItem.CopyFromEx(item as T);
                    }
                    else
                    {
                        return 0;
                    }
                }
                dc.SubmitChanges();
            }
            return Convert.ToInt32(item.Id);
        }

        /// <summary>
        /// 删除一行表数据
        /// </summary>
        /// <typeparam name="T">表类型</typeparam>
        /// <param name="id">一行数据的编号</param>
        /// <returns></returns>
        public static int DeleteItem<T>(int id) where T : class//DeletedItem
        {
            using (var dc = new DataContext(Sqlconn()))
            {
                var table = dc.GetTable<T>();
                dynamic oldItem = table.FirstOrDefault(p => ((IModel)p).Id == id && !((IModel)p).Deleted);
                if (oldItem != null)
                {
                    oldItem.Deleted = true;
                }
                else
                {
                    return 0;
                }
                dc.SubmitChanges();
                return id;
            }
        }
    }
}
