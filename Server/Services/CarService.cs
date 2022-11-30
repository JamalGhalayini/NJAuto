using NJAuto.Server.Data;
using NJAuto.Shared.Models;

namespace NJAuto.Server.Services
{
    public class CarService : ICarService
    {
        private readonly AppDbContext _db;

        public CarService(AppDbContext data)
        {
            _db = data;
        }
        public async Task AddCar(CarCreateModel car)
        {

            Car newCar = new()
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

        public async Task<Car> EditCar(Car car, int id)
        {
            var result = await FindCar(id);
            if (result != null)
            {
                result.Brand = car.Brand;
                result.Model = car.Model;
                result.ImageTitle = car.ImageTitle;
                result.ImageData = car.ImageData;
                result.Km = car.Km;
                result.YearModel = car.YearModel;
                result.Price = car.Price;
                result.Detail = car.Detail;
                await _db.SaveChangesAsync();
            }
            return car;
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

        public async Task<Car> FindCar(int carId)
        {
            if (carId != null)
            {
                var result = await _db.FindAsync<Car>(carId);
                return result;
            }
            return null;
        }
    }
}
