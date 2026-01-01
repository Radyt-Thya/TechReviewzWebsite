using System.ComponentModel.DataAnnotations.Schema;

namespace TechReviewzWebsite.Domain
{
    public class Review : BaseDomainModel
    {
        public string? Title { get; set; }
        public string? Content { get; set; }
        public string? Category { get; set; }
        public int Rating { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; }
        public string? UserId { get; set; }
        public int ProductId { get; set; }
    }
}
