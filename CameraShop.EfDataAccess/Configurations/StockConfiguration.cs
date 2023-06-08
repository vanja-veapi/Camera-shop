using CameraShop.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CameraShop.EfDataAccess.Configurations
{
    public class StockConfiguration : EntityConfiguration<Stock>
    {
        protected override void ConfigureRules(EntityTypeBuilder<Stock> builder)
        {
            builder.HasOne(s => s.Camera)
                .WithOne(c => c.Stock)
                .HasForeignKey<Stock>(s => s.CameraId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
