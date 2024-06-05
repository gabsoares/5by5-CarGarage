using Dapper;
using Microsoft.Data.SqlClient;
using Models;
using System.Configuration;
using System.Text;

namespace Repositories
{
    public class CarQueryRepository : ICarQueryRepository
    {
        private string Conn;

        public CarQueryRepository()
        {
            Conn = ConfigurationManager.ConnectionStrings["StringConnection"].ConnectionString;
        }

        public List<String> GetCar(string querySelect)
        {
            List<Car> cars = new();
            List<String> lst = new();
            try
            {
                using (var db = new SqlConnection(Conn))
                {
                    db.Open();
                    var query = db.Query(querySelect);
                    foreach (var car in query)
                    {
                        cars.Add(new Car
                        {
                            CarPlate = car.CAR_PLATE,
                            CarName = car.CAR_NAME,
                            CarColor = car.CAR_COLOR,
                            ModelYear = car.MODEL_YEAR,
                            FabricationYear = car.FABRICATION_YEAR
                        });
                    }
                    foreach (var item in cars)
                    {
                        StringBuilder sb = new();
                        sb.Append($"{item.CarPlate}.");
                        sb.Append($"{item.CarName}.");
                        sb.Append($"{item.CarColor}.");
                        sb.Append($"{item.ModelYear}.");
                        sb.Append($"{item.FabricationYear}.");
                        lst.Add(sb.ToString());
                    }
                    db.Close();
                }
            }
            catch (Exception)
            {
                throw;
            }
            return lst;
        }
    }
}