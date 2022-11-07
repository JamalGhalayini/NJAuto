using Microsoft.AspNetCore.Mvc;
using NJAuto.Shared.Models;

namespace NJAuto.Server.Controllers
{
    
    [Route("/carcontroller")]
    public class CarController 
    {
        [HttpGet]
        public async Task<IEnumerable<Car>> GetCars()
        { 
            List<Car> cars = new List<Car>();
            cars.Add(new Car
            {
                CarId = 1,
                NumberPlat = "CV1232",
                Imag="Cars/golf.jpg",
                Brand = "vw",
                Model = "Golf",
                Year = 2007,
                Km = 170000,
                Price = 40000
            });
            cars.Add(new Car
            {
                CarId = 2,
                NumberPlat = "CV2222",
                Imag = "Cars/2012-audi-a3.jpg",
                Brand = "Audi",
                Model = "A3",
                Year = 2012,
                Km = 150000,
                Price = 40000
            });
            return cars; 
        }
    }
}
