using System.ComponentModel.DataAnnotations;

namespace PlatformServices.DbContextOptions{
    public class PlatformCreateDto
    {

        [Required, MaxLength(50)]
        public string Name { get; set; }
        [Required, MaxLength(100)]
        public string Publisher { get; set; }
        [Required, MaxLength(50)]
        public string Cost { get; set; }
    }
}