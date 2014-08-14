using System.Collections.Generic;
using DAL;
using Model;

namespace BLL
{
    public partial class BLLOperate
    {
        /// <summary>
        /// 注册用户
        /// </summary>
        /// <param name="user">用户信息</param>
        /// <returns></returns>
        public TB_User Register(TB_User user)
        {
            return _dalOperate.Register(user);
        }

        /// <summary>
        /// 验证用户登录
        /// </summary>
        /// <param name="uName">用户名</param>
        /// <param name="password">密码</param>
        /// <returns></returns>
        public TB_User UserLogin(string uName, string password)
        {
            return _dalOperate.UserLogin(uName, password);
        }

        /// <summary>
        /// 检查用户名是否存在
        /// </summary>
        /// <param name="uName">用户名</param>
        /// <returns></returns>
        public bool CheckUserName(string uName)
        {
            return _dalOperate.CheckUserName(uName);
        }
    }
}
