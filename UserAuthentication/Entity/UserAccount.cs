using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace UserAuthentication.Entity
{
    [Index(nameof(Email),IsUnique =true)]
    [Index(nameof(UserName),IsUnique =true)]
    public class UserAccount
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage ="First Name Required")]
        [MaxLength(50, ErrorMessage = "Max 50 Chaaracters Allowed")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Last Name Required")]
        [MaxLength(50, ErrorMessage = "Max 50 Chaaracters Allowed")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Email Required")]
        [MaxLength(100, ErrorMessage = "Max 100 Chaaracters Allowed")]
        public string Email { get; set; }

        [Required(ErrorMessage = "User Name Required")]
        [MaxLength(20, ErrorMessage = "Max 20 Chaaracters Allowed")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Password Required")]
        [MaxLength(20, ErrorMessage = "Max 20 Chaaracters Allowed")]
        public string Password { get; set; }
        
    }
}
