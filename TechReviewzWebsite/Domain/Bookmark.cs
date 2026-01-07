namespace TechReviewzWebsite.Domain
{
    public class Bookmark : BaseDomainModel
    {
        public string? Title { get; set; }
        public string? Rating { get; set; }
        public string? DateCreated { get; set; }
        public string? DateUpdated { get; set; }
        public string? UserId { get; set; }
        public int ReviewId { get; set; }
    }
}
