using NJAuto.Shared.Models;

namespace NJAuto.Server.Services
{
    public interface ICarService
    {
        public Task AddCar(CarCreateModel newCar);
        public Task RemoveCar(Car car);  
        public Task EditCar(Car car);
        public Task<List<Car>> GetCar();
        public Task<Car> FindCar(int carId);
    }
}
