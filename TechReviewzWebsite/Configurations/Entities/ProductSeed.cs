using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TechReviewzWebsite.Domain;

namespace TechReviewzWebsite.Configurations.Entities
{
    public class ProductSeed : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasData(
                new Product
                {
                    Id = 1,
                    Name = "iPhone 13",
                    Brand = "Apple",
                    Description = "Latest Apple smartphone with A15 Bionic chip",
                    Price = 999,
                    DateCreated = DateTime.Now
                },
                new Product
                {
                    Id = 2,
                    Name = "Samsung Galaxy S21",
                    Brand = "Samsung",
                    Description = "Flagship Samsung phone with excellent camera",
                    Price = 799,
                    DateCreated = DateTime.Now
                }
            );
        }
    }
}
