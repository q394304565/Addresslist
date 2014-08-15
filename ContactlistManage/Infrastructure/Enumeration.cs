using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace Infrastructure
{
    /// <summary>
    /// 性别类型
    /// </summary>
    public enum SexType
    {
        [Description("无")]
        None,
        [Description("男")]
        Man,
        [Description("女")]
        Lady
    }

    /// <summary>
    /// 用户类型
    /// </summary>
    public enum UserType
    {
        [Description("普通用户")]
        Normal,
        [Description("管理员")]
        Manage
    }
}
