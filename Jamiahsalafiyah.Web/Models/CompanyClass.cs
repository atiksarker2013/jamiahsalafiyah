﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Jamiahsalafiyah.Web.Models
{
    public class CompanyClass
    {
        public System.Guid CompanyKey { get; set; }
        [Display(Name = "ID")]
        public string CompanyID { get; set; }
        [Display(Name = "Company Name*")]
        [Required(ErrorMessage = "Company Name is required")]
        public string CompanyName { get; set; }
        [Display(Name = "Address")]
        public string CompanyAddress { get; set; }
        [Display(Name = "Telephone")]
        [Required(ErrorMessage = "Telephone Number is required")]
        public string CompanyPhone { get; set; }
        [Display(Name = "Alternate Contact #")]
        public string CompanyMobile { get; set; }
        [Display(Name = "Email")]
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        [RegularExpression("^[a-zA-Z0-9_\\.-]+@([a-zA-Z0-9-]+\\.)+[a-zA-Z]{2,6}$", ErrorMessage = "E-mail is not valid")]
        public string CompanyEmail { get; set; }
        [Display(Name = "Website")]
        public string CompanyWebsite { get; set; }
        [Display(Name = "Fax")]
        public string CompanyFax { get; set; }
        [Display(Name = "Represented By")]
        public string ContactPersonName { get; set; }
        [Display(Name = "Telephone")]
        public string ContactPersonNo { get; set; }
        public byte[] Logo { get; set; }
        public string LogoType { get; set; }
        public Nullable<bool> IsDelete { get; set; }
        [Required(ErrorMessage = "The State name is required")]
        public Nullable<int> StateCode { get; set; }
        [Required(ErrorMessage = "The City Name is required")]
        public Nullable<int> CityKey { get; set; }
        [Required(ErrorMessage = "The Zipcode is required")]
        public Nullable<long> ZIPKey { get; set; }
        [Display(Name = "Title")]
        public string Title { get; set; }
        [Display(Name = "Email")]
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        [RegularExpression("^[a-zA-Z0-9_\\.-]+@([a-zA-Z0-9-]+\\.)+[a-zA-Z]{2,6}$", ErrorMessage = "E-mail is not valid")]
        public string ContactEmail { get; set; }

        //public virtual CityList CityList { get; set; }
        //public virtual StateList StateList { get; set; }
        //public virtual ZIPList ZIPList { get; set; }
    }

    public class tempForm
    {

        public List<Forms> Formlist { get; set; }


    }
    public class tempDocType
    {
        public System.Guid ID { get; set; }
        public string TName { get; set; }
        public string ColorCode { get; set; }
        public Nullable<bool> IsDelete { get; set; }
        public Nullable<int> DocumentForID { get; set; }

        //public virtual DocumentFor DocumentFor { get; set; }
    }
    public class StaffClass
    {
        public System.Guid PersonnelKey { get; set; }
        [Display(Name = "ID")]
        public string PID { get; set; }
        [Display(Name = "Full Name*")]
        [Required(ErrorMessage = "Full Name is required")]
        public string PName { get; set; }
        [Display(Name = "Contact No*")]
        [Required(ErrorMessage = "Contact No is required")]
        public string Mobile { get; set; }
        [Display(Name = "Email")]
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        [RegularExpression("^[a-zA-Z0-9_\\.-]+@([a-zA-Z0-9-]+\\.)+[a-zA-Z]{2,6}$", ErrorMessage = "E-mail is not valid")]
        public string Mail { get; set; }
        [Display(Name = "Designation")]
        public string Designation { get; set; }
        [Display(Name = "Department")]
        public string Department { get; set; }
        public Nullable<System.Guid> DepartmentKey { get; set; }
        public byte[] Pic { get; set; }
        public string PicType { get; set; }
        public Nullable<System.Guid> CompanyKey { get; set; }
        [Required(ErrorMessage = "Usergroup is not selected Correctly")]
        public Nullable<System.Guid> Usergr { get; set; }
        [Display(Name = "Username*")]
        [Required(ErrorMessage = "Username is required")]
        public string Username { get; set; }
        [Display(Name = "Password*")]
        [Required(ErrorMessage = "Password is required")]
        public string Password { get; set; }
        [Display(Name = "Confirm Password*")]
        [Required(ErrorMessage = "Please enter the Password again.")]
        [Compare("Password", ErrorMessage = "Your Confirm Password does not match.")]
        public string ConfirmPassword { get; set; }
        public Nullable<bool> IsUser { get; set; }
        public virtual Usergroup Usergroup { get; set; }
    }
}