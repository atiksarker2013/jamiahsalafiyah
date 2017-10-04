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
    }
}