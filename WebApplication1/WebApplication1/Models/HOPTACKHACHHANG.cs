namespace WebApplication1.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("HOPTACKHACHHANG")]
    public partial class HOPTACKHACHHANG
    {
        [Key]
        public int MAHD { get; set; }

        public int? NHANVIENKY { get; set; }

        public int? KHACHHANG { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NGAYKY { get; set; }

        public double? GIABDS { get; set; }

        public double? TILEHOAHONG { get; set; }

        public double? PHIHOAHONG { get; set; }

        public virtual USERS USERS { get; set; }

        public virtual USERS USERS1 { get; set; }
    }
}
