using System.ComponentModel.DataAnnotations;

namespace PlatformService.Models
{
    public class Platform{
        [Required]
        public int Id { get; set; }
        [Required, MaxLength(50)]
        public string Name { get; set; } = null!;
        [Required, MaxLength(100)]
        public string Publisher { get; set; } = null!;
        [Required, MaxLength(50)]
        public string Cost { get; set; } = null!;
    }
}