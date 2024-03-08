namespace WebApplication1.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("VITRI")]
    public partial class VITRI
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public VITRI()
        {
            BATDONGSAN = new HashSet<BATDONGSAN>();
        }

        [Key]
        public int MAVITRI { get; set; }

        [StringLength(35)]
        public string QUAN { get; set; }

        [StringLength(55)]
        public string THANHPHO { get; set; }

        [StringLength(55)]
        public string QUOCGIA { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BATDONGSAN> BATDONGSAN { get; set; }
    }
}
