namespace TechReviewzWebsite.Domain
{
    public class Comments : BaseDomainModel
    {

        public string Content { get; set; } = string.Empty;
        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; }
        public string? UserId { get; set; }
        public int ReviewId { get; set; }
    }
}
