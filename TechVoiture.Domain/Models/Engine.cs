namespace TechVoiture.Domain.Models
{
    public  class Engine
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public string? Fuel { get; set; }
    }
}
