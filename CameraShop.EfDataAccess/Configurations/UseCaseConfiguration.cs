using CameraShop.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CameraShop.EfDataAccess.Configurations
{
    public class UseCaseConfiguration : IEntityTypeConfiguration<UseCase>
    {
        public void Configure(EntityTypeBuilder<UseCase> builder)
        {
            builder.Property(uc => uc.Name)
                .IsRequired()
                .HasMaxLength(100);

            builder.HasIndex(uc => uc.Name)
                .IsUnique();

            builder.HasMany(uc => uc.UserUseCases)
                .WithOne(uuc => uuc.UseCase)
                .HasForeignKey(uuc => uuc.UseCaseId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
