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
    public class ResidentTypesController : Controller
    {
        private JAMAIAHSALAFIYAH_HOUSTONEntities db = new JAMAIAHSALAFIYAH_HOUSTONEntities();

        // GET: ResidentTypes
        public ActionResult Index()
        {
            return View(db.ResidentType.ToList());
        }

        // GET: ResidentTypes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ResidentType residentType = db.ResidentType.Find(id);
            if (residentType == null)
            {
                return HttpNotFound();
            }
            return View(residentType);
        }

        // GET: ResidentTypes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ResidentTypes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,ResidentType1")] ResidentType residentType)
        {
            if (ModelState.IsValid)
            {
                db.ResidentType.Add(residentType);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(residentType);
        }

        // GET: ResidentTypes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ResidentType residentType = db.ResidentType.Find(id);
            if (residentType == null)
            {
                return HttpNotFound();
            }
            return View(residentType);
        }

        // POST: ResidentTypes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,ResidentType1")] ResidentType residentType)
        {
            if (ModelState.IsValid)
            {
                db.Entry(residentType).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(residentType);
        }

        // GET: ResidentTypes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ResidentType residentType = db.ResidentType.Find(id);
            if (residentType == null)
            {
                return HttpNotFound();
            }
            return View(residentType);
        }

        // POST: ResidentTypes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ResidentType residentType = db.ResidentType.Find(id);
            db.ResidentType.Remove(residentType);
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
