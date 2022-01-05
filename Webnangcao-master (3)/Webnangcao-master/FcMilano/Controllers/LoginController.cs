using FcMilano.Areas.Admin.Commons;
using FcMilano.Models;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace FcMilano.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Index(AccountModels Model)
        {
            if (Membership.ValidateUser(Model.UserName, Model.PassWord) && ModelState.IsValid)
            {
                //luu session de check hien thi
              //  User user = new AccountDAO().GetUserByUserName(Model.UserName, Model.PassWord);
               // SessionHelper.SetSession(new UserSession() { UserName = user });
                //session de kiem tra dang nhap
                FormsAuthentication.SetAuthCookie(Model.UserName, Model.Remember);
                return RedirectToAction("Index", "Home");
            }
            else
            {
                ModelState.AddModelError("", "UserName hoặc password không đúng");
            }
            return View(Model);
        }

    }
}