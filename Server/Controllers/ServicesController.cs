﻿using Microsoft.AspNetCore.Http;
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
      
        public ServicesController(ICarService carService )
        {
            _carService = carService;
           
        }

        [HttpPost]
        public async Task<ActionResult> AddCar([FromBody] CarCreateModel newCar)
        {
            if (ModelState.IsValid)
            {

                await _carService.AddCar(newCar);
                return Ok();
            }

            return BadRequest();

        }

        [HttpPut("{car}")]
        public async Task EditCar(Car car)
        {
            await _carService.EditCar(car);

        }

        [HttpGet]
        public async Task<List<Car>> GetCar()
        {
            var get = await _carService.GetCar();
            return get;
        }


        [HttpDelete("{carId}")]
        public async Task RemoveCar([FromRoute] int carId)
        {
            var result = await _carService.FindCar(carId);
            await _carService.RemoveCar(result);
            
        }

        [HttpGet("{request}")]
        public async Task<ActionResult<IEnumerable<Car>>> GetBrand([FromRoute] string request)
        {
            var carList = await _carService.GetCar();
            List<Car> brands = new();
            foreach (var car in carList)
            {
                if (car.Brand == request)
                {
                    brands.Add(car);
                }
            }
            if (brands.Count <= 0)
            {
                return BadRequest("Brand not found");
            }
           
            return Ok(brands);
        }


    }
}
