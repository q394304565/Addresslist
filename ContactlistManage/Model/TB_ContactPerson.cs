using System.Data.Linq.Mapping;

namespace Model
{
    /// <summary>
    /// 联系人
    /// </summary>
    [Table(Name = "TB_ContactPerson")]
    public class TB_ContactPerson
    {

        /// <summary>
        /// 编号
        /// </summary>	
        [Column(Name = "Id", IsPrimaryKey = true)]
        public int Id { get; set; }
        /// <summary>
        /// 姓名
        /// </summary>	
        [Column(Name = "Name")]
        public string Name { get; set; }
        /// <summary>
        /// 组类型
        /// </summary>	
        [Column(Name = "UType")]
        public int UType { get; set; }
        /// <summary>
        /// 性别
        /// </summary>	
        [Column(Name = "Sex")]
        public int Sex { get; set; }
        /// <summary>
        /// 生日
        /// </summary>	
        [Column(Name = "Birthday")]
        public string Birthday { get; set; }
        /// <summary>
        /// 手机
        /// </summary>	
        [Column(Name = "Callphone")]
        public string Callphone { get; set; }
        /// <summary>
        /// 电话
        /// </summary>	
        [Column(Name = "Telephone")]
        public string Telephone { get; set; }
        /// <summary>
        /// 邮箱
        /// </summary>	
        [Column(Name = "EMail")]
        public string EMail { get; set; }
        /// <summary>
        /// 地址
        /// </summary>	
        [Column(Name = "Address")]
        public string Address { get; set; }
        /// <summary>
        /// 个人头像
        /// </summary>	
        [Column(Name = "Favicon")]
        public byte[] Favicon { get; set; }
        /// <summary>
        /// 是否删除
        /// </summary>	
        [Column(Name = "Deleted")]
        public bool Deleted { get; set; }

    }
}

