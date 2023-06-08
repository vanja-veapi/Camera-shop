using CameraShop.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CameraShop.EfDataAccess.Configurations
{
    public class UseCaseLogConfiguration : IEntityTypeConfiguration<UseCaseLog>
    {
        public void Configure(EntityTypeBuilder<UseCaseLog> builder)
        {
            builder.Property(ucl => ucl.UseCaseName)
                .IsRequired()
                .HasMaxLength(100);

            builder.Property(ucl => ucl.User)
                .IsRequired()
                .HasMaxLength(100);
        }
    }
}
