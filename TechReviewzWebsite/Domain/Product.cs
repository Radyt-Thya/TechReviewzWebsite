using Microsoft.Extensions.Primitives;

namespace TechReviewzWebsite.Domain
{
    public class Product : BaseDomainModel
    {
        public string? Name { get; set; }
        public string? Description { get; set; }
        public string? Specification { get; set; }
        public string? Category { get; set; }
        public string? Brand { get; set; }
        public float Price { get; set; }
        public string? ProductLink { get; set; }
        public DateTime DateReleased { get; set; }
        public DateTime DateUpdated { get; set; }
    }
}
