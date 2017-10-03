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
        public byte[] StudentPhoto { get; set; }

        [Display(Name = "Bangla")]
        public string StudentNameBangla { get; set; }

        [Display(Name = "English")]
        public string StudentNameEnglish { get; set; }

        [Display(Name = "Arabic")]
        public string StudentNameArabic { get; set; }

        [Display(Name = "Student DOB")]
        public Nullable<System.DateTime> StudentDateOfBirth { get; set; }

        [Display(Name = "Gender")]
        public Nullable<int> GenderId { get; set; }

        [Display(Name = "Nationality")]
        public string Nationality { get; set; }

        [Display(Name = "Father Name Bangla")]
        public string FatherNameBangla { get; set; }

        [Display(Name = "Father Name English")]
        public string FatherNameEnglish { get; set; }

        [Display(Name = "Father Is Alive")]
        public Nullable<bool> FatherIsAlive { get; set; }

        [Display(Name = "Father Occupation")]
        public string FatherOccupation { get; set; }

        [Display(Name = "Father Mobile")]
        public string FatherMobile { get; set; }

        [Display(Name = "Mother Name Bangla")]
        public string MotherNameBangla { get; set; }

        [Display(Name = "Mother Name English")]
        public string MotherNameEnglish { get; set; }

        [Display(Name = "Mother Is Alive")]
        public Nullable<bool> MotherIsAlive { get; set; }

        [Display(Name = "Mother Mobile")]
        public string MotherMobile { get; set; }

        [Display(Name = "Guardian Name")]
        public string GuardianName { get; set; }

        [Display(Name = "Guardian Occupation")]
        public string GuardianOccupation { get; set; }

        [Display(Name = "Guardian House No")]
        public string GuardianHouseNo { get; set; }

        [Display(Name = "Guardian Village")]
        public string GuardianVillage { get; set; }

        [Display(Name = "Guardian PostOffice")]
        public string GuardianPostOffice { get; set; }

        [Display(Name = "Guardian Thana")]
        public string GuardianThana { get; set; }

        [Display(Name = "Guardian District")]
        public string GuardianDistrict { get; set; }

        [Display(Name = "Relation With Guardian")]
        public string RelationWithGuardian { get; set; }

        [Display(Name = "Yearly Income Guardian")]
        public Nullable<int> YearlyIncomeGuardian { get; set; }

        [Display(Name = "Permanent Address House")]
        public string PermanentAddressHouse { get; set; }

        [Display(Name = "Permanent Address Village")]
        public string PermanentAddressVillage { get; set; }

        [Display(Name = "Permanent Address PostOffice")]
        public string PermanentAddressPostOffice { get; set; }

        [Display(Name = "Permanent Address Thana")]
        public string PermanentAddressThana { get; set; }

        [Display(Name = "Permanent Address District")]
        public string PermanentAddressDistrict { get; set; }

        [Display(Name = "Honarable Person Name In Area")]
        public string HonarablePersonNameInArea { get; set; }

        [Display(Name = "Previous Institution Name")]
        public string PreviousInstitutionName { get; set; }

        [Display(Name = "Previous Institution Address")]
        public string PreviousInstitutionAddress { get; set; }

        [Display(Name = "Previous Institution Class")]
        public string PreviousInstitutionClass { get; set; }

        [Display(Name = "Previous Institution Clearance No")]
        public string PreviousInstitutionClearanceNo { get; set; }

        [Display(Name = "Previous Institution Clearance Date")]
        public Nullable<System.DateTime> PreviousInstitutionClearanceDate { get; set; }

        [Display(Name = "Admitted Department")]
        public Nullable<int> AdmittedDepartmentId { get; set; }
    }
}