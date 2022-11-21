using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NJAuto.Shared.Models
{
    public class CarCreateModel
    {

        //[Required]
        //[MaxLength(30, ErrorMessage = "BrandName is too long")]
        public string Brand { get; set; }

        //[Required]
        //[MaxLength(30, ErrorMessage = "ModelName is too long")]
        public string Model { get; set; }


        public string ImageTitle { get; set; }

        //[Required]
        public byte[] ImageData { get; set; }

        //[Required]
        //[MaxLength(7, ErrorMessage = "Km is too long")]
        public double Km { get; set; }

        //[Required]
        //[MaxLength(4, ErrorMessage = "YearModel is too far")]
        public int YearModel { get; set; }

        //[Required]
        //[MaxLength(10, ErrorMessage = "Price is way too much")]
        public double Price { get; set; }

        //[Required]
        //[MaxLength(200, ErrorMessage = "You wrote too much")]
        public string Detail { get; set; }
    }
}
