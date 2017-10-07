using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Jamiahsalafiyah.Web.Models
{
    public class StudentInfoPreviousInstitutionViewModel
    {
        public int Id { get; set; }
        public Nullable<int> StudentInfo_FK { get; set; }
        public string ExamName { get; set; }
        public string ExamYear { get; set; }
        public string InstitutionName { get; set; }
        public string InstitutionCode { get; set; }
        public string InstitutionDistrict { get; set; }
        public string RegiNo { get; set; }
        public string RollNo { get; set; }
        public string Grade { get; set; }
    }
}