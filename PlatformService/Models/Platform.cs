using System.ComponentModel.DataAnnotations;

namespace PlatformService.Models
{
    public class Platform{
        [Required]
        public int Id { get; set; }
        [Required, MaxLength(50)]
        public string Name { get; set; }
        [Required, MaxLength(100)]
        public string Publisher { get; set; }
        [Required, MaxLength(50)]
        public string Cost { get; set; }
    }
}