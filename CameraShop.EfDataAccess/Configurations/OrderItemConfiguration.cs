using CameraShop.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CameraShop.EfDataAccess.Configurations
{
    public class OrderItemConfiguration : IEntityTypeConfiguration<OrderItem>
    {
        public void Configure(EntityTypeBuilder<OrderItem> builder)
        {
            builder.HasKey(x => new { x.OrderId, x.CameraId });
            builder.Property(oi => oi.Quantity)
                .IsRequired();

            builder.Property(oi => oi.ProductName)
                .IsRequired()
                .HasMaxLength(100);

            builder.Property(oi => oi.Price)
                .IsRequired()
                .HasColumnType("decimal(18,2)");

            builder.HasOne(oi => oi.Order)
                .WithMany(o => o.OrderItems)
                .HasForeignKey(oi => oi.OrderId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(oi => oi.Camera)
                .WithMany(c => c.OrderItems)
                .HasForeignKey(oi => oi.CameraId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
