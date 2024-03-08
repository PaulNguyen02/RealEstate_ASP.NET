using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.IO;
using WebApplication1.Models;
namespace WebApplication1.Controllers
{
    public class CareersController : Controller
    {
        private EstateDbContext ectx = new EstateDbContext();
        public ActionResult Apply()
        {          
            var jobs = from p in ectx.VIECLAM select p;
            Career cr = new Career();
            cr.job = jobs.ToList();
            return View(cr);
        }
        [HttpPost]
        public ActionResult Apply(HttpPostedFileBase uploadFile, FormCollection fr)
        {
            var jobs = from p in ectx.VIECLAM select p; /*Do trả về View cần phải có 1 bộ dữ liệu nên phãi query lại*/
            Career cr = new Career();
            cr.job = jobs.ToList();
            string phone = fr["Phone"];                       
            try
            {
                int num = ectx.UNGCUVIEN.Count(count => count.SDT == phone);        //tên người dùng phải là duy nhất nên phải kiểm tra trước
                if (num > 0)
                {
                    ViewBag.Message = "You have sent apply form, please wait for few days to get result !";                    
                }
                else
                {
                    var candidate = new UNGCUVIEN()
                    {
                        HOTEN = fr["Name"],
                        NGAYSINH = DateTime.Parse(fr["Dob"]),
                        DIACHI = fr["Address"],
                        SDT = fr["Phone"],
                        EMAIL = fr["Email"],
                        CHUCVU = fr["Position"],
                        NAMKINHNGHIEM = int.Parse(fr["Experience"]),
                        QLNS = 2
                    };
                    ectx.UNGCUVIEN.Add(candidate);
                    ectx.SaveChanges();
                    if (uploadFile != null &&  uploadFile.ContentLength > 0)
                    {
                        string _FileName = Path.GetFileName(uploadFile.FileName);
                        string _path = Path.Combine(Server.MapPath("~/UploadedFiles"), _FileName);
                        uploadFile.SaveAs(_path);
                    }
                    ViewBag.Message = "File Uploaded Successfully !";
                }                
            }
            catch
            {
                ViewBag.Message = "File upload failed !";               
            }
            return View(cr);
        }
        
    }
}