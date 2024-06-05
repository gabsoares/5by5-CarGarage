using Repositories;

namespace Controllers
{
    public class CarQueryController
    {
        private CarQueryRepository _carQueryRepository;

        public CarQueryController()
        {
            _carQueryRepository = new CarQueryRepository();
        }

        public List<String> GetCars(string query)
        {
            return _carQueryRepository.GetCar(query);
        }
    }
}