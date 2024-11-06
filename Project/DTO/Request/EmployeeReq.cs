using Project.Enum;
using System.ComponentModel.DataAnnotations;

namespace Project.DTO.Request
{
    public class EmployeeReq
    {
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public EnumList.Gender Gender { get; set; }
        [Required]
        public DateTime Dob { get; set; }
        [Required, MinLength(9), MaxLength(12)]
        public string CCCD { get; set; }
        [Required, MinLength(9), MaxLength(12)]
        public string Phone { get; set; }
        [Required]
        public string Address { get; set; }


    }
}
