using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;
namespace WebApplication1.Controllers
{
    public class AccountController : Controller
    {
        // GET: Account
        private EstateDbContext ectx = new EstateDbContext();
        public ActionResult Signin()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Signin(FormCollection fc)
        {
            string username = fc["username"];
            string pass = fc["password"];
            int count = (from user in ectx.USERS where (user.TENNGUOIDUNG.Contains(username) && user.MATKHAU.Contains(pass) && user.QUYEN == 0) select user.TENNGUOIDUNG).Count();
            if (count == 1)
            {
                var list = (from user in ectx.USERS where (user.TENNGUOIDUNG.Contains(username) && user.MATKHAU.Contains(pass) && user.QUYEN == 0) select user).Single();
                Session["user_name"] = list.TENNGUOIDUNG;
                Session["uid"] = list.USID;
                return Redirect("/Home/Index?uid=" + list.USID);
            }
            else
            {
                ViewBag.Message = "Bạn chưa có tài khoản";
                return View();
            }
        }
        public ActionResult Signup()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Signup(FormCollection fc)
        {
            string name = fc["name"];
            DateTime dob = DateTime.Parse(fc["dob"]);
            string address = fc["address"];
            string phonenumber = fc["phonenumber"];
            string email = fc["email"];
            string username = fc["username"];
            string password = fc["password"];
            int num = ectx.USERS.Count(count => count.TENNGUOIDUNG == username);        //tên người dùng phải là duy nhất nên phải kiểm tra trước
            if (num > 0)
            {
                ViewBag.Message = "Tên người dùng đã tồn tại";
                return View();
            }
            else
            {
                var new_user = new USERS()
                {
                    TEN = name,
                    NGAYSINH = dob,
                    DIACHI = address,
                    SDT = phonenumber,
                    EMAIL = email,
                    TENNGUOIDUNG = username,
                    MATKHAU = password,
                    QUYEN = 0
                };
                ectx.USERS.Add(new_user);
                ectx.SaveChanges();
                return RedirectToAction("Signin");
            }
        }

        public ActionResult UserInfo()
        {
            string uid = Request.QueryString["uid"].ToString();
            int id = int.Parse(uid);
            var res = (from usr in ectx.USERS
                       where (usr.USID == id)
                       select new Userdetail
                       {
                           name = usr.TEN,
                           dob = (DateTime)usr.NGAYSINH,
                           address = usr.DIACHI,
                           phonenumber = usr.SDT,
                           email = usr.EMAIL,
                           username = usr.TENNGUOIDUNG,
                           iscustomer = (int)usr.QUYEN
                       }).FirstOrDefault();
            return View(res);
        }
        public ActionResult EditInfo()
        {
            string uid = Request.QueryString["uid"].ToString();
            int id = int.Parse(uid);
            var res = (from usr in ectx.USERS
                       where (usr.USID == id)
                       select new Userdetail
                       {
                           name = usr.TEN,
                           dob = (DateTime)usr.NGAYSINH,
                           address = usr.DIACHI,
                           phonenumber = usr.SDT,
                           email = usr.EMAIL,
                           username = usr.TENNGUOIDUNG
                       }).FirstOrDefault();
            return View(res);
        }
        [HttpPost]
        public ActionResult EditInfo(FormCollection fr)
        {
            try
            {
                int uid = int.Parse(Request.QueryString["uid"].ToString());
                string name = fr["name"];
                DateTime dob = DateTime.Parse(fr["dob"]);
                string address = fr["address"];
                string phone = fr["phone"];
                string email = fr["email"];
                var update_user = ectx.USERS.FirstOrDefault(x => x.USID == uid);
                update_user.TEN = name;
                update_user.NGAYSINH = dob;
                update_user.DIACHI = address;
                update_user.SDT = phone;
                update_user.EMAIL = email;
                ectx.SaveChanges();
            }
            catch(System.Data.Entity.Validation.DbEntityValidationException dbEx) {
                Exception raise = dbEx;
                foreach (var validationErrors in dbEx.EntityValidationErrors)
                {
                    foreach (var validationError in validationErrors.ValidationErrors)
                    {
                        string message = string.Format("{0}:{1}",
                            validationErrors.Entry.Entity.ToString(),
                            validationError.ErrorMessage);
                        // raise a new exception nesting  
                        // the current instance as InnerException  
                        raise = new InvalidOperationException(message, raise);
                    }
                }
                throw raise;
            }
            return Redirect("/Account/UserInfo?uid=" + Session["uid"]);
        }
        public ActionResult Logout()
        {
            Session.Remove("user_name");
            Session.Remove("uid");
            return Redirect("/Home/Index");
        }
    }
}