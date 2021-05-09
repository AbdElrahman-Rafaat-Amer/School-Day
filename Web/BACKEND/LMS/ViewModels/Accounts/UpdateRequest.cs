using System.ComponentModel.DataAnnotations;
using LMS.Models.AccountModel;

namespace LMS.ViewModels.Accounts
{
    public class UpdateRequest
    {

        private string _password;
        private string _confirmPassword;
        private string _role;
        private string _email;

        public string Fname { get; set; }
        public string Mname { get; set; }
        public string Lname { get; set; }
        public string NationalID { get; set; }
        public string Phone_1 { get; set; }
        public string Phone_2 { get; set; }
        public string Gender { get; set; }
        public string Relegion { get; set; }
        public string CurrentAddress { get; set; }
        public string PermanentAddress { get; set; }

       

        [EnumDataType(typeof(Role))]
        public string Role
        {
            get => _role;
            set => _role = replaceEmptyWithNull(value);
        }


        [EmailAddress]
        public string Email
        {
            get => _email;
            set => _email = replaceEmptyWithNull(value);
        }

        [MinLength(6)]
        public string Password
        {
            get => _password;
            set => _password = replaceEmptyWithNull(value);
        }

        [Compare("Password")]
        public string ConfirmPassword 
        {
            get => _confirmPassword;
            set => _confirmPassword = replaceEmptyWithNull(value);
        }

        // helpers

        private string replaceEmptyWithNull(string value)
        {
            // replace empty string with null to make field optional
            return string.IsNullOrEmpty(value) ? null : value;
        }
    }
}