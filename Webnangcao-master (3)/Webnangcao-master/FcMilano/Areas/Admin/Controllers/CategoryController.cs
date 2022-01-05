using Models.DAO;
using Models.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FcMilano.Areas.Admin.Controllers
{
    public class CategoryController : Controller
    {
        // GET: Admin/Category
        public ActionResult Index()
        {
            var categories = new CategoryDb().GetCategories(0);
            return View(categories);
        }

        // GET: Admin/Category/Details/5
        public ActionResult Details(int id)
        {
            var category = new CategoryDb().GetCategoryByID(id);
            return View(category);
        }

        // GET: Admin/Category/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Admin/Category/Create
        [HttpPost]
        public ActionResult Create(Category collection)
        {
            try
            {
                var result = new CategoryDb().InsertAndUpdateCategory(collection);
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
            var category = new CategoryDb().GetCategoryByID(id);
            return View(category);
        }

        // POST: Admin/Category/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, Category collection)
        {
            try
            {
                // TODO: Add update logic here
                
                var result = new CategoryDb().InsertAndUpdateCategory(collection);
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
            var category = new CategoryDb().GetCategoryByID(id);
            return View(category);
        }

        // POST: Admin/Category/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, Category collection)
        {
            try
            {
                var result = new CategoryDb().DeleteCategory(id);
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
