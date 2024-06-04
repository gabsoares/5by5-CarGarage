namespace Models
{
    public class CarServiceModel
    {
        public readonly static string INSERT = "INSERT INTO TB_CAR_SERVICE (CAR_ID, SERVICE_ID, STATUS_SERVICE) VALUES (@CarId, @ServiceId, @StatusService)";
        public int Id { get; set; }
        public Car? Car { get; set; }
        public Service? Service { get; set; }
        public bool Status { get; set; }
    }
}