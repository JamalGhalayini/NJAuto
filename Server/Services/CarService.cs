using NJAuto.Server.Data;
using NJAuto.Shared.Models;

namespace NJAuto.Server.Services
{
    public class CarService : ICarService
    {
        private readonly DataContext _db;
       
        public CarService(DataContext data)
        {
            _db = data;
        }
        public async Task AddCar(CarCreateModel car)
        {
    
          Car  newCar = new ()
            {
                Brand = car.Brand,
                Model = car.Model,
                ImageTitle = car.ImageTitle,
                ImageData = car.ImageData,
                Km = car.Km,
                YearModel = car.YearModel,
                Price = car.Price,
                Detail = car.Detail,
            };
          
            await _db.Car.AddAsync(newCar);
            await _db.SaveChangesAsync();
        }

        public async Task EditCar(Car car)
        {
            _db.Car.Update(car);
            await _db.SaveChangesAsync();  
        }

        public async Task<List<Car>> GetCar()
        {
           return await _db.Car.ToListAsync();
        }

        public async Task RemoveCar(Car car)
        {
            _db.Remove(car);
            await _db.SaveChangesAsync();
        }

        public async Task<Car> FindCar( int carId)
        {
            if (carId!=null)
            {
            var result = await _db.FindAsync<Car>(carId);
            return result;
            }
            return null;
        }
    }
}
