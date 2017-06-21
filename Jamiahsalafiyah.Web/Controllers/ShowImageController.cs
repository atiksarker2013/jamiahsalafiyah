using Jamiahsalafiyah.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Jamiahsalafiyah.Web.Controllers
{
    public class ShowImageController : Controller
    {
        // GET: ShowImage
        private JAMAIAHSALAFIYAH_HOUSTONEntities db = new JAMAIAHSALAFIYAH_HOUSTONEntities();

        
    
        public ActionResult GetCompanyLogo(Guid id)
        {

            Company obj = db.Company.SingleOrDefault(m => m.CompanyKey == id);

            if (obj.Logo != null)
                return File(obj.Logo, obj.LogoType);
            else
            {
                ImageFile faoimagefile = db.ImageFile.Single(f => f.ImageFileKey == 1);
                return File(faoimagefile.FileContent, faoimagefile.FileType);
            }
        }
        public ActionResult GetImageLogo(int id)
        {

            ImageFile faoimagefile = db.ImageFile.Single(f => f.ImageFileKey == id);
            return File(faoimagefile.FileContent, faoimagefile.FileType);

        }
        public ActionResult GetUserPic(Guid id)
        {

            StaffList obj = db.StaffList.SingleOrDefault(m => m.PersonnelKey == id);

            if (obj.Pic != null)
                return File(obj.Pic, obj.PicType);
            else
            {
                ImageFile faoimagefile = db.ImageFile.Single(f => f.ImageFileKey == 1);
                return File(faoimagefile.FileContent, faoimagefile.FileType);
            }
        }
       

      
    }
}