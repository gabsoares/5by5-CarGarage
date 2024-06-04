using Dapper;
using Microsoft.Data.SqlClient;
using Models;
using System.Configuration;

namespace Repositories
{
    public class CarRepository : ICarRepository
    {
        private string Conn {  get; set; }

        public CarRepository()
        {
            Conn = ConfigurationManager.ConnectionStrings["StringConnection"].ConnectionString;
        }

        public bool InsertCarSql(List<Car> cars)
        {
            bool status = false;
            foreach (var car in cars) 
            {
                try
                {
                    using (var db = new SqlConnection(Conn))
                    {
                        db.Open();
                        db.Execute(Car.INSERT, new
                        {
                            Plate = car.CarPlate,
                            Name = car.CarName,
                            Color = car.CarColor,
                            ModelYear = car.ModelYear,
                            FabricationYear = car.FabricationYear
                        });
                        db.Close();
                        status = true;
                    }
                }
                catch (Exception)
                {
                    throw;
                }
            }
            return status;
        }
    }
}