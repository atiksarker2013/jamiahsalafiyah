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
            
                try
                {
                    // logger.Info("Mgt Client Contact Index() invoked by:" + GlobalClass.ProfileUser.FirstName + " " + GlobalClass.ProfileUser.LastName);

                    StudentModelView obj = new StudentModelView();
                    obj.StudentModelList = new List<StudentModel>();
                    // obj.StudentModelList = manage.ListAll();

                   // List<StudentModel> studentObjList = new List<StudentModel>();
                    var temp = (from x in db.StudentInfo
                                
                                select new StudentModel
                                {
                                    StudentPhoto = x.StudentPhoto,
                                    StudentNameEnglish = x.StudentNameEnglish,
                                    FatherNameEnglish = x.FatherNameEnglish,
                                    MotherNameEnglish = x.MotherNameEnglish,
                                    FatherMobile = x.FatherMobile,
                                   // IsActive = x.IsActive
                                }).OrderBy(m => m.StudentNameEnglish);

                    obj.StudentModelList = temp.ToList();


                    // Tab Data
                    ThumbnailViewModel model = new ThumbnailViewModel();
                    model.ThumbnailModelList = new List<ThumbnailModel>();

                    // batch your List data for tab view i want batch by 2 you can set your value

                    //var listOfBatches = obj.ClientContactViewModelList.Batch(2);
                    var listOfBatches = obj.StudentModelList.Batch(6);

                    int tabNo = 1;

                    foreach (var batchItem in listOfBatches)
                    {
                        // Generating tab
                        ThumbnailModel thumbObj = new ThumbnailModel();
                        thumbObj.ThumbnailLabel = "Lebel" + tabNo;
                        thumbObj.ThumbnailTabId = "tab" + tabNo;
                        thumbObj.ThumbnailTabNo = tabNo;
                        thumbObj.Thumbnail_Aria_Controls = "tab" + tabNo;
                        thumbObj.Thumbnail_Href = "#tab" + tabNo;

                        // batch details

                        thumbObj.StudentInfosList = new List<StudentModel> ();

                        foreach (var item in batchItem)
                        {
                            StudentModel detailsObj = new StudentModel();
                            detailsObj = item;
                            thumbObj.StudentInfosList.Add(detailsObj);
                        }

                        model.ThumbnailModelList.Add(thumbObj);

                        tabNo++;
                    }

                    // Getting first tab data
                    var first = model.ThumbnailModelList.FirstOrDefault();

                    // Getting first tab data
                    var last = model.ThumbnailModelList.LastOrDefault();

                    foreach (var item in model.ThumbnailModelList)
                    {
                        if (item.ThumbnailTabNo == first.ThumbnailTabNo)
                        {
                            item.Thumbnail_ItemPosition = "First";
                        }

                        if (item.ThumbnailTabNo == last.ThumbnailTabNo)
                        {
                            item.Thumbnail_ItemPosition = "Last";
                        }

                    }

                    return View(model);
                }
                catch (Exception ex)
                {
                    //logger.Error(ex, "Index");
                    return View("Error", new HandleErrorInfo(ex, "Home", "UserHome"));
                }
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
                        _sdb.StudentInfoPreviousInstitution.Add(_studentInfoPreviousInstitutionEntity);
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

            model.PreviousInstitutionList = new List<StudentInfoPreviousInstitutionViewModel>();
            model.Id = id;

            //var entity = db.StudentInfoPreviousInstitution.Where(m=>m.StudentInfo_FK == id);

            IQueryable<StudentInfoPreviousInstitution> query = db.StudentInfoPreviousInstitution.Where(m => m.StudentInfo_FK == id);

            var data = query.Select(asset => new StudentInfoPreviousInstitutionViewModel()
            {
                Id = asset.Id,
                StudentInfo_FK = asset.StudentInfo_FK,
                ExamName = asset.ExamName,
                ExamYear = asset.ExamYear,
                InstitutionName = asset.InstitutionName,
                InstitutionCode = asset.InstitutionCode,
                InstitutionDistrict = asset.InstitutionDistrict,
                RegiNo = asset.RegiNo,
                RollNo = asset.RollNo,
                Grade = asset.Grade
            }).ToList();

            model.PreviousInstitutionList = data;

            return View(model);
        }

        public ActionResult AttachDocument(int id)
        {
            StudentInfoViewModel model = new StudentInfoViewModel();

            model.StudentAttachFileList = new List<StudentAttachFileViewModel>();
            model.Id = id;

            IQueryable<StudentAttachFile> query = db.StudentAttachFile.Where(m => m.Student_FK == id);

            var data = query.Select(asset => new StudentAttachFileViewModel()
            {
                Id = asset.Id,
                Student_FK = asset.Student_FK,
                FileType = asset.FileType,
                FileContent = asset.FileContent,
                FileName = asset.FileName,
                Description = asset.Description 
            }).ToList();

            model.StudentAttachFileList = data;

            return View(model);
        }


        [HttpPost]
        public ActionResult AttachDocument(StudentInfoViewModel model, HttpPostedFileBase PostedLogo)
        {

            if (PostedLogo != null)
            {
                StudentAttachFileViewModel _photoobj = new StudentAttachFileViewModel();
               // _photoobj.PhotoKey = Guid.NewGuid();
                _photoobj.Student_FK = model.Id;

                byte[] imgBinaryData = new byte[PostedLogo.ContentLength];
                int readresult = PostedLogo.InputStream.Read(imgBinaryData, 0, PostedLogo.ContentLength);
                _photoobj.FileContent = imgBinaryData;
                _photoobj.FileName = PostedLogo.FileName;
                _photoobj.FileType = PostedLogo.ContentType;

                StudentAttachFile entity = new StudentAttachFile();

                //entity.Id = bo.PhotoKey;
                entity.Student_FK = _photoobj.Student_FK;
                entity.FileType = _photoobj.FileType;
                entity.FileContent = _photoobj.FileContent;
                entity.FileName = _photoobj.FileName;
                entity.Description = _photoobj.Description;

                db.StudentAttachFile.Add(entity);
                db.SaveChanges();

            }
            else
            {
                // Remove Photo
                foreach (var item in model.StudentAttachFileList)
                {
                    StudentAttachFile entityrem = db.StudentAttachFile.Find(item.Id);
                    db.StudentAttachFile.Remove(entityrem);
                    db.SaveChanges();
                }

                // Add Photo
                foreach (var item in model.StudentAttachFileList)
                {
                    StudentAttachFile entity = new StudentAttachFile();

                    entity.Student_FK = item.Student_FK;
                    entity.FileType = item.FileType;
                    entity.FileContent = item.FileContent;
                    entity.FileName = item.FileName;
                    entity.Description = item.Description;

                    db.StudentAttachFile.Add(entity);
                    db.SaveChanges();
                }

                model.StudentAttachFileList = new List<StudentAttachFileViewModel>();

                IQueryable<StudentAttachFile> query = db.StudentAttachFile.Where(m => m.Student_FK == model.Id);

                var data = query.Select(asset => new StudentAttachFileViewModel()
                {
                    Id = asset.Id,
                    Student_FK = asset.Student_FK,
                    FileType = asset.FileType,
                    FileContent = asset.FileContent,
                    FileName = asset.FileName,
                    Description = asset.Description
                }).ToList();

                model.StudentAttachFileList = data;
            }

            return View(model);
        }
    }
}