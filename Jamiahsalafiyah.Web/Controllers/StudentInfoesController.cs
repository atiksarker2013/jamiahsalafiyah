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
    public class StudentInfoesController : Controller
    {
        private JAMAIAHSALAFIYAH_HOUSTONEntities db = new JAMAIAHSALAFIYAH_HOUSTONEntities();

        // GET: StudentInfoes
        public ActionResult Index()
        {
            var studentInfo = db.StudentInfo.Include(s => s.Department).Include(s => s.Gender);
            return View(studentInfo.ToList());
        }

        // GET: StudentInfoes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            StudentInfo studentInfo = db.StudentInfo.Find(id);
            if (studentInfo == null)
            {
                return HttpNotFound();
            }
            return View(studentInfo);
        }

        // GET: StudentInfoes/Create
        public ActionResult Create()
        {
            ViewBag.AdmittedDepartmentId = new SelectList(db.Department, "Id", "Name");
            ViewBag.GenderId = new SelectList(db.Gender, "Id", "GenderName");
            return View();
        }

        // POST: StudentInfoes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,StudentPhoto,StudentNameBangla,StudentNameEnglish,StudentNameArabic,StudentDateOfBirth,GenderId,Nationality,FatherNameBangla,FatherNameEnglish,FatherIsAlive,FatherOccupation,FatherMobile,MotherNameBangla,MotherNameEnglish,MotherIsAlive,MotherMobile,GuardianName,GuardianOccupation,GuardianHouseNo,GuardianVillage,GuardianPostOffice,GuardianThana,GuardianDistrict,RelationWithGuardian,YearlyIncomeGuardian,PermanentAddressHouse,PermanentAddressVillage,PermanentAddressPostOffice,PermanentAddressThana,PermanentAddressDistrict,HonarablePersonNameInArea,PreviousInstitutionName,PreviousInstitutionAddress,PreviousInstitutionClass,PreviousInstitutionClearanceNo,PreviousInstitutionClearanceDate,AdmittedDepartmentId")] StudentInfo studentInfo)
        {
            if (ModelState.IsValid)
            {
                db.StudentInfo.Add(studentInfo);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.AdmittedDepartmentId = new SelectList(db.Department, "Id", "Name", studentInfo.AdmittedDepartmentId);
            ViewBag.GenderId = new SelectList(db.Gender, "Id", "GenderName", studentInfo.GenderId);
            return View(studentInfo);
        }

        // GET: StudentInfoes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            StudentInfo studentInfo = db.StudentInfo.Find(id);
            if (studentInfo == null)
            {
                return HttpNotFound();
            }
            ViewBag.AdmittedDepartmentId = new SelectList(db.Department, "Id", "Name", studentInfo.AdmittedDepartmentId);
            ViewBag.GenderId = new SelectList(db.Gender, "Id", "GenderName", studentInfo.GenderId);
            return View(studentInfo);
        }

        // POST: StudentInfoes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,StudentPhoto,StudentNameBangla,StudentNameEnglish,StudentNameArabic,StudentDateOfBirth,GenderId,Nationality,FatherNameBangla,FatherNameEnglish,FatherIsAlive,FatherOccupation,FatherMobile,MotherNameBangla,MotherNameEnglish,MotherIsAlive,MotherMobile,GuardianName,GuardianOccupation,GuardianHouseNo,GuardianVillage,GuardianPostOffice,GuardianThana,GuardianDistrict,RelationWithGuardian,YearlyIncomeGuardian,PermanentAddressHouse,PermanentAddressVillage,PermanentAddressPostOffice,PermanentAddressThana,PermanentAddressDistrict,HonarablePersonNameInArea,PreviousInstitutionName,PreviousInstitutionAddress,PreviousInstitutionClass,PreviousInstitutionClearanceNo,PreviousInstitutionClearanceDate,AdmittedDepartmentId")] StudentInfo studentInfo)
        {
            if (ModelState.IsValid)
            {
                db.Entry(studentInfo).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.AdmittedDepartmentId = new SelectList(db.Department, "Id", "Name", studentInfo.AdmittedDepartmentId);
            ViewBag.GenderId = new SelectList(db.Gender, "Id", "GenderName", studentInfo.GenderId);
            return View(studentInfo);
        }

        // GET: StudentInfoes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            StudentInfo studentInfo = db.StudentInfo.Find(id);
            if (studentInfo == null)
            {
                return HttpNotFound();
            }
            return View(studentInfo);
        }

        // POST: StudentInfoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            StudentInfo studentInfo = db.StudentInfo.Find(id);
            db.StudentInfo.Remove(studentInfo);
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
