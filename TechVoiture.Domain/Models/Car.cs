namespace TechVoiture.Domain.Models
{
    public class Car
    {
        public int Id { get; set; }
        public required string Brand { get; set; }
        public required string Model { get; set; }
        public required double Price { get; set; }
        public required double Kilometers { get; set; }
        public required bool IsDamaged { get; set; }
        public string? Description { get; set; }
        public required Engine Engine { get; set; }

    }
}