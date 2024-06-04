using Models;
using Repositories;
using Repositories.Interface;

namespace Services
{
    public class CarServiceModelService
    {
        private ICarServiceRepository _carServiceRepository;

        public CarServiceModelService()
        {
            _carServiceRepository = new CarServiceModelRepository();
        }

        public bool InsertCarService(CarServiceModel carService)
        {
            return _carServiceRepository.InsertCarService(carService);
        }
    }
}