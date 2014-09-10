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
        /// 获取用户联系人
        /// </summary>
        /// <param name="uId">用户编号</param>
        /// <returns></returns>
        public List<TB_ContactPerson> GetContactPersonsByUId(int uId)
        {
            using (var sqlcon = new SqlConnection(DbHelper.StrSql))
            {
                sqlcon.Open();
                using (var dc = new DataContext(sqlcon))
                {
                    return dc.GetTable<TB_ContactPerson>().Where(p => !p.Deleted && p.UId == uId).ToList();
                }
            }
        }

        /// <summary>
        /// 获取用户某个分组的联系人
        /// </summary>
        /// <param name="uId">用户编号</param>
        /// <param name="typeId">分组编号</param>
        /// <returns></returns>
        public List<TB_ContactPerson> GetContactPersonsByUIdAndTypeId(int uId, int typeId)
        {
            using (var sqlcon = new SqlConnection(DbHelper.StrSql))
            {
                sqlcon.Open();
                using (var dc = new DataContext(sqlcon))
                {
                    return dc.GetTable<TB_ContactPerson>().Where(p => !p.Deleted && p.UId == uId && p.UType == typeId).ToList();
                }
            }
        }

        /// <summary>
        /// 获取用户的联系人条件搜索
        /// </summary>
        /// <param name="uId">用户编号</param>
        /// <param name="condition">条件</param>
        /// <returns></returns>
        public List<TB_ContactPerson> GetContactPersonsByUIdAndCondition(int uId, string condition)
        {
            using (var sqlcon = new SqlConnection(DbHelper.StrSql))
            {
                sqlcon.Open();
                using (var dc = new DataContext(sqlcon))
                {
                    if (string.IsNullOrEmpty(condition))
                        return dc.GetTable<TB_ContactPerson>().Where(p => !p.Deleted && p.UId == uId).ToList();
                    else
                        return dc.GetTable<TB_ContactPerson>().Where(p => !p.Deleted && p.UId == uId && (p.Name.Contains(condition)
                            || p.Telephone.Contains(condition) || p.Callphone.Contains(condition) || p.Email.Contains(condition))).ToList();
                }
            }
        }

        /// <summary>
        /// 获取用户某个分组的联系人条件搜索
        /// </summary>
        /// <param name="uId">用户编号</param>
        /// <param name="typeId">分组编号</param>
        /// <param name="condition">条件</param>
        /// <returns></returns>
        public List<TB_ContactPerson> GetContactPersonsByCondition(int uId, int typeId, string condition)
        {
            using (var sqlcon = new SqlConnection(DbHelper.StrSql))
            {
                sqlcon.Open();
                using (var dc = new DataContext(sqlcon))
                {
                    if (string.IsNullOrEmpty(condition))
                        return dc.GetTable<TB_ContactPerson>().Where(p => !p.Deleted && p.UId == uId && p.UType == typeId).ToList();
                    else
                        return dc.GetTable<TB_ContactPerson>().Where(p => !p.Deleted && p.UId == uId && p.UType == typeId
                            && (p.Name.Contains(condition) || p.Telephone.Contains(condition) || p.Callphone.Contains(condition) || p.Email.Contains(condition))).ToList();
                }
            }
        }


        /// <summary>
        /// 是否已存在联系人
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name">联系人名称</param>
        /// <param name="uId">所属用户编号</param>
        /// <returns></returns>
        public bool IsExistContactPersonName(int id, int uId, string name)
        {
            using (var sqlcon = new SqlConnection(DbHelper.StrSql))
            {
                sqlcon.Open();
                using (var dc = new DataContext(sqlcon))
                {
                    if (id == 0)
                    {
                        return dc.GetTable<TB_ContactPerson>().Any(p => p.Name == name.Trim() && p.UId == uId);
                    }
                    return dc.GetTable<TB_ContactPerson>().Any(p => p.Name == name.Trim() && p.Id != id && p.UId == uId);
                }
            }
        }

        /// <summary>
        /// 导入联系人
        /// </summary>
        /// <param name="contactPersons"></param>
        public void AddContactPersonsByList(List<TB_ContactPerson> contactPersons)
        {
            using (var sqlcon = new SqlConnection(DbHelper.StrSql))
            {
                sqlcon.Open();
                using (var dc = new DataContext(sqlcon))
                {
                    dc.GetTable<TB_ContactPerson>().InsertAllOnSubmit(contactPersons);
                    dc.SubmitChanges();
                }
            }
        }
    }
}
