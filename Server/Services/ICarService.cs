using NJAuto.Shared.Models;

namespace NJAuto.Server.Services
{
    public interface ICarService
    {
        public Task AddCar(CarCreatModel newCar);
        public Task RemoveCar(Car car);  
        public Task EditCar(Car car);
        public Task<List<Car>> GetCar();
    }
}
