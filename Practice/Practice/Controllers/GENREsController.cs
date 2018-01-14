using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Practice.Models;

namespace Practice.Controllers
{
    public class GENREsController : Controller
    {
        private MovieContext db = new MovieContext();

        // GET: GENREs
        public ActionResult Index()
        {
            return View(db.GENRE.ToList());
        }

        // GET: GENREs/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            GENRE gENRE = db.GENRE.Find(id);
            if (gENRE == null)
            {
                return HttpNotFound();
            }
            return View(gENRE);
        }

        // GET: GENREs/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: GENREs/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,NAME")] GENRE gENRE)
        {
            if (ModelState.IsValid)
            {
                db.GENRE.Add(gENRE);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(gENRE);
        }

        // GET: GENREs/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            GENRE gENRE = db.GENRE.Find(id);
            if (gENRE == null)
            {
                return HttpNotFound();
            }
            return View(gENRE);
        }

        // POST: GENREs/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,NAME")] GENRE gENRE)
        {
            if (ModelState.IsValid)
            {
                db.Entry(gENRE).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(gENRE);
        }

        // GET: GENREs/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            GENRE gENRE = db.GENRE.Find(id);
            if (gENRE == null)
            {
                return HttpNotFound();
            }
            return View(gENRE);
        }

        // POST: GENREs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            GENRE gENRE = db.GENRE.Find(id);
            db.GENRE.Remove(gENRE);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
