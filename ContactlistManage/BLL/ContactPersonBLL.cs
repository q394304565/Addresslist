using System.Collections.Generic;
using Model;

namespace BLL
{
    public partial class BLLOperate
    {
        /// <summary>
        /// 获取用户联系人
        /// </summary>
        /// <param name="uId">用户编号</param>
        /// <returns></returns>
        public List<TB_ContactPerson> GetContactPersonsByUId(int uId)
        {
            return _dalOperate.GetContactPersonsByUId(uId);
        }
    }
}
