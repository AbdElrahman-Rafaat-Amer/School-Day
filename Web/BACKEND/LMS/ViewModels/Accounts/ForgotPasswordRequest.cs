using System.ComponentModel.DataAnnotations;

namespace LMS.ViewModels.Accounts
{
    public class ForgotPasswordRequest
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
    }
}