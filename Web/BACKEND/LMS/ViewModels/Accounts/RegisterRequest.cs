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
        public string ConfirmPassword { get; set; }
        [Required]
        public string Role { get; set; }
        [Required]
        public string Phone_1 { get; set; }
        public string LicenseID { get; set; }

    }
}