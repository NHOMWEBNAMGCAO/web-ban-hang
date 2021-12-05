using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ishop.Areas.Admin.Controllers
{
    public class DashboardController : Controller
    {
        //
        // GET: /Dashboard/
        public ActionResult Index()
        {
            if (Session["user_admin"].Equals(""))
            {
                Response.Redirect("admin/login");
                RedirectToAction("Login", "Auth");
            }
            return View();
        }
    }
}