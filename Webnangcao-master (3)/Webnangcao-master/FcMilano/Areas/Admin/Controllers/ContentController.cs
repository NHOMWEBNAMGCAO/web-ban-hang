using Models.DAO;
using Models.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FcMilano.Areas.Admin.Controllers
{
    public class ContentController : Controller
    {
        // GET: Admin/Category
        public ActionResult Index()
        {
            var content = new ContentDAO().GetContents(0);
            return View(content);
        }

        // GET: Admin/Category/Details/5
        public ActionResult Details(int id)
        {
            var content = new ContentDAO().GetContentByID(id);
            return View(content);
        }

        // GET: Admin/Category/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Admin/Category/Create
        [HttpPost]
        public ActionResult Create(Content collection)
        {
            try
            {
                var result = new ContentDAO().InsertAndUpdateContent(collection);
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
            var content = new ContentDAO().GetContentByID(id);
            return View(content);
        }

        // POST: Admin/Category/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, Content collection)
        {
            try
            {
                // TODO: Add update logic here

                var result = new ContentDAO().InsertAndUpdateContent(collection);
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
            var content = new ContentDAO().GetContentByID(id);
            return View(content);
        }

        // POST: Admin/Category/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, Content collection)
        {
            try
            {
                var result = new ContentDAO().DeleteContent(id);
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
