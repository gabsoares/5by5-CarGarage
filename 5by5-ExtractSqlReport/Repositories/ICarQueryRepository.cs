namespace Repositories
{
    public interface ICarQueryRepository
    {
        List<String> GetCar(string query);
    }
}
