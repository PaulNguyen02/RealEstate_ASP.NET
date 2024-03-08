using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class Estatedetail
    {
        public string TENBDS { get; set; }
        public int? DAI { get; set; }
        public int? RONG { get; set; }
        public int? DIENTICH { get; set; }
        public string VITRI { get; set; }
        public string LOAIHINHBDS { get; set; }
        public string DIALY { get; set; }
        public int? SOTANG { get; set; }
        public int? SOPHONGNGU { get; set; }
        public int? SOPHONGTAM { get; set; }
        public bool? DICHVU { get; set; }
        public double? GIA { get; set; }
        public List<string> Picturelist { get; set; }
    }
}