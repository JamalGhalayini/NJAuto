using NJAuto.Shared.Models;

namespace NJAuto.Server.Controllers.Services
{
    public interface ICarServices
    {
        public Task AddCar(Car newCar);
        public Task RemoveCar(Car Car);  
        public Task EditCar(Car Car);
        public Task<IEnumerable<Car>> GetCar();
    }
}
