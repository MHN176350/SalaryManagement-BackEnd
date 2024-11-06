using System.ComponentModel.DataAnnotations;

namespace Project.DTO.Request
{
    public class FirstChangePasswordReq
    {
        [Required]
        public string Password { get; set; }
    }
}
