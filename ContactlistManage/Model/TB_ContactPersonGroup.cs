using System.Data.Linq.Mapping;

namespace Model
{
    /// <summary>
    /// 联系人组
    /// </summary>
    [Table(Name = "TB_ContactPersonGroup")]
    public class TB_ContactPersonGroup : IModel
    {

        /// <summary>
        /// 编号
        /// </summary>	
        [Column(Name = "Id", IsPrimaryKey = true, IsDbGenerated = true)]
        public int Id { get; set; }
        /// <summary>
        /// 名称
        /// </summary>	
        [Column(Name = "Name")]
        public string Name { get; set; }
        /// <summary>
        /// 父级组
        /// </summary>	
        [Column(Name = "ParentId")]
        public int ParentId { get; set; }
        /// <summary>
        /// 所属用户编号
        /// </summary>	
        [Column(Name = "UId")]
        public int UId { get; set; }
        /// <summary>
        /// 是否删除
        /// </summary>	
        [Column(Name = "Deleted")]
        public bool Deleted { get; set; }

    }
}

