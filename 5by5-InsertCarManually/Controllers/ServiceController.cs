using Models;
using Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controllers
{
    public class ServiceController
    {
        private ServiceModelService _serviceModelService;

        public ServiceController()
        {
            _serviceModelService = new ServiceModelService();
        }

        public bool InsertService(Service service)
        {
            return _serviceModelService.InsertService(service);
        }
    }
}