using System.ComponentModel.DataAnnotations;

namespace NJAuto.Shared.Models
{
    public class Car
    {

        [Required]
        public int CarId { get; set; }

        [Required]
        [MaxLength(20, ErrorMessage = "BrandName is too long")]
        public string Brand { get; set; } = string.Empty;

        [Required]
        [MaxLength(20, ErrorMessage = "ModelName is too long")]
        public string Model { get; set; } = string.Empty;


        public string ImageTitle { get; set; } = string.Empty;

        [Required]
        public byte[] ImageData { get; set; }

        [Required]
        [Range(0, 1000000, ErrorMessage = "Km must be between 0 to 1000000000")]
        public double Km { get; set; }

        [Required]
        [Range(1886, 9999, ErrorMessage = "YearModel must be between 1886 to 9999")]
        public int YearModel { get; set; }

        [Required]
        public double Price { get; set; }

        [Required]
        [MaxLength(200, ErrorMessage = "You wrote too much")]
        public string Detail { get; set; } = string.Empty;
    }
}




