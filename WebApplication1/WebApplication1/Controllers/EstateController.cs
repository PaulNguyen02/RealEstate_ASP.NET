using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;
namespace WebApplication1.Controllers
{
    public class EstateController : Controller
    {
        private EstateDbContext ectx = new EstateDbContext();
        // GET: Estate
        public ActionResult Index()     //ds bds
        {
            int page = int.Parse(Request.QueryString["page"].ToString());
            int row = 6;
            List<string> countries = new List<string>();
            var estates = ectx.BATDONGSAN.OrderBy(x => x.GIA).Skip((page-1)*row).Take(row).ToList();
            var classify = from typestate in ectx.LOAIHINHBDS select typestate.TENLOAIHINH;
            var loc = from location in ectx.VITRI group location by location.QUOCGIA;
            foreach (var v in loc.ToList())
            {
                countries.Add(v.Key);       //thêm các key của các nhóm vào danh sách
            }
            
            Listestate list = new Listestate();
            list.type = classify.ToList();
            list.country = countries;
            list.estate = estates;
            return View(list);
        }
        public ActionResult FilterbyTypeName()     //ds bds - tìm các loại nhà cửa phổ biến
        {
            int page = int.Parse(Request.QueryString["page"].ToString());
            int row = 6;
            List<string> countries = new List<string>();
            var classify = from typestate in ectx.LOAIHINHBDS select typestate.TENLOAIHINH;
            var loc = from location in ectx.VITRI group location by location.QUOCGIA;
            foreach (var v in loc.ToList())
            {
                countries.Add(v.Key);       //thêm các key của các nhóm vào danh sách
            }
            string type = Request.QueryString["type"].ToString();
            var res = from estate in ectx.BATDONGSAN
                      join typeestate in ectx.LOAIHINHBDS on estate.LOAIHINHBDS equals typeestate.IDLOAI
                      where (estate.LOAIHINHBDS1.TENLOAIHINH.Contains(type))
                      select estate;    // query * khi 2 tập giao nhau
            Listestate list = new Listestate();
            list.type = classify.ToList();
            list.country = countries;
            list.estate = res.OrderBy(x => x.GIA).Skip((page - 1) * row).Take(row).ToList();
            return View(list);
        }          
        public ActionResult FilterbyType(string type)     //ds bds - tìm theo loại hình bds
        {
            int page = int.Parse(Request.QueryString["page"].ToString());
            int row = 6;
            List<string> countries = new List<string>();
            var classify = from typestate in ectx.LOAIHINHBDS select typestate.TENLOAIHINH;
            var loc = from location in ectx.VITRI group location by location.QUOCGIA;
            foreach (var v in loc.ToList())
            {
                countries.Add(v.Key);       //thêm các key của các nhóm vào danh sách
            }
            var res = from estate in ectx.BATDONGSAN
                      join typeestate in ectx.LOAIHINHBDS on estate.LOAIHINHBDS equals typeestate.IDLOAI
                      where (estate.LOAIHINHBDS1.NHOMLOPBDS.Contains(type))
                      select estate;    // query * khi 2 tập giao nhau
            Listestate list = new Listestate();
            list.type = classify.ToList();
            list.country = countries;
            list.estate = res.OrderBy(x => x.GIA).Skip((page - 1) * row).Take(row).ToList();
            return View(list);
        }
        public ActionResult FilterbyCity()     
        {
            int page = int.Parse(Request.QueryString["page"].ToString());
            int row = 6;
            List<string> countries = new List<string>();
            var classify = from typestate in ectx.LOAIHINHBDS select typestate.TENLOAIHINH;
            var loc = from location in ectx.VITRI group location by location.QUOCGIA;
            foreach (var v in loc.ToList())
            {
                countries.Add(v.Key);       //thêm các key của các nhóm vào danh sách
            }
            string city = Request.QueryString["city"].ToString();
            var res = from estate in ectx.BATDONGSAN
                      join location in ectx.VITRI on estate.VITRI equals location.MAVITRI
                      where (estate.VITRI1.THANHPHO.Contains(city))
                      select estate;    // query * khi 2 tập giao nhau*/
            Listestate list = new Listestate();
            list.type = classify.ToList();
            list.country = countries;
            list.estate = res.OrderBy(x => x.GIA).Skip((page - 1) * row).Take(row).ToList();
            return View(list);
        }
        public ActionResult FilterbyProject()     
        {
            int page = int.Parse(Request.QueryString["page"].ToString());
            int row = 6;
            List<string> countries = new List<string>();
            var classify = from typestate in ectx.LOAIHINHBDS select typestate.TENLOAIHINH;
            var loc = from location in ectx.VITRI group location by location.QUOCGIA;
            foreach (var v in loc.ToList())
            {
                countries.Add(v.Key);       //thêm các key của các nhóm vào danh sách
            }
            var res = from estate in ectx.BATDONGSAN                      
                      where (estate.DUOCXAY == false)
                      select estate;    // query * khi 2 tập giao nhau*/
            Listestate list = new Listestate();
            list.type = classify.ToList();
            list.country = countries;
            list.estate = res.OrderBy(x => x.GIA).Skip((page - 1) * row).Take(row).ToList();
            return View(list);
        }
        public ActionResult AdvancedSearch(FormCollection fr)     //ds bds
        {
            List<string> countries = new List<string>();
            var classify = from typestate in ectx.LOAIHINHBDS select typestate.TENLOAIHINH;
            var loc = from location in ectx.VITRI group location by location.QUOCGIA;
            foreach (var v in loc.ToList())
            {
                countries.Add(v.Key);       //thêm các key của các nhóm vào danh sách
            }
            string estate_name = fr["searchbar"];//Request.QueryString["searchbar"].ToString();
            string type = fr["type"];           //Request.QueryString["type"].ToString();
            string country = fr["country"];            //Request.QueryString["country"].ToString();
            var res = from estate in ectx.BATDONGSAN
                      join location in ectx.VITRI on estate.VITRI equals location.MAVITRI
                      join typeestate in ectx.LOAIHINHBDS on estate.LOAIHINHBDS equals typeestate.IDLOAI
                      where (estate.TENBDS.Contains(estate_name) && estate.LOAIHINHBDS1.TENLOAIHINH.Equals(type) && estate.VITRI1.QUOCGIA.Contains(country))
                      select estate;    // query * khi 2 tập giao nhau
            Listestate list = new Listestate();
            list.type = classify.ToList();
            list.country = countries;
            list.estate = res.ToList();
            return View(list);
        }        
        public ActionResult Detail()
        {
            string id = Request.QueryString["id"].ToString();
            int identify = int.Parse(id);
            var res = from picture in ectx.PICTURES where (picture.BDS == identify) select picture.LINKANH;
            var res1 = (from estate in ectx.BATDONGSAN where (estate.MABDS == identify) select 
                           new Estatedetail
                           {
                               TENBDS = estate.TENBDS,
                               DAI = estate.DAI,
                               RONG = estate.RONG,
                               DIENTICH = estate.DIENTICH,
                               VITRI = estate.VITRI1.QUAN + " " + estate.VITRI1.THANHPHO + " " + estate.VITRI1.QUOCGIA,
                               LOAIHINHBDS = estate.LOAIHINHBDS1.TENLOAIHINH,
                               DIALY = estate.DIALY,
                               SOTANG = estate.SOTANG,
                               SOPHONGNGU = estate.SOPHONGNGU,
                               SOPHONGTAM = estate.SOPHONGTAM,
                               DICHVU = estate.DICHVU,
                               GIA = estate.GIA,
                               Picturelist = res.ToList()
                           }).FirstOrDefault();
                                                          
            return View(res1);
        }
    }
}