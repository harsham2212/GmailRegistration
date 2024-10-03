using System.ComponentModel.DataAnnotations;

namespace GmailRegistration.Models
{
    // ViewModel for Step 1: Enter First and Last Name.
    public class RegisterStep1ViewModel
    {
        [Required(ErrorMessage = "First Name is required.")]
        [RegularExpression(@"^[a-zA-Z]+$", ErrorMessage = "First name must contain only letters.")]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "Last Name is required.")]
        [RegularExpression(@"^[a-zA-Z]+$", ErrorMessage = "Last name must contain only letters.")]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }
    }
}