namespace WebApplication1.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("GIAODICHKHACHHANG")]
    public partial class GIAODICHKHACHHANG
    {
        [Key]
        public int MAGD { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NGAYGIAODICH { get; set; }

        public int? BENGIAO { get; set; }

        public int? BENNHAN { get; set; }

        public int? BATDONGSAN { get; set; }

        [Column(TypeName = "date")]
        public DateTime? KYHAN { get; set; }

        public double? DATCOC { get; set; }

        public double? GIA { get; set; }

        public virtual USERS USERS { get; set; }

        public virtual USERS USERS1 { get; set; }
    }
}
