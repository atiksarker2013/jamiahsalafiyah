using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Jamiahsalafiyah.Web.Models;

namespace Jamiahsalafiyah.Web.Controllers
{
    public class SessionYearsController : Controller
    {
        private JAMAIAHSALAFIYAH_HOUSTONEntities db = new JAMAIAHSALAFIYAH_HOUSTONEntities();

        // GET: SessionYears
        public ActionResult Index()
        {
            return View(db.SessionYear.ToList());
        }

        // GET: SessionYears/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SessionYear sessionYear = db.SessionYear.Find(id);
            if (sessionYear == null)
            {
                return HttpNotFound();
            }
            return View(sessionYear);
        }

        // GET: SessionYears/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: SessionYears/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Name")] SessionYear sessionYear)
        {
            if (ModelState.IsValid)
            {
                db.SessionYear.Add(sessionYear);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(sessionYear);
        }

        // GET: SessionYears/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SessionYear sessionYear = db.SessionYear.Find(id);
            if (sessionYear == null)
            {
                return HttpNotFound();
            }
            return View(sessionYear);
        }

        // POST: SessionYears/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Name")] SessionYear sessionYear)
        {
            if (ModelState.IsValid)
            {
                db.Entry(sessionYear).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(sessionYear);
        }

        // GET: SessionYears/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SessionYear sessionYear = db.SessionYear.Find(id);
            if (sessionYear == null)
            {
                return HttpNotFound();
            }
            return View(sessionYear);
        }

        // POST: SessionYears/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            SessionYear sessionYear = db.SessionYear.Find(id);
            db.SessionYear.Remove(sessionYear);
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
