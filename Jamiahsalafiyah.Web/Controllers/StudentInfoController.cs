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
            //StudentInfoViewModel model = new StudentInfoViewModel();

            if (ModelState.IsValid)
            {
               

                    
               // _photoobj.FileContent = imgBinaryData;

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
            }


            ViewBag.GenderId = new SelectList(db.Gender.OrderBy(m => m.GenderName), "Id", "GenderName");
            ViewBag.AdmittedDepartmentId = new SelectList(db.Department.OrderBy(m => m.Name), "Id", "Name");

            return View(model);
        }
    }
}