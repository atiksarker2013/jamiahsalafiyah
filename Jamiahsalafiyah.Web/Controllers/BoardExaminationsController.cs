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
    public class BoardExaminationsController : Controller
    {
        private JAMAIAHSALAFIYAH_HOUSTONEntities db = new JAMAIAHSALAFIYAH_HOUSTONEntities();

        // GET: BoardExaminations
        public ActionResult Index()
        {
            return View(db.BoardExamination.ToList());
        }

        // GET: BoardExaminations/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BoardExamination boardExamination = db.BoardExamination.Find(id);
            if (boardExamination == null)
            {
                return HttpNotFound();
            }
            return View(boardExamination);
        }

        // GET: BoardExaminations/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: BoardExaminations/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,ExminationName")] BoardExamination boardExamination)
        {
            if (ModelState.IsValid)
            {
                db.BoardExamination.Add(boardExamination);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(boardExamination);
        }

        // GET: BoardExaminations/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BoardExamination boardExamination = db.BoardExamination.Find(id);
            if (boardExamination == null)
            {
                return HttpNotFound();
            }
            return View(boardExamination);
        }

        // POST: BoardExaminations/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,ExminationName")] BoardExamination boardExamination)
        {
            if (ModelState.IsValid)
            {
                db.Entry(boardExamination).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(boardExamination);
        }

        // GET: BoardExaminations/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BoardExamination boardExamination = db.BoardExamination.Find(id);
            if (boardExamination == null)
            {
                return HttpNotFound();
            }
            return View(boardExamination);
        }

        // POST: BoardExaminations/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            BoardExamination boardExamination = db.BoardExamination.Find(id);
            db.BoardExamination.Remove(boardExamination);
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
