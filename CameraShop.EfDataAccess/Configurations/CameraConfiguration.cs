using CameraShop.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CameraShop.EfDataAccess.Configurations
{
    public class CameraConfiguration : EntityConfiguration<Camera>
    {
        protected override void ConfigureRules(EntityTypeBuilder<Camera> builder)
        {
            builder.Property(x => x.ProductName)
               .IsRequired()
               .HasMaxLength(200);

            builder.Property(x => x.ProductDescription)
                .IsRequired(false);

            builder.Property(x => x.IsOnDiscount)
                .IsRequired();

            builder.Property(x => x.Megapixels)
                .IsRequired();

            builder.Property(x => x.ISO)
                .IsRequired();

            builder.Property(x => x.VideoResolution)
                .IsRequired();

            builder.Property(x => x.WifiSupport)
                .IsRequired();

            builder.Property(x => x.BluetoothSupport)
                .IsRequired();

            builder.Property(x => x.LensMount)
                .IsRequired();

            builder.Property(x => x.Price)
                .IsRequired();

            builder.HasIndex(x => x.BluetoothSupport).HasDatabaseName("IX_Camera_BluetoothSupport");
            builder.HasIndex(x => x.WifiSupport).HasDatabaseName("IX_Camera_WifiSupport");
            builder.HasIndex(x => x.LensMount).HasDatabaseName("IX_Camera_LensMount");
            builder.HasIndex(x => x.BrandId).HasDatabaseName("IX_Camera_BrandId");

            builder.HasOne(x => x.Brand)
                .WithMany(b => b.Cameras)
                .HasForeignKey(x => x.BrandId);

            builder.HasOne(x => x.SensorType)
                .WithMany(s => s.Cameras)
                .HasForeignKey(x => x.SensorTypeId);

            builder.HasMany(c => c.CameraImages)
                .WithOne(ci => ci.Camera)
                .HasForeignKey(ci => ci.CameraId);

            builder.HasMany(c => c.CartItems)
                .WithOne(ci => ci.Camera)
                .HasForeignKey(ci => ci.CameraId);

            builder.HasMany(c => c.OrderItems)
                .WithOne(oi => oi.Camera)
                .HasForeignKey(oi => oi.CameraId);

        }
    }
}
