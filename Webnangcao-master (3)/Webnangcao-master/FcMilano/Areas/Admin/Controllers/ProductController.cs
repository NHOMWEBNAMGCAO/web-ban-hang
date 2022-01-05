using Models.DAO;
using Models.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FcMilano.Areas.Admin.Controllers
{
    public class ProductController : Controller
    {
        // GET: Admin/Product
        public ActionResult Index()
        {
            var products = new ProductDb().GetProduct(0);
            return View(products);
        }

        // GET: Admin/Product/Details/5
        public ActionResult Details(int id)
        {
            var product = new ProductDb().GetProductID(id);
            return View(product);
        }

        // GET: Admin/Product/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Admin/Product/Create
        [HttpPost]
        public ActionResult Create(Product collection)
        {
            try
            {
                var result = new ProductDb().InsertAndUpdateProduct(collection);
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

        // GET: Admin/Product/Edit/5
        public ActionResult Edit(int id)
        {
            var product = new ProductDb().GetProductID(id);
            return View(product);
        }

        // POST: Admin/Product/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, Product collection)
        {
            try
            {
                // TODO: Add update logic here

                var result = new ProductDb().InsertAndUpdateProduct(collection);
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

        // GET: Admin/Product/Delete/5
        public ActionResult Delete(int id)
        {
            var product = new ProductDb().GetProductID(id);
            return View(product);
        }

        // POST: Admin/Product/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, Product collection)
        {
            try
            {
                var result = new ProductDb().DeleteProduct(id);
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
