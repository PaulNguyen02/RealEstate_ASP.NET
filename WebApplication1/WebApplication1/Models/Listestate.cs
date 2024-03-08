using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class Listestate
    {
        public List<string> country { get; set; }
        public List<string> type { get; set; }
        public List<BATDONGSAN> estate { get; set; }
    }
}