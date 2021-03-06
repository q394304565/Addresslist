﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Model;

namespace BLL
{
    public partial class BLLOperate
    {
        /// <summary>
        /// 获取用户相册
        /// </summary>
        /// <param name="uId">用户编号</param>
        /// <returns></returns>
        public List<TB_Gallery> GetGalleryByUId(int uId)
        {
            return _dalOperate.GetGalleryByUId(uId);
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
            return _dalOperate.IsExistGalleryName(id, uId, name);
        }
    }
}
