using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Template.Controllers
{
    public class HistoryController : Controller
    {
        // GET: History/About
        public ActionResult About()
        {
            return View();
        }
        // GET: History/Index 
        public ActionResult Index()
        {
            return View();
        }
        // GET: History/Team
        public ActionResult Team()
        {
            return View();
        }

        // GET: History/Donate
        public ActionResult Donate()
        {
            return View();
        }

        // GET: History/TimeTable
        public ActionResult TimeTable()
        {
            return View();
        }
        // GET: History/Leaders
        public ActionResult Leaders()
        {
            return View();
        }
        // GET: History/TeamMember
        public ActionResult TeamMember()
        {
            return View();
        }

        // POST: History/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: History/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: History/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: History/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: History/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
