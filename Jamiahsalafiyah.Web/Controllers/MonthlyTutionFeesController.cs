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
    public class MonthlyTutionFeesController : Controller
    {
        private JAMAIAHSALAFIYAH_HOUSTONEntities db = new JAMAIAHSALAFIYAH_HOUSTONEntities();

        // GET: MonthlyTutionFees
        public ActionResult Index()
        {
            var monthlyTutionFee = db.MonthlyTutionFee.Include(m => m.Department).Include(m => m.SessionMonth).Include(m => m.SessionYear).Include(m => m.TutionFeeType);
            return View(monthlyTutionFee.ToList());
        }

        // GET: MonthlyTutionFees/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MonthlyTutionFee monthlyTutionFee = db.MonthlyTutionFee.Find(id);
            if (monthlyTutionFee == null)
            {
                return HttpNotFound();
            }
            return View(monthlyTutionFee);
        }

        // GET: MonthlyTutionFees/Create
        public ActionResult Create()
        {
            ViewBag.DepartmentId = new SelectList(db.Department, "Id", "Name");
            ViewBag.SessionMonthId = new SelectList(db.SessionMonth, "Id", "Month");
            ViewBag.SessionYearId = new SelectList(db.SessionYear, "Id", "Name");
            ViewBag.TutionFeeTypeId = new SelectList(db.TutionFeeType, "Id", "TutionFeeType1");
            return View();
        }

        // POST: MonthlyTutionFees/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,SessionYearId,DepartmentId,SessionMonthId,TutionFeeTypeId,Amount")] MonthlyTutionFee monthlyTutionFee)
        {
            if (ModelState.IsValid)
            {
                db.MonthlyTutionFee.Add(monthlyTutionFee);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.DepartmentId = new SelectList(db.Department, "Id", "Name", monthlyTutionFee.DepartmentId);
            ViewBag.SessionMonthId = new SelectList(db.SessionMonth, "Id", "Month", monthlyTutionFee.SessionMonthId);
            ViewBag.SessionYearId = new SelectList(db.SessionYear, "Id", "Name", monthlyTutionFee.SessionYearId);
            ViewBag.TutionFeeTypeId = new SelectList(db.TutionFeeType, "Id", "TutionFeeType1", monthlyTutionFee.TutionFeeTypeId);
            return View(monthlyTutionFee);
        }

        // GET: MonthlyTutionFees/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MonthlyTutionFee monthlyTutionFee = db.MonthlyTutionFee.Find(id);
            if (monthlyTutionFee == null)
            {
                return HttpNotFound();
            }
            ViewBag.DepartmentId = new SelectList(db.Department, "Id", "Name", monthlyTutionFee.DepartmentId);
            ViewBag.SessionMonthId = new SelectList(db.SessionMonth, "Id", "Month", monthlyTutionFee.SessionMonthId);
            ViewBag.SessionYearId = new SelectList(db.SessionYear, "Id", "Name", monthlyTutionFee.SessionYearId);
            ViewBag.TutionFeeTypeId = new SelectList(db.TutionFeeType, "Id", "TutionFeeType1", monthlyTutionFee.TutionFeeTypeId);
            return View(monthlyTutionFee);
        }

        // POST: MonthlyTutionFees/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,SessionYearId,DepartmentId,SessionMonthId,TutionFeeTypeId,Amount")] MonthlyTutionFee monthlyTutionFee)
        {
            if (ModelState.IsValid)
            {
                db.Entry(monthlyTutionFee).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.DepartmentId = new SelectList(db.Department, "Id", "Name", monthlyTutionFee.DepartmentId);
            ViewBag.SessionMonthId = new SelectList(db.SessionMonth, "Id", "Month", monthlyTutionFee.SessionMonthId);
            ViewBag.SessionYearId = new SelectList(db.SessionYear, "Id", "Name", monthlyTutionFee.SessionYearId);
            ViewBag.TutionFeeTypeId = new SelectList(db.TutionFeeType, "Id", "TutionFeeType1", monthlyTutionFee.TutionFeeTypeId);
            return View(monthlyTutionFee);
        }

        // GET: MonthlyTutionFees/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MonthlyTutionFee monthlyTutionFee = db.MonthlyTutionFee.Find(id);
            if (monthlyTutionFee == null)
            {
                return HttpNotFound();
            }
            return View(monthlyTutionFee);
        }

        // POST: MonthlyTutionFees/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            MonthlyTutionFee monthlyTutionFee = db.MonthlyTutionFee.Find(id);
            db.MonthlyTutionFee.Remove(monthlyTutionFee);
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
