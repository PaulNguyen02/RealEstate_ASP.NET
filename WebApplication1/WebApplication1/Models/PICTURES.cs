namespace WebApplication1.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PICTURES
    {
        [Key]
        public int PICTUREID { get; set; }

        [StringLength(350)]
        public string LINKANH { get; set; }

        public int? BDS { get; set; }

        public virtual BATDONGSAN BATDONGSAN { get; set; }
    }
}
