using System.Data.Linq.Mapping;

namespace Model
{
    //TB_Gallery
    [Table(Name = "TB_Gallery")]
    public class TB_Gallery : IModel
    {

        /// <summary>
        /// Id
        /// </summary>	
        [Column(Name = "Id", IsPrimaryKey = true, IsDbGenerated = true)]
        public int Id { get; set; }
        /// <summary>
        /// Name
        /// </summary>	
        [Column(Name = "Name")]
        public string Name { get; set; }
        /// <summary>
        /// GImage
        /// </summary>	
        [Column(Name = "GImage")]
        public byte[] GImage { get; set; }
        /// <summary>
        /// UId
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

