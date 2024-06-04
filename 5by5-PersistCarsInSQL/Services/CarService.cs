using Models;
using Repositories;

namespace Services
{
    public class CarService
    {
        private ICarRepository _carRepository;

        public CarService()
        {
            _carRepository = new CarRepository();
        }

        public bool Insert(List<Car> cars)
        {
            return _carRepository.InsertCarSql(cars);
        }
    }
}
