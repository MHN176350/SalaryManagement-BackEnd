using System.ComponentModel.DataAnnotations;

namespace Project.DTO.Request
{
    public class LevelReq
    {
        [Required]
        public string LevelName { get; set; }
    }
}
