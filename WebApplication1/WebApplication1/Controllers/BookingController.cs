using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;
namespace WebApplication1.Controllers
{
    public class BookingController : Controller
    {
        private EstateDbContext ectx = new EstateDbContext();
        // GET: Booking
        [HttpPost]
        public ActionResult Book(FormCollection fr)
        {
            string name = fr["name"];
            string date = fr["date"];
            string tel = fr["telephone"];
            string email = fr["email"];
            string service = fr["service"];
            string address = fr["address"];
            string notation = fr["notation"];
            var schedule = new LICHHEN()
            {
                TENKH = name,
                NGAYHEN = DateTime.Parse(date),
                SDT = tel,
                EMAIL = email,
                DICHVU = service,
                DIACHI = address,
                GHICHU = notation,
                NVTIEPNHAN = 3
            };
            ectx.LICHHEN.Add(schedule);
            ectx.SaveChanges();
            return Redirect("/Home/Contact");
        }
    }
}