using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class Career
    {
        public List<VIECLAM> job { get; set; }
        public List<UNGCUVIEN> candidate { get; set; }
    }
}