using System.Collections.Generic;
using DAL;
using Model;

namespace BLL
{
    public class UserBLL : IBLL
    {
        readonly UseDAL _dal = new UseDAL();
        public TB_User Register(TB_User user)
        {
            return _dal.Register(user);
        }

        public TB_User UserLogin(string uName, string password)
        {
           return _dal.UserLogin(uName, password);
        }

        public List<T> GetItems<T>() where T : class
        {
            return DbHelper.GetTable<T>();
        }

        public int AddOrModifyItem<T>(IModel item) where T : class
        {
            return DbHelper.AddOrModifyItem<T>(item);
        }

        public int DeleteItem<T>(int id) where T : class
        {
            return DbHelper.DeleteItem<T>(id);
        }
    }
}
