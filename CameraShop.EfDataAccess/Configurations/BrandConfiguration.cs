using CameraShop.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CameraShop.EfDataAccess.Configurations
{
    public class BrandConfiguration : EntityConfiguration<Brand>
    {
        protected override void ConfigureRules(EntityTypeBuilder<Brand> builder)
        {
            builder.Property(x => x.BrandName)
                .IsRequired()
                .HasMaxLength(100);

            builder.HasIndex(x => x.BrandName)
                .IsUnique()
                .HasDatabaseName("IX_Brand_BrandName");
        }
    }
}
