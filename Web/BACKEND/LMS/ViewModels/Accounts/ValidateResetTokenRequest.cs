using System.ComponentModel.DataAnnotations;

namespace LMS.ViewModels.Accounts
{
    public class ValidateResetTokenRequest
    {
        [Required]
        public string Token { get; set; }
    }
}