using System.ComponentModel.DataAnnotations;

namespace Angular23TFASPMVC.Models
{
    public class LoginDTO
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [MinLength(8)]
        [MaxLength(25)]
        [DataType(DataType.Password)]
        [RegularExpression(@"^(?=.*\d)(?=.*[a-z])(?=.*[A-Z])(?=.*[a-zA-Z])(?=.*[$@#%&!?=_-]).{8,25}$", ErrorMessage = "Doit contenir cici ca ca")]
        public string Password { get; set; }

    }
}
