using NJAuto.Server.Data;
using NJAuto.Shared.Models;

namespace NJAuto.Server.Services
{
    public class CarService : ICarServices
    {
        private readonly DataContext _db;
        public CarService(DataContext data)
        {
            _db = data;
        }
        public async Task AddCar(Car newCar)
        {
            var addNewCar = await _db.Car.AddAsync(newCar);
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
