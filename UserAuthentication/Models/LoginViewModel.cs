using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace UserAuthentication.Models
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "User Name or Email Required")]
        [MaxLength(20, ErrorMessage = "Max 20 Chaaracters Allowed")]
        [DisplayName("User Name or Email")]
        public string UserNameOrEmail { get; set; }

        [Required(ErrorMessage = "Password Required")]
        [StringLength(20, MinimumLength = 5, ErrorMessage = "Max 20 or Min 5 Characters Allowed")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
