namespace WebApplication1.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("VIECLAM")]
    public partial class VIECLAM
    {
        [Key]
        public int MAVL { get; set; }

        [StringLength(55)]
        public string CHUCVU { get; set; }

        public int? SOLUONGTUYEN { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NGAYDANG { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NGAYHETHAN { get; set; }

        [StringLength(350)]
        public string MOTACV { get; set; }

        public double? LUONG { get; set; }

        public int? QLNHANSU { get; set; }

        public virtual USERS USERS { get; set; }
    }
}
