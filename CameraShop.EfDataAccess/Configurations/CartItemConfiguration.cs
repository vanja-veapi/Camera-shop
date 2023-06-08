using CameraShop.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CameraShop.EfDataAccess.Configurations
{
    public class CartItemConfiguration : IEntityTypeConfiguration<CartItem>
    {
        public void Configure(EntityTypeBuilder<CartItem> builder)
        {
            builder.HasKey(x => new { x.CartId, x.CameraId });
            builder.Property(x => x.Quantity)
                .IsRequired();

            builder.HasOne(x => x.Camera)
                .WithMany(c => c.CartItems)
                .HasForeignKey(x => x.CameraId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(x => x.Cart)
                .WithMany(c => c.CartItems)
                .HasForeignKey(x => x.CartId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
