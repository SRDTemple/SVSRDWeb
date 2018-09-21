using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Template.Controllers
{
    public class ServiceController : Controller
    {
        // GET: Service/Services
        public ActionResult Services()
        {
            return View();
        }

        // GET: Service/TempleService
        public ActionResult TempleService()
        {
            return View();
        }

        // GET: Service/CharityService
        public ActionResult CharityService()
        {
            return View();
        }
        // GET: Service/Event
        public ActionResult Events()
        {
            return View();
        }
        // POST: Service/Create
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

        // GET: Service/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Service/Edit/5
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

        // GET: Service/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Service/Delete/5
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
