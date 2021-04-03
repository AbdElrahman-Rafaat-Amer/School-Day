using System;

namespace LMS.ViewModels.Accounts
{
    public class AccountResponse
    {
        public int Id { get; set; }
        public string Fname { get; set; }
        public string Mname { get; set; }
        public string Lname { get; set; }
        public string Gender { get; set; }
        public string Email { get; set; }
        public string NationalID { get; set; }
        public string Phone_1 { get; set; }
        public string Phone_2 { get; set; }
        public string Relegion { get; set; }
        public string Photo { get; set; }
        public string CurrentAddress { get; set; }
        public string PermanentAddress { get; set; }
        public string Role { get; set; }
        public DateTime Created { get; set; }
        public DateTime? Updated { get; set; }
        public bool IsVerified { get; set; }
    }
}