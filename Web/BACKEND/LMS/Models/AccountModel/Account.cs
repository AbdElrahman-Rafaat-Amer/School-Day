using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using LMS.Models.AdminModel;
using LMS.Models.DriverModel;
using LMS.Models.ParentModel;
using LMS.Models.RefreshTokenModel;
using LMS.Models.StudentModel;
using LMS.Models.TeacherModel;

namespace LMS.Models.AccountModel
{

    public enum Role
    {
        Admin,
        Teacher,
        Student,
        Driver,
        Parent
    }
    public class Account
    {
        public Account()
        {
            this.Groups = new HashSet<GroupModel.Group>();
        }
        [Key]
        public int Id { get; set; }
        public string Fname { get; set; }
        public string Mname { get; set; }
        public string Lname { get; set; }
        public string Email { get; set; }
        public string Photo { get; set; }
        public string Gender { get; set; }
        public string NationalID { get; set; }
        public string Phone_1 { get; set; }
        public string Phone_2 { get; set; }
        public string Relegion { get; set; }
        public string CurrentAddress { get; set; }
        public string PermanentAddress { get; set; }
        public string PasswordHash { get; set; }
        public Role Role { get; set; }
        public string VerificationToken { get; set; }  // The token that send on email to activate account
        public DateTime? Verified { get; set; }
        public bool IsVerified => Verified.HasValue || PasswordReset.HasValue;
        public string ResetToken { get; set; }         // The token that send on email to reset password
        public DateTime? ResetTokenExpires { get; set; }
        public DateTime? PasswordReset { get; set; }
        public DateTime Created { get; set; }
        public DateTime? Updated { get; set; }
        public List<RefreshToken> RefreshTokens { get; set; } // All refresh token that created during refresh browser
        public Student Student { get; set; }
        public Teacher Teacher { get; set; }
        public Parent Parent { get; set; }
        public Driver Driver { get; set; }
        public Admin Admin { get; set; }
        public ICollection<GroupModel.Group> Groups { get; set; }

        public bool OwnsToken(string token)
        {
            return this.RefreshTokens?.Find(x => x.Token == token) != null;
        }
    }
}
