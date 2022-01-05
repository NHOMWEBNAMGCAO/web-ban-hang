using Models.DAO;
using Models.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FcMilano.Areas.Admin.Controllers
{
    public class UserController : Controller
    {
        // GET: Admin/User
        public ActionResult Index()
        {
            var user = new UserDb().GetUser(0);
            return View(user);
        }

        // GET: Admin/User/Details/5
        public ActionResult Details(int id)
        {
            var user = new UserDb().GetUserByID(id);
            return View(user);
        }

        // GET: Admin/User/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Admin/User/Create
        [HttpPost]
        public ActionResult Create (User collection)
        {
            try
            {
                // TODO: Add insert logic here
                var result = new UserDb().InsertAndUpdateUser(collection);
                if (result > 0 && ModelState.IsValid)
                {
                    return RedirectToAction("Index");
                }
                
            }
            catch
            {
                return View(collection);
            }
            return View(collection);  
        }

        // GET: Admin/User/Edit/5
        public ActionResult Edit(int id)
        {
            var user = new UserDb().GetUserByID(id);
            return View(user);
        }

        // POST: Admin/User/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, User collection)
        {
            try
            {
                // TODO: Add update logic here
                var result = new UserDb().InsertAndUpdateUser(collection);
                if (result > 0 && ModelState.IsValid)
                {
                    return RedirectToAction("Index");
                }
                
            }
            catch
            {
                return View(collection);
            }
             return View(collection);
        }

        // GET: Admin/User/Delete/5
        public ActionResult Delete(int id)
        {
            var user = new UserDb().GetUserByID(id);
            return View(user);
        }

        // POST: Admin/User/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, User collection)
        {
            try
            {
                // TODO: Add delete logic here
                var result = new UserDb().DeleteUser(id);
                if (result > 0 && ModelState.IsValid)
                {
                    return RedirectToAction("Index");
                }
                
            }
            catch
            {
                return View(collection);
            }
            return View(collection);
        }
    }
}
