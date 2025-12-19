namespace TechReviewzWebsite.Domain
{
    public class Product : BaseDomainModel
    {
        public required string Name { get; set; }
        public required string Description { get; set; }
        public required string Category { get; set; }
        public required string Brand { get; set; }
        public required decimal Price { get; set; }
        public DateTime DateCreated { get; set; }
        public string? ImageUrl { get; set; }
        public int ReviewId { get; set; }
    }
}
