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
                year = 2007,
                Km = 200000,
                Price = 40000
            });
            return cars;
        }
    }
}
