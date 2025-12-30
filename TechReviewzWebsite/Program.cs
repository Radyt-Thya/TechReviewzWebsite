using TechReviewzWebsite.Components;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using TechReviewzWebsite.Data;
using Microsoft.AspNetCore.Components.Authorization;
using TechReviewzWebsite.Components.Account;
using TechReviewzWebsite.Domain;
using System.Text.Json.Serialization;
using Microsoft.AspNetCore.Antiforgery;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContextFactory<TechReviewzWebsiteContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("TechReviewzWebsiteContext") ?? throw new InvalidOperationException("Connection string 'TechReviewzWebsiteContext' not found.")));

builder.Services.AddQuickGridEntityFrameworkAdapter();

builder.Services.AddDatabaseDeveloperPageExceptionFilter();

// Add services to the container.
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

// Register antiforgery and set HeaderName to match the header your JS includes.
builder.Services.AddAntiforgery(options =>
{
    // JS includes header "RequestVerificationToken" — keep this name or change JS accordingly
    options.HeaderName = "RequestVerificationToken";
});

builder.Services.AddAuthorization();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
    app.UseMigrationsEndPoint();
}

app.UseHttpsRedirection();

app.UseStaticFiles();

// IMPORTANT: register the auth middlewares so endpoint metadata like RequireAuthorization() works
app.UseAuthentication();
app.UseAuthorization();

// Antiforgery middleware must be registered after authentication/authorization and before endpoint routing.
// This satisfies endpoints that carry antiforgery metadata (Razor Components root, forms, etc.)
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.MapAdditionalIdentityEndpoints();

// Minimal API to handle follow actions from client-side JS.
// This avoids depending on the Blazor circuit for the Follow button.
app.MapPost("/api/follow", async (HttpContext http,
                                  IDbContextFactory<TechReviewzWebsiteContext> dbFactory,
                                  IdentityUserAccessor userAccessor) =>
{
    // simple DTO for request body
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

    // prevent following self
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

// Minimal API to handle unfollow actions from client-side JS.
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

    // find follow connections that represent "current user follows target"
    var followEntries = await ctx.Connection
        .Where(c => c.Username == currentUsername && c.TargetUsername == dto.TargetUsername && c.Relation == "Follow")
        .ToListAsync();

    if (!followEntries.Any())
    {
        // nothing to remove
        return Results.Ok(new { success = true, already = true });
    }

    ctx.Connection.RemoveRange(followEntries);
    await ctx.SaveChangesAsync();

    return Results.Ok(new { success = true });

}).RequireAuthorization();

// add the minimal endpoint to return a fresh antiforgery request token and set cookie
app.MapGet("/antiforgery/token", (HttpContext http, IAntiforgery antiforgery) =>
{
    var tokens = antiforgery.GetAndStoreTokens(http);
    return Results.Json(new { token = tokens.RequestToken });
});

app.Run();