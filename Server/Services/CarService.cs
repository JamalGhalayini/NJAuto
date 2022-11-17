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
        public async Task AddCar(CarCreatModel newCar)
        {
            var creatNewCar = new Car()
            {
                Brand = newCar.Brand,
                Model = newCar.Model,
                ImageTitle = newCar.ImageTitle,
                ImageData = newCar.ImageData,
                Km = newCar.Km,
                YearModel = newCar.YearModel,
                Price = newCar.Price,
                Detail = newCar.Detail,
            };
            await _db.Car.AddAsync(creatNewCar);
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
    }
}
