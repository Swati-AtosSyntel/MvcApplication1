using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MvcApplication1.Models
{
    public class Employee
    {
        [Required(ErrorMessage ="Enter Employee ID")]
        [Display(Name ="Employee ID")]
        public int empid { get; set; }
        [Required(ErrorMessage = "Enter Employee Name")]
        [Display(Name = "Employee Name")]
        public string ename { get; set; }
        [Required(ErrorMessage = "Enter work location")]
        [Display(Name = "Work Location")]
        public string location { get; set; }
        [Required(ErrorMessage = "Enter username ")]
        [Display(Name = "Username")]

        public string username { get; set; }
        [Required(ErrorMessage = "Enter password")]
        [Display(Name = "Password")]
        [DataType(DataType.Password)]
        public string password { get; set; }
        [Required(ErrorMessage = "Enter Password again")]
        [Display(Name = "Confirm Password")]
        [Compare("password",ErrorMessage ="It should match with password")]
        [DataType(DataType.Password)]
        public string ConfirmPassword { get; set; }
       

        [Required(ErrorMessage = "Enter Email Address")]
        [Display(Name = "Email Address")]
        [EmailAddress]
        
        public string Email { get; set; }
        [ScaffoldColumn(false)]
        public int zipcode { get; set; }

    }
}