using Newtonsoft.Json;

namespace Models
{
    public class Cars
    {
        [JsonProperty("car")]
        public List<Car>? carList { get; set; }
    }
}
