using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TechReviewzWebsite.Domain;

namespace TechReviewzWebsite.Configurations.Entities
{
    public class ReviewSeed : IEntityTypeConfiguration<Review>
    {
        public void Configure(EntityTypeBuilder<Review> builder)
        {
            builder.HasData(
                new Review
                {
                    Id = 1,
                    Title = "samsung review",
                    Content = "Amazing phone with great features!",
                    Rating = 5,
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    ProductId = 1 
                },
                new Review
                {
                    Id = 2,
                    Title = "Iphone review",
                    Content = "battery life could be better.",
                    Rating = 4,
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    ProductId = 0
                }
            );
        }
    }
}
