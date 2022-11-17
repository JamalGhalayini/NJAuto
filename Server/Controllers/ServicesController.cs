using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NJAuto.Server.Services;
using NJAuto.Shared.Models;

namespace NJAuto.Server.Controllers
{

    [Route("api/CarService")]
    [ApiController]
    public class ServicesController : ControllerBase
    {
        private readonly ICarService _carService;
        public ServicesController(ICarService carService)
        {
            _carService = carService;   
        }

        [HttpPost]
        public async Task AddCar([FromBody] CarCreatModel newCar)
        {
           await _carService.AddCar(newCar);
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
