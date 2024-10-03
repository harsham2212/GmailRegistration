using System.ComponentModel.DataAnnotations;

namespace GmailRegistration.Models
{
    // ViewModel for Step 9: Privacy and Terms.
    public class RegisterStep9ViewModel
    {
        [Required(ErrorMessage = "You must agree to the terms and privacy policy to proceed.")]
        [Display(Name = "I agree to the Terms and Privacy Policy")]
        public bool Agree { get; set; }
    }
}