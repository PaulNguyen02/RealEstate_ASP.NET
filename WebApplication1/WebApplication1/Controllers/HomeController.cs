using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;
namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        private EstateDbContext ectx = new EstateDbContext();
        public ActionResult Index()
        {
            List<int> l = new List<int>();
            List<string> countries = new List<string>();
            List<string> cities = new List<string>();
            var citycount = from estate in ectx.BATDONGSAN join location in ectx.VITRI on estate.VITRI equals location.MAVITRI
                            group estate by estate.VITRI1.THANHPHO;
            var type = from typestate in ectx.LOAIHINHBDS select typestate.TENLOAIHINH;
            var item = from items in ectx.BATDONGSAN select items.TENBDS;
            var loc = from location in ectx.VITRI group location by location.QUOCGIA;  // nhóm theo quốc gia         
            foreach (var v in loc.ToList())
            {
                countries.Add(v.Key);       //thêm các key của các nhóm vào danh sách
            }           
            foreach (var group in citycount.ToList())
            {
                l.Add(group.Count());
            }
            MyViewModel viewModel = new MyViewModel();
            viewModel.Data1 = l;
            viewModel.Data2 = countries;
            viewModel.Data3 = type.ToList();
            viewModel.Data4 = item.Take(5).ToList();
            return View(viewModel);
        }
        
            public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";
            return View();
        }

        public ActionResult Blog()
        {
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";
            return View();
        }
    }
}