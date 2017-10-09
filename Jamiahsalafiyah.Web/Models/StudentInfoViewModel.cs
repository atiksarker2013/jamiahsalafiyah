using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Jamiahsalafiyah.Web.Models
{
    public class StudentInfoViewModel
    {
        public int Id { get; set; }

        [Display(Name = "Photo")]
        public byte[] StudentPhoto { get; set; }

        [Display(Name = "Bangla")]
        public string StudentNameBangla { get; set; }

        [Display(Name = "English")]
        public string StudentNameEnglish { get; set; }

        [Display(Name = "Arabic")]
        public string StudentNameArabic { get; set; }

        [Display(Name = "DOB")]
        public Nullable<System.DateTime> StudentDateOfBirth { get; set; }

        [Display(Name = "Gender")]
        public Nullable<int> GenderId { get; set; }

        [Display(Name = "Nationality")]
        public string Nationality { get; set; }

        [Display(Name = "Bangla")]
        public string FatherNameBangla { get; set; }

        [Display(Name = "English")]
        public string FatherNameEnglish { get; set; }

        [Display(Name = "Is Alive")]
        public Nullable<bool> FatherIsAlive { get; set; }

        [Display(Name = "Occupation")]
        public string FatherOccupation { get; set; }

        [Display(Name = "Mobile")]
        public string FatherMobile { get; set; }

        [Display(Name = "Bangla")]
        public string MotherNameBangla { get; set; }

        [Display(Name = "English")]
        public string MotherNameEnglish { get; set; }

        [Display(Name = "Is Alive")]
        public Nullable<bool> MotherIsAlive { get; set; }

        [Display(Name = "Mobile")]
        public string MotherMobile { get; set; }

        [Display(Name = "Name")]
        public string GuardianName { get; set; }

        [Display(Name = "Occupation")]
        public string GuardianOccupation { get; set; }

        [Display(Name = "House No")]
        public string GuardianHouseNo { get; set; }

        [Display(Name = "Village")]
        public string GuardianVillage { get; set; }

        [Display(Name = "PostOffice")]
        public string GuardianPostOffice { get; set; }

        [Display(Name = "Thana")]
        public string GuardianThana { get; set; }

        [Display(Name = "District")]
        public string GuardianDistrict { get; set; }

        [Display(Name = "Relation")]
        public string RelationWithGuardian { get; set; }

        [Display(Name = "Income")]
        public Nullable<int> YearlyIncomeGuardian { get; set; }

        [Display(Name = "#House")]
        public string PermanentAddressHouse { get; set; }

        [Display(Name = "Village")]
        public string PermanentAddressVillage { get; set; }

        [Display(Name = "Post-Office")]
        public string PermanentAddressPostOffice { get; set; }

        [Display(Name = "Thana")]
        public string PermanentAddressThana { get; set; }

        [Display(Name = "District")]
        public string PermanentAddressDistrict { get; set; }

        [Display(Name = "Name")]
        public string HonarablePersonNameInArea { get; set; }

        [Display(Name = "Name")]
        public string PreviousInstitutionName { get; set; }

        [Display(Name = "Address")]
        public string PreviousInstitutionAddress { get; set; }

        [Display(Name = "Class")]
        public string PreviousInstitutionClass { get; set; }

        [Display(Name = "Clr. No")]
        public string PreviousInstitutionClearanceNo { get; set; }

        [Display(Name = "Clr. Date")]
        public Nullable<System.DateTime> PreviousInstitutionClearanceDate { get; set; }

        [Display(Name = "Department")]
        public Nullable<int> AdmittedDepartmentId { get; set; }



        public List<StudentInfoPreviousInstitutionViewModel> _previousInstitutionList = new List<StudentInfoPreviousInstitutionViewModel>();

        public List<StudentInfoPreviousInstitutionViewModel> PreviousInstitutionList { get; set; }

        public List<StudentAttachFileViewModel> StudentAttachFileList = new List<StudentAttachFileViewModel>();

       // public List<StudentAttachFileViewModel> _studentAttachFileList { get; set; }
    }
}