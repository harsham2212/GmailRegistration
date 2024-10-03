using System.ComponentModel.DataAnnotations;

namespace GmailRegistration.Models
{
    // ViewModel for Step 7: Add Recovery Email.
    public class RegisterStep7ViewModel
    {
        [EmailAddress(ErrorMessage = "Please enter a valid recovery email address.")]
        [Display(Name = "Recovery Email (Optional)")]
        public string? RecoveryEmail { get; set; }
    }
}