namespace TechReviewzWebsite.Domain
{
    public class Connection : BaseDomainModel
    {
        // Owner of this connection (username)
        public string? Username { get; set; }

        // The target user this connection refers to (username)
        public string? TargetUsername { get; set; }

        // relationship type: currently only "Follow" is used
        public string? Relation { get; set; }

        // State for the relation (for follows use "Accepted")
        public string? Status { get; set; }

        public string? ProfilePictureURL { get; set; }

        // Keep existing UserId in case other logic depends on it
        public int UserId { get; set; }
    }
}
