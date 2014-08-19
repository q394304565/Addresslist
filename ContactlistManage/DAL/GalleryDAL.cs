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
        /// 获取用户相册
        /// </summary>
        /// <param name="uId">用户编号</param>
        /// <returns></returns>
        public List<TB_Gallery> GetGalleryByUId(int uId)
        {
            using (var sqlcon = new SqlConnection(DbHelper.StrSql))
            {
                sqlcon.Open();
                using (var dc = new DataContext(sqlcon))
                {
                    return dc.GetTable<TB_Gallery>().Where(p => !p.Deleted && p.UId == uId).ToList();
                }
            }
        }

        /// <summary>
        /// 是否已存在该照片
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name">照片名称</param>
        /// <param name="uId">所属用户编号</param>
        /// <returns></returns>
        public bool IsExistGalleryName(int id, int uId, string name)
        {
            using (var sqlcon = new SqlConnection(DbHelper.StrSql))
            {
                sqlcon.Open();
                using (var dc = new DataContext(sqlcon))
                {
                    if (id == 0)
                    {
                        return dc.GetTable<TB_Gallery>().Any(p => p.Name == name.Trim() && p.UId == uId);
                    }
                    return dc.GetTable<TB_Gallery>().Any(p => p.Name == name.Trim() && p.Id != id && p.UId == uId);
                }
            }
        }
    }
}
