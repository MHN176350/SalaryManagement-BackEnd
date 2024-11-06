using System.ComponentModel.DataAnnotations;

namespace Project.DTO.Request
{
    public class PayrollReq
    {
        [Required]
        public int EmployeeId { get; set; }
        [Required]
        public DateTime dateTime { get; set; }
    }
}
