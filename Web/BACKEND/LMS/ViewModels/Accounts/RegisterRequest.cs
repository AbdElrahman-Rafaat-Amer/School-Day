using Org.BouncyCastle.Asn1.Ocsp;
using System.ComponentModel.DataAnnotations;
using LMS.Helpers;
using LMS.Models.AccountModel;
using LMS.Models.YearModel;

namespace LMS.ViewModels.Accounts
{
    public class RegisterRequest
    {
        [Required]
        public string Fname { get; set; }
        [Required]
        public string Mname { get; set; }
        [Required]
        public string Lname { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Gender { get; set; }
        [Required]
        public string NationalID { get; set; }
        [Required]
        [MinLength(6)]
        public string Password { get; set; }
        [Required]
        [Compare("Password")]
        public string ConfirmPassword { get; set; }
        [Required]
        public Role Role { get; set; }
        public string UserRoleValidation
        {
            get => (Role.Admin == Role ? "Admin"
                : (Role == Role.Student ? "Student"
                : Role == Role.Teacher ? "Teacher"
                : (Role == Role.Parent ? "Parent" : "Driver")));
        }
        [Required]
        public string Phone_1 { get; set; }
        [Required]
        public string Phone_2 { get; set; }
        [Required]
        public string Relegion { get; set; }
        [Required]
        public string CurrentAddress { get; set; }
        [Required]
        public string PermanentAddress { get; set; }

        [RequiredIf(new string[] { "UserRoleValidation,Student,Admin,Teacher" })]
        public string AddmitionNum { get; set; }
        public float Height { get; set; }
        public float Weight { get; set; }

        //[RequiredIf(new string[] { "UserRoleValidation,Student" })]
        //public Year Year { get; set; }

        [RequiredIf(new string[] { "UserRoleValidation,Driver" })]
        public string LicenseID { get; set; }

    }
}