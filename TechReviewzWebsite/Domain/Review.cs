namespace TechReviewzWebsite.Domain
{
    public class Review : BaseDomainModel
    {
        public string? Title { get; set; }
        public string? Content { get; set; }
        public int Rating { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; }
        public int UserId { get; set; }

        // NEW: associate this review with a Product
        public int ProductId { get; set; }
    }
}
