using CameraShop.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CameraShop.EfDataAccess.Configurations
{
    public class CartConfiguration : EntityConfiguration<Cart>
    {
        protected override void ConfigureRules(EntityTypeBuilder<Cart> builder)
        {
            builder.HasOne(x => x.User)
                .WithOne()
                .HasForeignKey<Cart>(x => x.UserId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
