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
    public class StudentAssignedsController : Controller
    {
        private JAMAIAHSALAFIYAH_HOUSTONEntities db = new JAMAIAHSALAFIYAH_HOUSTONEntities();

        // GET: StudentAssigneds
        public ActionResult Index()
        {
            var studentAssigned = db.StudentAssigned.Include(s => s.Department).Include(s => s.ResidentType).Include(s => s.StudentInfo);
            return View(studentAssigned.ToList());
        }

        // GET: StudentAssigneds/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            StudentAssigned studentAssigned = db.StudentAssigned.Find(id);
            if (studentAssigned == null)
            {
                return HttpNotFound();
            }
            return View(studentAssigned);
        }

        // GET: StudentAssigneds/Create
        public ActionResult Create()
        {
            ViewBag.Department_FK = new SelectList(db.Department, "Id", "Name");
            ViewBag.ResidentType_FK = new SelectList(db.ResidentType, "Id", "ResidentType1");
            ViewBag.StudentInfo_FK = new SelectList(db.StudentInfo, "Id", "StudentNameBangla");
            return View();
        }

        // POST: StudentAssigneds/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,StudentInfo_FK,Department_FK,ResidentType_FK")] StudentAssigned studentAssigned)
        {
            if (ModelState.IsValid)
            {
                db.StudentAssigned.Add(studentAssigned);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.Department_FK = new SelectList(db.Department, "Id", "Name", studentAssigned.Department_FK);
            ViewBag.ResidentType_FK = new SelectList(db.ResidentType, "Id", "ResidentType1", studentAssigned.ResidentType_FK);
            ViewBag.StudentInfo_FK = new SelectList(db.StudentInfo, "Id", "StudentNameBangla", studentAssigned.StudentInfo_FK);
            return View(studentAssigned);
        }

        // GET: StudentAssigneds/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            StudentAssigned studentAssigned = db.StudentAssigned.Find(id);
            if (studentAssigned == null)
            {
                return HttpNotFound();
            }
            ViewBag.Department_FK = new SelectList(db.Department, "Id", "Name", studentAssigned.Department_FK);
            ViewBag.ResidentType_FK = new SelectList(db.ResidentType, "Id", "ResidentType1", studentAssigned.ResidentType_FK);
            ViewBag.StudentInfo_FK = new SelectList(db.StudentInfo, "Id", "StudentNameBangla", studentAssigned.StudentInfo_FK);
            return View(studentAssigned);
        }

        // POST: StudentAssigneds/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,StudentInfo_FK,Department_FK,ResidentType_FK")] StudentAssigned studentAssigned)
        {
            if (ModelState.IsValid)
            {
                db.Entry(studentAssigned).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.Department_FK = new SelectList(db.Department, "Id", "Name", studentAssigned.Department_FK);
            ViewBag.ResidentType_FK = new SelectList(db.ResidentType, "Id", "ResidentType1", studentAssigned.ResidentType_FK);
            ViewBag.StudentInfo_FK = new SelectList(db.StudentInfo, "Id", "StudentNameBangla", studentAssigned.StudentInfo_FK);
            return View(studentAssigned);
        }

        // GET: StudentAssigneds/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            StudentAssigned studentAssigned = db.StudentAssigned.Find(id);
            if (studentAssigned == null)
            {
                return HttpNotFound();
            }
            return View(studentAssigned);
        }

        // POST: StudentAssigneds/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            StudentAssigned studentAssigned = db.StudentAssigned.Find(id);
            db.StudentAssigned.Remove(studentAssigned);
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
