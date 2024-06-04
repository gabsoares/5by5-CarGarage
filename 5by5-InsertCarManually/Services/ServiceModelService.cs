using Models;
using Repositories;
using Repositories.Interface;

namespace Services
{
    public class ServiceModelService
    {
        private IServiceRepository _serviceRepository;

        public ServiceModelService()
        {
            _serviceRepository = new ServiceRepository();
        }

        public bool InsertService(Service service)
        {
            return _serviceRepository.InsertService(service);
        }
    }
}
