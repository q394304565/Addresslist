using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAL;
using Model;

namespace BLL
{
    public partial class BLLOperate
    {
        readonly DALOperate _dalOperate=new DALOperate();
        /// <summary>
        /// 获取表集合
        /// </summary>
        /// <typeparam name="T">表类型</typeparam>
        /// <returns></returns>
        public List<T> GetItems<T>() where T : class
        {
            return DbHelper.GetTable<T>();
        }

        /// <summary>
        /// 新增或修改表一行数据
        /// </summary>
        /// <typeparam name="T">表类型</typeparam>
        /// <param name="item">一行表数据</param>
        /// <returns></returns>
        public int AddOrModifyItem<T>(IModel item) where T : class
        {
            return DbHelper.AddOrModifyItem<T>(item);
        }

        /// <summary>
        /// 删除一行表数据
        /// </summary>
        /// <typeparam name="T">表类型</typeparam>
        /// <param name="id">一行数据的编号</param>
        /// <returns></returns>
        public int DeleteItem<T>(int id) where T : class
        {
            return DbHelper.DeleteItem<T>(id);
        }
    }
}
