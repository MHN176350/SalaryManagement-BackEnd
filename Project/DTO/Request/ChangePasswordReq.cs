using System.ComponentModel.DataAnnotations;

namespace Project.DTO.Request
{
    public class ChangePasswordReq
    {
        [Required]
        public string Password { get; set; }
        [Required]
        public string? ConfirmPassword { get; set; }
    }
}
