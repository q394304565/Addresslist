using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Data.SqlClient;
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
            using (var sqlcon = new SqlConnection(DbHelper.StrSql))
            {
                sqlcon.Open();
                using (var dc = new DataContext(sqlcon))
                {
                    return
                        dc.GetTable<TB_User>().FirstOrDefault(
                            p => p.UName == uName.ToLower() && p.Password == password && !p.Deleted);
                }
            }
        }

        /// <summary>
        /// 创建初始管理员
        /// </summary>
        public void CreateAdminUser()
        {
            using (var sqlcon = new SqlConnection(DbHelper.StrSql))
            {
                sqlcon.Open();
                using (var dc = new DataContext(sqlcon))
                {
                    var isExistUser = dc.GetTable<TB_User>().Any(p => !p.Deleted);
                    if (!isExistUser)
                    {
                        var user = new TB_User {UName="admin", Name="管理员", Password="111111" };
                        dc.GetTable<TB_User>().InsertOnSubmit(user);
                        dc.SubmitChanges();
                    }
                }
            }
        }

        /// <summary>
        /// 检查用户名是否存在
        /// </summary>
        /// <param name="uName">用户名</param>
        /// <returns></returns>
        public bool CheckUserName(string uName)
        {
            using (var sqlcon = new SqlConnection(DbHelper.StrSql))
            {
                sqlcon.Open();
                using (var dc = new DataContext(sqlcon))
                {
                    return dc.GetTable<TB_User>().Any(p => p.UName == uName.ToLower() && !p.Deleted);
                }
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
        /// 修改密码
        /// </summary>
        /// <param name="uId">用户编号</param>
        /// <param name="password">新密码</param>
        /// <returns></returns>
        public bool ModifyPassword(int uId, string password)
        {
            using (var sqlcon = new SqlConnection(DbHelper.StrSql))
            {
                sqlcon.Open();
                using (var dc = new DataContext(sqlcon))
                {
                    var user = dc.GetTable<TB_User>().FirstOrDefault(p => p.Id == uId && !p.Deleted);
                    if (user != null)
                    {
                        user.Password = password;
                    }
                    dc.SubmitChanges();
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// 通过编号获取用户信息
        /// </summary>
        /// <param name="id">用户编号</param>
        /// <returns></returns>
        public TB_User GetUserById(int id)
        {
            using (var sqlcon = new SqlConnection(DbHelper.StrSql))
            {
                sqlcon.Open();
                using (var dc = new DataContext(sqlcon))
                {
                    return dc.GetTable<TB_User>().FirstOrDefault(p => p.Id == id && !p.Deleted);
                }
            }
        }
    }
}
