using System.Collections.Generic;
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

        /// <summary>
        /// 是否已存在联系人组
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name">联系人组名称</param>
        /// <param name="uId">所属用户编号</param>
        /// <returns></returns>
        public bool IsExistContactPersonGroupName(int id, int uId, string name)
        {
            return _dalOperate.IsExistContactPersonGroupName(id, uId, name);
        }
    }
}
