using Microsoft.AspNetCore.Antiforgery;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using TechReviewzWebsite.Components;
using TechReviewzWebsite.Components.Account;
using TechReviewzWebsite.Data;
using TechReviewzWebsite.Domain;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContextFactory<TechReviewzWebsiteContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("TechReviewzWebsiteContext") ?? throw new InvalidOperationException("Connection string 'TechReviewzWebsiteContext' not found.")));

// Add localization services
builder.Services.AddLocalization(options => options.ResourcesPath = "Locales");

builder.Services.AddQuickGridEntityFrameworkAdapter();
builder.Services.AddDatabaseDeveloperPageExceptionFilter();

builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

builder.Services.AddCascadingAuthenticationState();
builder.Services.AddScoped<IdentityUserAccessor>();
builder.Services.AddScoped<IdentityRedirectManager>();
builder.Services.AddScoped<AuthenticationStateProvider, IdentityRevalidatingAuthenticationStateProvider>();

builder.Services.AddAuthentication(options =>
    {
        options.DefaultScheme = IdentityConstants.ApplicationScheme;
        options.DefaultSignInScheme = IdentityConstants.ExternalScheme;
    })
    .AddIdentityCookies();

builder.Services.AddIdentityCore<TechReviewzWebsiteUser>(options => options.SignIn.RequireConfirmedAccount = true)
    .AddRoles<IdentityRole>()
    .AddEntityFrameworkStores<TechReviewzWebsiteContext>()
    .AddSignInManager()
    .AddDefaultTokenProviders();

builder.Services.AddSingleton<IEmailSender<TechReviewzWebsiteUser>, IdentityNoOpEmailSender>();

builder.Services.AddAntiforgery(options =>
{
    options.HeaderName = "RequestVerificationToken";
});

builder.Services.AddAuthorization();

var app = builder.Build();

// Configure supported cultures based on your Locales folder
string[] supportedCultures = [
    "en-US", // English (United States)
    "en-GB", // English (United Kingdom)
    "ar",    // Arabic
    "ar-AE", // Arabic (United Arab Emirates)
    "ca",    // Catalan
    "cs",    // Czech
    "da",    // Danish
    "de",    // German
    "el-GR", // Greek (Greece)
    "es",    // Spanish
    "fa",    // Persian
    "fi",    // Finnish
    "fr",    // French
    "fr-CH", // French (Switzerland)
    "he",    // Hebrew
    "hi-IN", // Hindi (India)
    "hr",    // Croatian
    "hu",    // Hungarian
    "id",    // Indonesian
    "it",    // Italian
    "ja",    // Japanese
    "ko",    // Korean
    "ms",    // Malay
    "nb",    // Norwegian Bokmål
    "nl",    // Dutch
    "pl",    // Polish
    "pt",    // Portuguese
    "pt-BR", // Portuguese (Brazil)
    "ro",    // Romanian
    "ru",    // Russian
    "sk",    // Slovak
    "sv",    // Swedish
    "th",    // Thai
    "tr",    // Turkish
    "vi",    // Vietnamese
    "zh"     // Chinese
];

var localizationOptions = new RequestLocalizationOptions()
    .SetDefaultCulture(supportedCultures[0])
    .AddSupportedCultures(supportedCultures)
    .AddSupportedUICultures(supportedCultures);

app.UseRequestLocalization(localizationOptions);

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    app.UseHsts();
    app.UseMigrationsEndPoint();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseAuthentication();
app.UseAuthorization();
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.MapAdditionalIdentityEndpoints();

// Follow/Unfollow endpoints (keep existing)
app.MapPost("/api/follow", async (HttpContext http,
                                  IDbContextFactory<TechReviewzWebsiteContext> dbFactory,
                                  IdentityUserAccessor userAccessor) =>
{
    var dto = await http.Request.ReadFromJsonAsync<FollowRequest>();
    if (dto is null || string.IsNullOrWhiteSpace(dto.TargetUsername))
    {
        return Results.BadRequest(new { success = false, error = "Missing targetUsername" });
    }

    var user = await userAccessor.GetRequiredUserAsync(http);
    if (user is null || string.IsNullOrEmpty(user.UserName))
    {
        return Results.Unauthorized();
    }

    var currentUsername = user.UserName!;

    if (string.Equals(currentUsername, dto.TargetUsername, StringComparison.OrdinalIgnoreCase))
    {
        return Results.BadRequest(new { success = false, error = "Cannot follow yourself" });
    }

    using var ctx = dbFactory.CreateDbContext();

    var exists = await ctx.Connection
        .AnyAsync(c => c.Username == currentUsername && c.TargetUsername == dto.TargetUsername && c.Relation == "Follow");

    if (exists)
    {
        return Results.Ok(new { success = true, already = true });
    }

    ctx.Connection.Add(new Connection
    {
        Username = currentUsername,
        TargetUsername = dto.TargetUsername,
        Relation = "Follow",
        Status = "Accepted",
        ProfilePictureURL = null
    });

    await ctx.SaveChangesAsync();

    return Results.Ok(new { success = true });

}).RequireAuthorization();

app.MapPost("/api/unfollow", async (HttpContext http,
                                    IDbContextFactory<TechReviewzWebsiteContext> dbFactory,
                                    IdentityUserAccessor userAccessor) =>
{
    var dto = await http.Request.ReadFromJsonAsync<FollowRequest>();
    if (dto is null || string.IsNullOrWhiteSpace(dto.TargetUsername))
    {
        return Results.BadRequest(new { success = false, error = "Missing targetUsername" });
    }

    var user = await userAccessor.GetRequiredUserAsync(http);
    if (user is null || string.IsNullOrEmpty(user.UserName))
    {
        return Results.Unauthorized();
    }

    var currentUsername = user.UserName!;

    using var ctx = dbFactory.CreateDbContext();

    var followEntries = await ctx.Connection
        .Where(c => c.Username == currentUsername && c.TargetUsername == dto.TargetUsername && c.Relation == "Follow")
        .ToListAsync();

    if (!followEntries.Any())
    {
        return Results.Ok(new { success = true, already = true });
    }

    ctx.Connection.RemoveRange(followEntries);
    await ctx.SaveChangesAsync();

    return Results.Ok(new { success = true });

}).RequireAuthorization();

app.MapGet("/antiforgery/token", (HttpContext http, IAntiforgery antiforgery) =>
{
    var tokens = antiforgery.GetAndStoreTokens(http);
    return Results.Json(new { token = tokens.RequestToken });
});

app.Run();