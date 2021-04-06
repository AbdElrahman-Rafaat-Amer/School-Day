using System.ComponentModel.DataAnnotations;

namespace LMS.ViewModels.Accounts
{
    public class VerifyEmailRequest
    {
        [Required]
        public string Token { get; set; }
    }
}