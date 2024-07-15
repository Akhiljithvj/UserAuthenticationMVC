using System.ComponentModel.DataAnnotations;

namespace UserAuthentication.Models
{
    public class RegistrationViewModel
    {
        [Required(ErrorMessage = "First Name Required")]
        [MaxLength(50, ErrorMessage = "Max 50 Chaaracters Allowed")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Last Name Required")]
        [MaxLength(50, ErrorMessage = "Max 50 Chaaracters Allowed")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Email Required")]
        [MaxLength(100, ErrorMessage = "Max 100 Chaaracters Allowed")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required(ErrorMessage = "User Name Required")]
        [MaxLength(20, ErrorMessage = "Max 20 Chaaracters Allowed")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Password Required")]
        [StringLength(20, MinimumLength = 5, ErrorMessage = "Max 20 or Min 5 Characters Allowed")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Compare("Password", ErrorMessage = "Please Confirm your Password")]
        [DataType(DataType.Password)]
        public string ConfirmPassword { get; set; }
    }
}
