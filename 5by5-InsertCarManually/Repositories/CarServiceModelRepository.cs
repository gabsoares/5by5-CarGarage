using Dapper;
using Microsoft.Data.SqlClient;
using Models;
using Repositories.Interface;
using System.Configuration;

namespace Repositories
{
    public class CarServiceModelRepository : ICarServiceRepository
    {
        private string Conn;

        public CarServiceModelRepository()
        {
            Conn = ConfigurationManager.ConnectionStrings["StringConnection"].ConnectionString;
        }

        public bool InsertCarService(CarServiceModel carService)
        {
            bool result = false;

            try
            {
                using (var db = new SqlConnection(Conn))
                {
                    db.Open();
                    db.Execute(CarServiceModel.INSERT, new
                    {
                        CarId = carService.Car.CarPlate,
                        ServiceId = carService.Service.Id,
                        StatusService = carService.Status
                    });
                    db.Close();
                }
                result = true;
            }
            catch (Exception)
            {
                throw;
            }
            return result;
        }
    }
}
