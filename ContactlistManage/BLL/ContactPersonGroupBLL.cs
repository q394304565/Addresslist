using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Model;

namespace BLL
{
    public partial class BLLOperate
    {
        /// <summary>
        /// 获取用户联系人组
        /// </summary>
        /// <param name="uId">用户编号</param>
        /// <returns></returns>
        public List<TB_ContactPersonGroup> GetContactPersonGroupsByUId(int uId)
        {
            return _dalOperate.GetContactPersonGroupsByUId(uId);
        }
    }
}
