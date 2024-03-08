namespace WebApplication1.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("LICHHEN")]
    public partial class LICHHEN
    {
        [Key]
        public int MALICHHEN { get; set; }

        [StringLength(55)]
        public string TENKH { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NGAYHEN { get; set; }

        [StringLength(10)]
        public string SDT { get; set; }

        [StringLength(30)]
        public string EMAIL { get; set; }

        [StringLength(55)]
        public string DIACHI { get; set; }

        [StringLength(30)]
        public string DICHVU { get; set; }

        [StringLength(350)]
        public string GHICHU { get; set; }

        public int? NVTIEPNHAN { get; set; }

        public virtual USERS USERS { get; set; }
    }
}
