using Models;
using Services;

namespace Controllers
{
    public class CarServiceController
    {
        private CarServiceModelService _carServiceModelService;

        public CarServiceController()
        {
            _carServiceModelService = new CarServiceModelService();
        }

        public bool InsertCarService(CarServiceModel carService)
        {
            return _carServiceModelService.InsertCarService(carService);
        }
    }
}