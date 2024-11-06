using System.ComponentModel.DataAnnotations;

namespace Project.DTO.Request
{
    public class LoginDTO
    {
        [Required]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
    }
}
