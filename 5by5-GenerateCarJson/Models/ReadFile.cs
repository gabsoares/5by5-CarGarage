using Newtonsoft.Json;

namespace Models
{
    public class ReadFile
    {
        public static List<Car> GetData()
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "\\Documents\\CarGarage\\";
            string file = "Cars.json";
            StreamReader sr = new(path + file);
            string jsonString = sr.ReadToEnd();

            var lst = JsonConvert.DeserializeObject<Cars>(jsonString);

            if (lst != null) return lst.carList;
            return null;
        }
    }
}
