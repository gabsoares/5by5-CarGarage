using Newtonsoft.Json;

namespace Models
{
    public class Car
    {
        public readonly static string INSERT = "INSERT INTO TB_CAR (CAR_PLATE, CAR_NAME, CAR_COLOR, MODEL_YEAR, FABRICATION_YEAR) VALUES (@Plate, @Name, @Color, @ModelYear, @FabricationYear)";

        [JsonProperty("car_plate")]
        public string? CarPlate { get; set; }

        [JsonProperty("car_name")]
        public string? CarName { get; set; }

        [JsonProperty("modelYear")]
        public int ModelYear { get; set; }

        [JsonProperty("fabrication_year")]
        public int FabricationYear { get; set; }

        [JsonProperty("car_color")]
        public string? CarColor { get; set; }

        public override string ToString() => $"{CarPlate}.{CarName}.{CarColor}.{ModelYear}.{FabricationYear}";
    }
}
