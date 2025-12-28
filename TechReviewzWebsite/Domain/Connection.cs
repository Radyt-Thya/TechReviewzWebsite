namespace TechReviewzWebsite.Domain
{
    public class Connection : BaseDomainModel
    {
        // who owns this connection (your username or domain user id if you prefer)
        public string? Username { get; set; }

        // the target user this connection refers to
        public string? TargetUsername { get; set; }

        // relationship type: "Follow" or "Friend"
        public string? Relation { get; set; }

        // Friend request state: "Pending", "Accepted", "Rejected" (for follows you can set "Accepted" immediately)
        public string? Status { get; set; }

        public string? ProfilePictureURL { get; set; }

        // keep existing UserId if other logic depends on it (optional)
        public int UserId { get; set; }
    }
}
