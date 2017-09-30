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
    public class SessionMonthsController : Controller
    {
        private JAMAIAHSALAFIYAH_HOUSTONEntities db = new JAMAIAHSALAFIYAH_HOUSTONEntities();

        // GET: SessionMonths
        public ActionResult Index()
        {
            return View(db.SessionMonth.ToList());
        }

        // GET: SessionMonths/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SessionMonth sessionMonth = db.SessionMonth.Find(id);
            if (sessionMonth == null)
            {
                return HttpNotFound();
            }
            return View(sessionMonth);
        }

        // GET: SessionMonths/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: SessionMonths/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Month")] SessionMonth sessionMonth)
        {
            if (ModelState.IsValid)
            {
                db.SessionMonth.Add(sessionMonth);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(sessionMonth);
        }

        // GET: SessionMonths/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SessionMonth sessionMonth = db.SessionMonth.Find(id);
            if (sessionMonth == null)
            {
                return HttpNotFound();
            }
            return View(sessionMonth);
        }

        // POST: SessionMonths/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Month")] SessionMonth sessionMonth)
        {
            if (ModelState.IsValid)
            {
                db.Entry(sessionMonth).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(sessionMonth);
        }

        // GET: SessionMonths/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SessionMonth sessionMonth = db.SessionMonth.Find(id);
            if (sessionMonth == null)
            {
                return HttpNotFound();
            }
            return View(sessionMonth);
        }

        // POST: SessionMonths/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            SessionMonth sessionMonth = db.SessionMonth.Find(id);
            db.SessionMonth.Remove(sessionMonth);
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
