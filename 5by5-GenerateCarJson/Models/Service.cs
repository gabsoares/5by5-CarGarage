namespace Models
{
    public class Service
    {
        public readonly static string INSERT = "INSERT INTO TB_SERVICE (DESCRIPTION_SERVICE) VALUES (@Desc)";

        public int Id { get; set; }
        public string Description { get; set; }
    }
}