using Models;
using Services;

namespace Controllers
{
    public class CarController
    {
        private CarService _carService;

        public CarController()
        {
            _carService = new CarService();
        }

        public bool Insert(List<Car> cars)
        {
            return _carService.Insert(cars);
        }
    }
}