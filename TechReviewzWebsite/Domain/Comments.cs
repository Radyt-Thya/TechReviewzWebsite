namespace TechReviewzWebsite.Domain
{
    public class Comments : BaseDomainModel
    {
        public string? Content { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; }
        public int UserId { get; set; }
        public int ReviewId { get; set; }
    }
}
