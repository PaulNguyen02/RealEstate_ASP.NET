namespace WebApplication1.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BATDONGSAN")]
    public partial class BATDONGSAN
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public BATDONGSAN()
        {
            PICTURES = new HashSet<PICTURES>();
        }

        [Key]
        public int MABDS { get; set; }

        [StringLength(55)]
        public string TENBDS { get; set; }

        public int? RONG { get; set; }

        public int? DAI { get; set; }

        public int? DIENTICH { get; set; }

        public int? VITRI { get; set; }

        public int? LOAIHINHBDS { get; set; }

        [StringLength(15)]
        public string DIALY { get; set; }

        public int? SOTANG { get; set; }

        public int? SOPHONGNGU { get; set; }

        public int? SOPHONGTAM { get; set; }

        public bool? DICHVU { get; set; }

        public double? GIA { get; set; }

        public int? NVQUANLYBDS { get; set; }

        public int? CHUSOHUU { get; set; }

        public bool? DUOCXAY { get; set; }

        [StringLength(350)]
        public string HINHANH { get; set; }

        public virtual USERS USERS { get; set; }

        public virtual USERS USERS1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PICTURES> PICTURES { get; set; }

        public virtual VITRI VITRI1 { get; set; }

        public virtual LOAIHINHBDS LOAIHINHBDS1 { get; set; }
    }
}
