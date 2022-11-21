using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NJAuto.Shared.Models
{
    public class CarCreateModel
    {

        [Required]
        [MaxLength(30, ErrorMessage = "BrandName is too long")]
        public string Brand { get; set; }

        [Required]
        [MaxLength(30, ErrorMessage = "ModelName is too long")]
        public string Model { get; set; }


        public string ImageTitle { get; set; }

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
        public string Detail { get; set; }
    }
}
