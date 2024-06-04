using Dapper;
using Microsoft.Data.SqlClient;
using Models;
using Repositories.Interface;
using System.Configuration;

namespace Repositories
{
    public class ServiceRepository : IServiceRepository
    {
        private string Conn;

        public ServiceRepository()
        {
            Conn = ConfigurationManager.ConnectionStrings["StringConnection"].ConnectionString;
        }

        public bool InsertService(Service service)
        {
            bool status = false;
            try
            {
                using (var db = new SqlConnection(Conn))
                {
                    db.Open();
                    db.Execute(Service.INSERT, new
                    {
                        Desc = service.Description
                    });
                    db.Close();
                }
                status = true;
            }
            catch(Exception)
            {
                throw;
            }
            return status;
        }
    }
}