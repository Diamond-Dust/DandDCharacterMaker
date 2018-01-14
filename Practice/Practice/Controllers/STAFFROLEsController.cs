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
    public class STAFFROLEsController : Controller
    {
        private MovieContext db = new MovieContext();

        // GET: STAFFROLEs
        public ActionResult Index()
        {
            return View(db.STAFFROLE.ToList());
        }

        // GET: STAFFROLEs/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            STAFFROLE sTAFFROLE = db.STAFFROLE.Find(id);
            if (sTAFFROLE == null)
            {
                return HttpNotFound();
            }
            return View(sTAFFROLE);
        }

        // GET: STAFFROLEs/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: STAFFROLEs/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,NAME")] STAFFROLE sTAFFROLE)
        {
            if (ModelState.IsValid)
            {
                db.STAFFROLE.Add(sTAFFROLE);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(sTAFFROLE);
        }

        // GET: STAFFROLEs/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            STAFFROLE sTAFFROLE = db.STAFFROLE.Find(id);
            if (sTAFFROLE == null)
            {
                return HttpNotFound();
            }
            return View(sTAFFROLE);
        }

        // POST: STAFFROLEs/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,NAME")] STAFFROLE sTAFFROLE)
        {
            if (ModelState.IsValid)
            {
                db.Entry(sTAFFROLE).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(sTAFFROLE);
        }

        // GET: STAFFROLEs/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            STAFFROLE sTAFFROLE = db.STAFFROLE.Find(id);
            if (sTAFFROLE == null)
            {
                return HttpNotFound();
            }
            return View(sTAFFROLE);
        }

        // POST: STAFFROLEs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            STAFFROLE sTAFFROLE = db.STAFFROLE.Find(id);
            db.STAFFROLE.Remove(sTAFFROLE);
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
