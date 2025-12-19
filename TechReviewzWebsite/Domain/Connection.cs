namespace TechReviewzWebsite.Domain
{
    public class Connection : BaseDomainModel
    {
        public required string Username { get; set; }
        public string? ProfilePictureUrl { get; set; }
        public int UserId { get; set; }
    }
}
