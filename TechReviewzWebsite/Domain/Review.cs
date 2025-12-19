namespace TechReviewzWebsite.Domain
{
    public class Review : BaseDomainModel
    {
        public required string Title { get; set; }
        public required string Content { get; set; }
        public int Rating { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; }
        public int UserId { get; set; }
    }
}
