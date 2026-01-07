namespace TechReviewzWebsite.Services;

public class MailgunOptions
{
    public string ApiBaseUrl { get; set; } = "";
    public string Domain { get; set; } = "";
    public string ApiKey { get; set; } = "";
    public string From { get; set; } = "";
}
