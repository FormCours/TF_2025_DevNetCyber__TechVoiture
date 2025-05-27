namespace TechVoiture.API.Dto.Output
{
    public class EngineOutputDTO
    {
        public int Id { get; set; }
        public required string Name { get; set; }
    }

    public class EngineDetailOutputDTO
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public string? Fuel { get; set; }
    }
}
