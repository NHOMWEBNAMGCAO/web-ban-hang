using Models.DAO;
using Models.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FcMilano.Areas.Admin.Controllers
{
    public class ProductCategoryController : Controller
    {
        // GET: Admin/ProductCategory
        public ActionResult Index()
        {
            var ProductCat = new ProductCategoryDb().GetProductCategory(0);
            return View(ProductCat);
        }

        // GET: Admin/ProductCategory/Details/5
        public ActionResult Details(int id)
        {
            var ProductCat = new ProductCategoryDb().GetProductCategoryID(id);
            return View(ProductCat);
        }

        // GET: Admin/ProductCategory/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Admin/ProductCategory/Create
        [HttpPost]
        public ActionResult Create(ProductCategory collection)
        {
            try
            {
                var result = new ProductCategoryDb().InsertAndUpdateProductCategory(collection);
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

        // GET: Admin/ProductCategory/Edit/5
        public ActionResult Edit(int id)
        {
            var productcat = new ProductCategoryDb().GetProductCategoryID(id);
            return View(productcat);
        }

        // POST: Admin/ProductCategory/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, ProductCategory collection)
        {
            try
            {
                // TODO: Add update logic here

                var result = new ProductCategoryDb().InsertAndUpdateProductCategory(collection);
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

        // GET: Admin/ProductCategory/Delete/5
        public ActionResult Delete(int id)
        {
            var productcat = new ProductCategoryDb().GetProductCategoryID(id);
            return View();
        }

        // POST: Admin/ProductCategory/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, ProductCategory collection)
        {
            try
            {
                var result = new ProductCategoryDb().DeleteProductCategory(id);
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
