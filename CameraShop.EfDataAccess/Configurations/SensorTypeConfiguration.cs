using CameraShop.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CameraShop.EfDataAccess.Configurations
{
    public class SensorTypeConfiguration : EntityConfiguration<SensorType>
    {

        protected override void ConfigureRules(EntityTypeBuilder<SensorType> builder)
        {
            builder.Property(st => st.Type)
                .IsRequired()
                .HasMaxLength(50);

            builder.HasIndex(st => st.Type)
                .IsUnique();

            builder.HasMany(st => st.Cameras)
                .WithOne(c => c.SensorType)
                .HasForeignKey(c => c.SensorTypeId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
