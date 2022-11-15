using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NJAuto.Server.Services;
using NJAuto.Shared.Models;

namespace NJAuto.Server.Controllers
{

    [Route("api/CarService")]
    [ApiController]
    public class ServicesController : ControllerBase, ICarServices
    {
        private readonly CarService _carService;    
        [HttpPost]
        public Task AddCar(Car newCar)
        {
            var car = _carService.AddCar(newCar);
            return car; 
        }
        [HttpPut("{car}")]
        public Task EditCar(Car car)
        {
            var data = _carService.EditCar(car);
            return data;   
        }

        [HttpGet]
        public Task<List<Car>> GetCar()
        {
            var get = _carService.GetCar();
            return get;
        }


        [HttpDelete("{car}")]
        public Task RemoveCar(Car car)
        {
            var result =_carService.RemoveCar(car);  
            return result;
        }
    }
}
