using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TechReviewzWebsite.Configurations.Entities;
using TechReviewzWebsite.Domain;

namespace TechReviewzWebsite.Data
{
    public class TechReviewzWebsiteContext(DbContextOptions<TechReviewzWebsiteContext> options) : IdentityDbContext<TechReviewzWebsiteUser>(options)
    {

    public DbSet<TechReviewzWebsite.Domain.Connection> Connection { get; set; } = default!;
    public DbSet<TechReviewzWebsite.Domain.Bookmark> Bookmark { get; set; } = default!;
    public DbSet<TechReviewzWebsite.Domain.Comments> Comments { get; set; } = default!;
    public DbSet<TechReviewzWebsite.Domain.Product> Product { get; set; } = default!;
    public DbSet<TechReviewzWebsite.Domain.Review> Review { get; set; } = default!;

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.ApplyConfiguration(new ReviewSeed());

            builder.ApplyConfiguration(new ProductSeed());

            builder.ApplyConfiguration(new UserSeed());

            builder.ApplyConfiguration(new RoleSeed());

            builder.ApplyConfiguration(new UserRoleSeed());
        }
    }
}