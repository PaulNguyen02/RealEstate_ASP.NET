namespace WebApplication1.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class LOAIHINHBDS
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public LOAIHINHBDS()
        {
            BATDONGSAN = new HashSet<BATDONGSAN>();
        }

        [Key]
        public int IDLOAI { get; set; }

        [StringLength(55)]
        public string TENLOAIHINH { get; set; }

        [StringLength(20)]
        public string NHOMLOPBDS { get; set; }

        [StringLength(30)]
        public string MUCDICHSUDUNG { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BATDONGSAN> BATDONGSAN { get; set; }
    }
}
