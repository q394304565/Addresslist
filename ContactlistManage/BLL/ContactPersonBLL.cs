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

        /// <summary>
        /// 是否已存在联系人
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name">联系人名称</param>
        /// <param name="uId">所属用户编号</param>
        /// <returns></returns>
        public bool IsExistContactPersonName(int id, int uId, string name)
        {
            return _dalOperate.IsExistContactPersonName(id, uId, name);
        }

        /// <summary>
        /// 获取用户某个分组的联系人
        /// </summary>
        /// <param name="uId">用户编号</param>
        /// <param name="typeId">分组编号</param>
        /// <returns></returns>
        public List<TB_ContactPerson> GetContactPersonsByUIdAndTypeId(int uId, int typeId)
        {
            return _dalOperate.GetContactPersonsByUIdAndTypeId(uId, typeId);
        }

                /// <summary>
        /// 导入联系人
        /// </summary>
        /// <param name="contactPersons"></param>
        public void AddContactPersonsByList(List<TB_ContactPerson> contactPersons)
        {
            _dalOperate.AddContactPersonsByList(contactPersons);
        }
    }
}
