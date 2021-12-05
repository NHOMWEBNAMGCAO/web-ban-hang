using ishop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ishop.Areas.Admin.Controllers
{
    public class AuthController : Controller
    {
        Encryptor encty = new Encryptor();
        DBHBContex db = new DBHBContex();
        //
        // GET: /Admin/Auth/
        public ActionResult Login(User auth)
        {
            ViewBag.Message = "";
            if (ModelState.IsValid)
            {
                auth.Password = encty.MD5Hash(auth.Password);//pass ma hoa
                if (!db.Users.Where(m => m.Username == auth.Username).Count().Equals(0))
                {
                    if (!db.Users.Where(m => m.Username == auth.Username && m.Password == auth.Password).Count().Equals(0))
                    {
                        var user_login = db.Users.Where(m => m.Username == auth.Username && m.Password == auth.Password).First();
                        Session["user_admin"] = user_login.Username;
                        Session["use_id"] = user_login.Id;
                        Session["use_fullname"] = user_login.FullName;
                        Session["use_img"] = user_login.Img;
                        Session["use_access"] = user_login.Access;
                        return RedirectToAction("Index", "Dashboard");

                    }
                    else
                    {
                        ViewBag.Message = auth.Password;
                    }
                }
                else
                {
                    ViewBag.Message = "Tên tài Khoản không tồn tại";
                }
            }
            return View();
        }
    }
}