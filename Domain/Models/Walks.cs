namespace NZ_API.Domain.Models
{
    public class Walks
    {
        public Guid id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double LengthInKm { get; set; }
        public string? WalkImageUrl { get; set; }
        public Guid RegionId { get; set; }
        public Guid DifficultyId { get; set; }

        
        public Regions Regions { get; set; }    
        public Difficulty Difficulty { get; set; }
    }
}
