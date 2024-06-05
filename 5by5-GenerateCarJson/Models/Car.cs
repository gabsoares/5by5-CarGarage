using Newtonsoft.Json;

namespace Models
{
    public class Car
    {
        public readonly static string INSERT = "INSERT INTO TB_CAR (CAR_PLATE, CAR_NAME, CAR_COLOR, MODEL_YEAR, FABRICATION_YEAR) VALUES (@Plate, @Name, @Color, @ModelYear, @FabricationYear)";

        public readonly static string SELECTRED = "SELECT * FROM TB_CAR WHERE CAR_COLOR = 'VERMELHO'";

        public readonly static string SELECTCARSBETWEEN20102011 = "SELECT CAR_PLATE, CAR_NAME, CAR_COLOR, MODEL_YEAR, FABRICATION_YEAR FROM TB_CAR WHERE FABRICATION_YEAR = 2010 OR FABRICATION_YEAR = 2011";

        public readonly static string SELECTCARSWITHTRUESERVICE = "SELECT C.CAR_PLATE, C.CAR_NAME, C.CAR_COLOR, C.MODEL_YEAR, C.FABRICATION_YEAR FROM TB_CAR_SERVICE CC JOIN TB_CAR C ON CC.CAR_ID = C.CAR_PLATE AND CC.STATUS_SERVICE = 1;";


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
