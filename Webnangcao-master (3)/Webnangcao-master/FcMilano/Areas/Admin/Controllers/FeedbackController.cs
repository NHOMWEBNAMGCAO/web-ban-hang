using Models.DAO;
using Models.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FcMilano.Areas.Admin.Controllers
{
    public class FeedbackController : Controller
    {
        // GET: Admin/Category
        public ActionResult Index()
        {
            var feedback = new FeedbackDb().GetFeedback(0);
            return View(feedback);
        }

        // GET: Admin/Category/Details/5
        public ActionResult Details(int id)
        {
            var feedback = new FeedbackDb().GetFeedbackByID(id);
            return View(feedback);
        }

        // GET: Admin/Category/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Admin/Category/Create
        [HttpPost]
        public ActionResult Create(Feedback collection)
        {
            try
            {
                var result = new FeedbackDb().InsertAndUpdateFeedback(collection);
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
            var feedback = new FeedbackDb().GetFeedbackByID(id);
            return View(feedback);
        }

        // POST: Admin/Category/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, Feedback collection)
        {
            try
            {
                // TODO: Add update logic here

                var result = new FeedbackDb().InsertAndUpdateFeedback(collection);
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
            var feedback = new FeedbackDb().GetFeedbackByID(id);
            return View(feedback);
        }

        // POST: Admin/Category/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, Feedback collection)
        {
            try
            {
                var result = new FeedbackDb().DeleteFeedback(id);
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
