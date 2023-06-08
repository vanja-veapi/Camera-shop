using CameraShop.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CameraShop.EfDataAccess.Configurations
{
    public class DiscountConfiguration : EntityConfiguration<Discount>
    {
        protected override void ConfigureRules(EntityTypeBuilder<Discount> builder)
        {
            builder.Property(x => x.DiscountPercentage)
                .IsRequired();

            builder.Property(x => x.StartDate)
                .IsRequired();

            builder.HasOne(x => x.Camera)
                .WithMany(c => c.Discounts)
                .HasForeignKey(x => x.CameraId)
                .OnDelete(DeleteBehavior.Restrict)
                .IsRequired(false);

            builder.HasOne(x => x.Brand)
                .WithMany(b => b.Discounts)
                .HasForeignKey(x => x.BrandId)
                .OnDelete(DeleteBehavior.Restrict)
                .IsRequired(false);
        }
    }
}
