using Models;

namespace Repositories.Interface
{
    public interface ICarServiceRepository
    {
        bool InsertCarService(CarServiceModel carService);
    }
}
