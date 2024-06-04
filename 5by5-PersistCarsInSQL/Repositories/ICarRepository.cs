using Models;

namespace Repositories
{
    public interface ICarRepository
    {
        bool InsertCarSql(List<Car> cars);
    }
}
