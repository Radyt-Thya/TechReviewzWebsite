namespace TechReviewzWebsite.Domain
{
    public class Comment : BaseDomainModel
    {
        public required string Content { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; }
        public int UserId { get; set; }
        public int ReviewId { get; set; }
    }
}
