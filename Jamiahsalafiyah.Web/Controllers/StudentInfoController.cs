using Jamiahsalafiyah.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Jamiahsalafiyah.Web.Controllers
{
    public class StudentInfoController : Controller
    {
        private JAMAIAHSALAFIYAH_HOUSTONEntities db = new JAMAIAHSALAFIYAH_HOUSTONEntities();
        // GET: StudentInfo
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Create()
        {
            StudentInfoViewModel model = new StudentInfoViewModel();

            ViewBag.GenderId = new SelectList(db.Gender.OrderBy(m => m.GenderName), "Id", "GenderName");
            ViewBag.AdmittedDepartmentId = new SelectList(db.Department.OrderBy(m => m.Name), "Id", "Name");

            return View(model);
        }

        [HttpPost]
        public ActionResult Create(StudentInfoViewModel model,  HttpPostedFileBase PostedLogo)
        {

            if (ModelState.IsValid)
            {
                

                StudentInfo entity = new StudentInfo();

                if (PostedLogo != null)
                {
                    byte[] imgBinaryData = new byte[PostedLogo.ContentLength];
                    int readresult = PostedLogo.InputStream.Read(imgBinaryData, 0, PostedLogo.ContentLength);
                    entity.StudentPhoto = imgBinaryData;
                }
                
                entity.StudentNameBangla = model.StudentNameBangla;
                entity.StudentNameEnglish = model.StudentNameEnglish;
                entity.StudentNameArabic = model.StudentNameArabic;
                entity.StudentDateOfBirth = model.StudentDateOfBirth;
                entity.GenderId = model.GenderId;
                entity.Nationality = model.Nationality;
                entity.FatherNameBangla = model.FatherNameBangla;
                entity.FatherNameEnglish = model.FatherNameEnglish;
                entity.FatherIsAlive = model.FatherIsAlive;
                entity.FatherOccupation = model.FatherOccupation;
                entity.MotherNameBangla = model.MotherNameBangla;
                entity.MotherNameEnglish = model.MotherNameEnglish;
                entity.MotherIsAlive = model.MotherIsAlive;
                entity.MotherMobile = model.MotherMobile;
                entity.GuardianName = model.GuardianName;
                entity.GuardianOccupation = model.GuardianOccupation;
                entity.GuardianHouseNo = model.GuardianHouseNo;
                entity.GuardianVillage = model.GuardianVillage;
                entity.GuardianPostOffice = model.GuardianPostOffice;
                entity.GuardianThana = model.GuardianThana;
                entity.GuardianDistrict = model.GuardianDistrict;
                entity.RelationWithGuardian = model.RelationWithGuardian;
                entity.YearlyIncomeGuardian = model.YearlyIncomeGuardian;
                entity.PermanentAddressHouse = model.PermanentAddressHouse;
                entity.PermanentAddressVillage = model.PermanentAddressVillage;
                entity.PermanentAddressPostOffice = model.PermanentAddressPostOffice;
                entity.PermanentAddressThana = model.PermanentAddressThana;
                entity.PermanentAddressDistrict = model.PermanentAddressDistrict;
                entity.HonarablePersonNameInArea = model.HonarablePersonNameInArea;
                entity.PreviousInstitutionName = model.PreviousInstitutionName;
                entity.PreviousInstitutionAddress = model.PreviousInstitutionAddress;
                entity.PreviousInstitutionClass = model.PreviousInstitutionClass;
                entity.PreviousInstitutionClearanceNo = model.PreviousInstitutionClearanceNo;
                entity.PreviousInstitutionClearanceDate = model.PreviousInstitutionClearanceDate;
                entity.AdmittedDepartmentId = model.AdmittedDepartmentId;

                db.StudentInfo.Add(entity);
                db.SaveChanges();

                model.Id = entity.Id;

                // var entity = db.BoardExamination.All();

                using (var _sdb = new JAMAIAHSALAFIYAH_HOUSTONEntities())
                {

                    foreach (var item in _sdb.BoardExamination)
                    {
                        StudentInfoPreviousInstitutionViewModel _institutionObj = new StudentInfoPreviousInstitutionViewModel();
                        _institutionObj.ExamName = item.ExminationName;

                        StudentInfoPreviousInstitution _studentInfoPreviousInstitutionEntity = new StudentInfoPreviousInstitution();
                        _studentInfoPreviousInstitutionEntity.ExamName = _institutionObj.ExamName;
                        _studentInfoPreviousInstitutionEntity.StudentInfo_FK = model.Id;
                        db.StudentInfoPreviousInstitution.Add(_studentInfoPreviousInstitutionEntity);
                       // db.SaveChanges();
                    }
                    //save at the end
                    _sdb.SaveChanges();
                }

                return RedirectToAction("Edit", new { id = model.Id });



            }


            ViewBag.GenderId = new SelectList(db.Gender.OrderBy(m => m.GenderName), "Id", "GenderName");
            ViewBag.AdmittedDepartmentId = new SelectList(db.Department.OrderBy(m => m.Name), "Id", "Name");

            return View(model);
        }


        public ActionResult Edit(int id)
        {

            var entity = db.StudentInfo.Find(id);

             StudentInfoViewModel model = new StudentInfoViewModel();

            model.Id = entity.Id;
            model.StudentPhoto = entity.StudentPhoto;
            model.StudentNameBangla = entity.StudentNameBangla;
            model.StudentNameEnglish = entity.StudentNameEnglish;
            model.StudentNameArabic = entity.StudentNameArabic;
            model.StudentDateOfBirth = entity.StudentDateOfBirth;
            model.GenderId = entity.GenderId;
            model.Nationality = entity.Nationality;
            model.FatherNameBangla = entity.FatherNameBangla;
            model.FatherNameEnglish = entity.FatherNameEnglish;
            model.FatherMobile = entity.FatherMobile;
            model.FatherIsAlive = entity.FatherIsAlive;
            model.FatherOccupation = entity.FatherOccupation;
            model.MotherNameBangla = entity.MotherNameBangla;
            model.MotherNameEnglish = entity.MotherNameEnglish;
            model.MotherIsAlive = entity.MotherIsAlive;
            model.MotherMobile = entity.MotherMobile;
            model.GuardianName = entity.GuardianName;
            model.GuardianOccupation = entity.GuardianOccupation;
            model.GuardianHouseNo = entity.GuardianHouseNo;
            model.GuardianVillage = entity.GuardianVillage;
            model.GuardianPostOffice = entity.GuardianPostOffice;
            model.GuardianThana = entity.GuardianThana;
            model.GuardianDistrict = entity.GuardianDistrict;
            model.RelationWithGuardian = entity.RelationWithGuardian;
            model.YearlyIncomeGuardian = entity.YearlyIncomeGuardian;
            model.PermanentAddressHouse = entity.PermanentAddressHouse;
            model.PermanentAddressVillage = entity.PermanentAddressVillage;
            model.PermanentAddressPostOffice = entity.PermanentAddressPostOffice;
            model.PermanentAddressThana = entity.PermanentAddressThana;
            model.PermanentAddressDistrict = entity.PermanentAddressDistrict;
            model.HonarablePersonNameInArea = entity.HonarablePersonNameInArea;
            model.PreviousInstitutionName = entity.PreviousInstitutionName;
            model.PreviousInstitutionAddress = entity.PreviousInstitutionAddress;
            model.PreviousInstitutionClass = entity.PreviousInstitutionClass;
            model.PreviousInstitutionClearanceNo = entity.PreviousInstitutionClearanceNo;
            model.PreviousInstitutionClearanceDate = entity.PreviousInstitutionClearanceDate;
            model.AdmittedDepartmentId = entity.AdmittedDepartmentId;


            ViewBag.GenderId = new SelectList(db.Gender.OrderBy(m => m.GenderName), "Id", "GenderName");
            ViewBag.AdmittedDepartmentId = new SelectList(db.Department.OrderBy(m => m.Name), "Id", "Name");

            return View(model);
        }

        [HttpPost]
        public ActionResult Edit(StudentInfoViewModel model, HttpPostedFileBase PostedLogo)
        {

            if (ModelState.IsValid)
            {


                StudentInfo entity = db.StudentInfo.Find(model.Id);

                if (PostedLogo != null)
                {
                    byte[] imgBinaryData = new byte[PostedLogo.ContentLength];
                    int readresult = PostedLogo.InputStream.Read(imgBinaryData, 0, PostedLogo.ContentLength);
                    entity.StudentPhoto = imgBinaryData;
                }

                entity.StudentNameBangla = model.StudentNameBangla;
                entity.StudentNameEnglish = model.StudentNameEnglish;
                entity.StudentNameArabic = model.StudentNameArabic;
                entity.StudentDateOfBirth = model.StudentDateOfBirth;
                entity.GenderId = model.GenderId;
                entity.Nationality = model.Nationality;
                entity.FatherNameBangla = model.FatherNameBangla;
                entity.FatherNameEnglish = model.FatherNameEnglish;
                entity.FatherMobile = model.FatherMobile;
                entity.FatherIsAlive = model.FatherIsAlive;
                entity.FatherOccupation = model.FatherOccupation;
                entity.MotherNameBangla = model.MotherNameBangla;
                entity.MotherNameEnglish = model.MotherNameEnglish;
                entity.MotherIsAlive = model.MotherIsAlive;
                entity.MotherMobile = model.MotherMobile;
                entity.GuardianName = model.GuardianName;
                entity.GuardianOccupation = model.GuardianOccupation;
                entity.GuardianHouseNo = model.GuardianHouseNo;
                entity.GuardianVillage = model.GuardianVillage;
                entity.GuardianPostOffice = model.GuardianPostOffice;
                entity.GuardianThana = model.GuardianThana;
                entity.GuardianDistrict = model.GuardianDistrict;
                entity.RelationWithGuardian = model.RelationWithGuardian;
                entity.YearlyIncomeGuardian = model.YearlyIncomeGuardian;
                entity.PermanentAddressHouse = model.PermanentAddressHouse;
                entity.PermanentAddressVillage = model.PermanentAddressVillage;
                entity.PermanentAddressPostOffice = model.PermanentAddressPostOffice;
                entity.PermanentAddressThana = model.PermanentAddressThana;
                entity.PermanentAddressDistrict = model.PermanentAddressDistrict;
                entity.HonarablePersonNameInArea = model.HonarablePersonNameInArea;
                entity.PreviousInstitutionName = model.PreviousInstitutionName;
                entity.PreviousInstitutionAddress = model.PreviousInstitutionAddress;
                entity.PreviousInstitutionClass = model.PreviousInstitutionClass;
                entity.PreviousInstitutionClearanceNo = model.PreviousInstitutionClearanceNo;
                entity.PreviousInstitutionClearanceDate = model.PreviousInstitutionClearanceDate;
                entity.AdmittedDepartmentId = model.AdmittedDepartmentId;
               
                db.SaveChanges();
                 
                return RedirectToAction("Edit", new { id = model.Id });

            }


            ViewBag.GenderId = new SelectList(db.Gender.OrderBy(m => m.GenderName), "Id", "GenderName");
            ViewBag.AdmittedDepartmentId = new SelectList(db.Department.OrderBy(m => m.Name), "Id", "Name");

            return View(model);
        }

        public ActionResult PreviousBoardExam(int id)
        {
            StudentInfoViewModel model = new StudentInfoViewModel();

            ViewBag.GenderId = new SelectList(db.Gender.OrderBy(m => m.GenderName), "Id", "GenderName");
            ViewBag.AdmittedDepartmentId = new SelectList(db.Department.OrderBy(m => m.Name), "Id", "Name");

            return View(model);
        }

        public ActionResult AttachDocument(int id)
        {
            StudentInfoViewModel model = new StudentInfoViewModel();

            ViewBag.GenderId = new SelectList(db.Gender.OrderBy(m => m.GenderName), "Id", "GenderName");
            ViewBag.AdmittedDepartmentId = new SelectList(db.Department.OrderBy(m => m.Name), "Id", "Name");

            return View(model);
        }
    }
}