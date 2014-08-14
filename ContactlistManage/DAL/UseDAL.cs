using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Linq;
using System.Text;
using Model;

namespace DAL
{
    public partial class DALOperate
    {
        /// <summary>
        /// 验证用户登录
        /// </summary>
        /// <param name="uName">用户名</param>
        /// <param name="password">密码</param>
        /// <returns></returns>
        public TB_User UserLogin(string uName, string password)
        {
            using (var dc = new DataContext(DbHelper.Sqlconn()))
            {
                return dc.GetTable<TB_User>().FirstOrDefault(p => p.UName == uName.ToLower() && p.Password == password && !p.Deleted);
            }
        }

        /// <summary>
        /// 检查用户名是否存在
        /// </summary>
        /// <param name="uName">用户名</param>
        /// <returns></returns>
        public bool CheckUserName(string uName)
        {
            using (var dc = new DataContext(DbHelper.Sqlconn()))
            {
                return dc.GetTable<TB_User>().Any(p => p.UName == uName.ToLower() && !p.Deleted);
            }
        }

        /// <summary>
        /// 注册用户
        /// </summary>
        /// <param name="user">用户信息</param>
        /// <returns></returns>
        public TB_User Register(TB_User user)
        {
            var id = DbHelper.AddOrModifyItem<TB_User>(user);
            return GetUserById(id);
        }

        /// <summary>
        /// 通过编号获取用户信息
        /// </summary>
        /// <param name="id">用户编号</param>
        /// <returns></returns>
        public TB_User GetUserById(int id)
        {
            using (var dc = new DataContext(DbHelper.Sqlconn()))
            {
                return dc.GetTable<TB_User>().FirstOrDefault(p => p.Id == id && !p.Deleted);
            }
        }
    }
}
