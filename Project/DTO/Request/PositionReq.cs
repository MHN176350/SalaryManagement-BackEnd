using System.ComponentModel.DataAnnotations;

namespace Project.DTO.Request
{
    public class PositionReq
    {
        [Required]
        public string PositionName { get; set; }
    }
}
