namespace WebApplication1.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class USERS
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public USERS()
        {
            BATDONGSAN = new HashSet<BATDONGSAN>();
            BATDONGSAN1 = new HashSet<BATDONGSAN>();
            GIAODICHKHACHHANG = new HashSet<GIAODICHKHACHHANG>();
            GIAODICHKHACHHANG1 = new HashSet<GIAODICHKHACHHANG>();
            HOPTACKHACHHANG = new HashSet<HOPTACKHACHHANG>();
            HOPTACKHACHHANG1 = new HashSet<HOPTACKHACHHANG>();
            LICHHEN = new HashSet<LICHHEN>();
            UNGCUVIEN = new HashSet<UNGCUVIEN>();
            VIECLAM = new HashSet<VIECLAM>();
        }

        [Key]
        public int USID { get; set; }

        [StringLength(35)]
        public string TEN { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NGAYSINH { get; set; }

        [StringLength(55)]
        public string DIACHI { get; set; }

        [StringLength(10)]
        public string SDT { get; set; }

        [StringLength(30)]
        public string EMAIL { get; set; }

        [StringLength(15)]
        public string TENNGUOIDUNG { get; set; }

        [StringLength(15)]
        public string MATKHAU { get; set; }

        public int? QUYEN { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BATDONGSAN> BATDONGSAN { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BATDONGSAN> BATDONGSAN1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GIAODICHKHACHHANG> GIAODICHKHACHHANG { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GIAODICHKHACHHANG> GIAODICHKHACHHANG1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HOPTACKHACHHANG> HOPTACKHACHHANG { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HOPTACKHACHHANG> HOPTACKHACHHANG1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LICHHEN> LICHHEN { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UNGCUVIEN> UNGCUVIEN { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<VIECLAM> VIECLAM { get; set; }
    }
}
