using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using NJAuto.Server.Services;
using NJAuto.Shared.Models;

namespace NJAuto.Server.Controllers
{

    [Route("/carservice")]
    [ApiController]
    public class ServicesController : Controller
    {
        private readonly ICarService _carService;
        //private readonly IFormFile _file;
        public ServicesController(ICarService carService /*IFormFile file*/)
        {
            _carService = carService;
            //_file = file;
        }

       [HttpPost]
        public async Task<IResult> AddCar([FromBody] CarCreateModel newCar)
        {
            //if (ModelState.IsValid)
            //{
                //string stringCar = "";
                //newCar = JsonConvert.DeserializeObject<CarCreateModel>(stringCar);
                //if (_file.Length > 0)
                //    using (var ms = new MemoryStream())
                //    {
                //        _file.CopyTo(ms);
                //        newCar.ImageData = ms.ToArray();
                        await _carService.AddCar(newCar);
                        return Results.Ok();
                    //}
            //}
                //return Results.BadRequest();
          
        }

        [HttpPut("{car}")]
        public async Task EditCar(Car car)
        {
             await _carService.EditCar(car);
            
        }

        [HttpGet]
        public async Task<List<Car>> GetCar()
        {
            var get = await  _carService.GetCar();
            return get;
        }


        [HttpDelete("{car}")]
        public async Task RemoveCar([FromRoute] Car car)
        {
            await _carService.RemoveCar(car);
            
        }
    }
}
