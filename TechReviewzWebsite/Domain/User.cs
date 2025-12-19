namespace TechReviewzWebsite.Domain
{
    public class User : BaseDomainModel
    {
        public string? Username { get; set; }
        public required string Email { get; set; }
        public required string PasswordHash { get; set; }

        public required string Role { get; set; } = "User";
        public string? Gender { get; set; }
        public string? ProfilePictureUrl { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; }
    }
}
