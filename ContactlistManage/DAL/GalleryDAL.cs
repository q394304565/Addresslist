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
        /// 获取用户相册
        /// </summary>
        /// <param name="uId">用户编号</param>
        /// <returns></returns>
        public List<TB_Gallery> GetGalleryByUId(int uId)
        {
            using (var dc = new DataContext(DbHelper.Sqlconn()))
            {
                return dc.GetTable<TB_Gallery>().Where(p => !p.Deleted && p.UId == uId).ToList();
            }
        }
    }
}
