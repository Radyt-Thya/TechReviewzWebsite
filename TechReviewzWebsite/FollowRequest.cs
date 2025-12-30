using System.Text.Json.Serialization;

namespace TechReviewzWebsite.Components;

public sealed record FollowRequest([property: JsonPropertyName("targetUsername")] string TargetUsername);

// small record used only for JSON deserialization (declare before MapPost)
internal sealed record UnfollowRequest([property: JsonPropertyName("targetUsername")] string TargetUsername);