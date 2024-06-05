using Repositories;
using System.Xml.Linq;

namespace Services
{
    public class CarQueryService
    {
        private CarQueryRepository _carQueryRepository;

        public CarQueryService()
        {
            _carQueryRepository = new CarQueryRepository();
        }

        public List<String> GetCar(string query)
        {
            return _carQueryRepository.GetCar(query);
        }

        public bool GenerateXML(List<String> dataXML, int opt)
        {
            bool result = false;
            if (dataXML.Count > 0)
            {
                XElement root = new("Root");
                foreach (var item in dataXML)
                {
                    string[] fields = item.Split('.');

                    var cars = new XElement("car",
                                            new XElement("car_plate", fields[0]),
                                            new XElement("car_name", fields[1]),
                                            new XElement("car_color", fields[2]),
                                            new XElement("modelYear", fields[3]),
                                            new XElement("fabrication_year", fields[4]));
                    root.Add(cars);
                }
                try
                {
                    string path = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "\\Documents\\CarGarageXML\\";
                    string file = opt == 1 ? "CarsWithTrueService.xml" : opt == 2 ? "CarsBuildedIn20102011.xml" : "CarsWithColorRed.xml"; ;

                    CreateFileAndDir(path, file);

                    using (StreamWriter sw = new StreamWriter(path + file))
                    {
                        sw.Write(root);
                        result = true;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Erro ao gravar o arquivo XML: {ex.Message}");
                }
            }
            else
            {
                Console.WriteLine("Lista vazia.");
            }
            return result;
        }

        public void CreateFileAndDir(string path, string file)
        {
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
            if (!File.Exists(file))
            {
                File.Create(file).Close();
            }
        }
    }
}
