using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Model;

namespace WebApp.Controllers
{
    public class ThingyController : Controller
    {
        private ThingsContext db = new ThingsContext();

        //
        // GET: /Default1/

        public ActionResult Index()
        {
            return View(db.Things.ToList());
        }

        //
        // GET: /Default1/Details/5

        public ActionResult Details(long id = 0)
        {
            Thingy thingy = db.Things.Find(id);
            if (thingy == null)
            {
                return HttpNotFound();
            }
            return View(thingy);
        }

        //
        // GET: /Default1/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Default1/Create

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Thingy thingy)
        {
            if (ModelState.IsValid)
            {
                db.Things.Add(thingy);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(thingy);
        }

        //
        // GET: /Default1/Edit/5

        public ActionResult Edit(long id = 0)
        {
            Thingy thingy = db.Things.Find(id);
            if (thingy == null)
            {
                return HttpNotFound();
            }
            return View(thingy);
        }

        //
        // POST: /Default1/Edit/5

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Thingy thingy)
        {
            if (ModelState.IsValid)
            {
                db.Entry(thingy).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(thingy);
        }

        //
        // GET: /Default1/Delete/5

        public ActionResult Delete(long id = 0)
        {
            Thingy thingy = db.Things.Find(id);
            if (thingy == null)
            {
                return HttpNotFound();
            }
            return View(thingy);
        }

        //
        // POST: /Default1/Delete/5

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(long id)
        {
            Thingy thingy = db.Things.Find(id);
            db.Things.Remove(thingy);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}