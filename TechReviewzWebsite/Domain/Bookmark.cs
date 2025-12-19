namespace TechReviewzWebsite.Domain
{
    public class Bookmark : BaseDomainModel
    {
        public required string Title { get; set; }
        public required string Rating { get; set; }
        public required string DateCreated { get; set; }
        public required string DateUpdated { get; set; }
        public int UserId { get; set; }
        public int ReviewId { get; set; }
    }
}
