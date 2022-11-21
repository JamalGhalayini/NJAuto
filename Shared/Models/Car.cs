using System.ComponentModel.DataAnnotations;

namespace NJAuto.Shared.Models
{
    public class Car
    {


        public int CarId { get; set; }


        public string Brand { get; set; }


        public string Model { get; set; }


        public string ImageTitle { get; set; }


        public byte[] ImageData { get; set; }


        public double Km { get; set; }


        public int YearModel { get; set; }


        public double Price { get; set; }


        public string Detail { get; set; }

    }



}
