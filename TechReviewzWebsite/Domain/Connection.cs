namespace TechReviewzWebsite.Domain
{
    public class Connection : BaseDomainModel
    {
        public string? Username { get; set; }
        public string? Type { get; set; }
        public string? ProfilePictureURL { get; set; }
        public int UserId { get; set; }
    }
}
