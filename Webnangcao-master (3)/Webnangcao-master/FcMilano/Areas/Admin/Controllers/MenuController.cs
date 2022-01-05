using Models.DAO;
using Models.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FcMilano.Areas.Admin.Controllers
{
    public class MenuController : Controller
    {
        // GET: Admin/Category
        public ActionResult Index()
        {
            var menu = new MenuDb().GetMenu(0);
            return View(menu);
        }

        // GET: Admin/Category/Details/5
        public ActionResult Details(int id)
        {
            var menu = new MenuDb().GetMenuByID(id);
            return View(menu);
        }

        // GET: Admin/Category/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Admin/Category/Create
        [HttpPost]
        public ActionResult Create(Menu collection)
        {
            try
            {
                var result = new MenuDb().InsertAndUpdateMenu(collection);
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

        // GET: Admin/Category/Edit/5
        public ActionResult Edit(int id)
        {
            var menu = new MenuDb().GetMenuByID(id);
            return View(menu);
        }

        // POST: Admin/Category/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, Menu collection)
        {
            try
            {
                // TODO: Add update logic here

                var result = new MenuDb().InsertAndUpdateMenu(collection);
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

        // GET: Admin/Category/Delete/5
        public ActionResult Delete(int id)
        {
            var menu = new MenuDb().GetMenuByID(id);
            return View(menu);
        }

        // POST: Admin/Category/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, Menu collection)
        {
            try
            {
                var result = new MenuDb().DeleteMenu(id);
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
