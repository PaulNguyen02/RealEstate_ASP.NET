using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class Userdetail
    {
        public string name { get; set; }
        public DateTime dob { get; set; }
        public string address { get; set; }
        public string phonenumber { get; set; }
        public string email { get; set; }
        public string username { get; set; }
        public int iscustomer { get; set; }
    }
}