namespace WebApplication1.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("UNGCUVIEN")]
    public partial class UNGCUVIEN
    {
        [Key]
        public int MAUC { get; set; }

        [StringLength(55)]
        public string HOTEN { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NGAYSINH { get; set; }

        [StringLength(55)]
        public string DIACHI { get; set; }

        [StringLength(10)]
        public string SDT { get; set; }

        [StringLength(30)]
        public string EMAIL { get; set; }

        [StringLength(25)]
        public string CHUCVU { get; set; }

        public int? NAMKINHNGHIEM { get; set; }

        public int? QLNS { get; set; }

        public virtual USERS USERS { get; set; }
    }
}
