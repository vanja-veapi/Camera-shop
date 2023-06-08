using CameraShop.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CameraShop.EfDataAccess.Configurations
{
    public class UserUseCaseConfiguration : IEntityTypeConfiguration<UserUseCase>
    {
        public void Configure(EntityTypeBuilder<UserUseCase> builder)
        {
            builder.HasKey(uuc => new { uuc.UserId, uuc.UseCaseId });

            builder.HasOne(uuc => uuc.User)
                .WithMany(u => u.UserUseCases)
                .HasForeignKey(uuc => uuc.UserId);

            builder.HasOne(uuc => uuc.UseCase)
                .WithMany(uc => uc.UserUseCases)
                .HasForeignKey(uuc => uuc.UseCaseId);
        }
    }
}
