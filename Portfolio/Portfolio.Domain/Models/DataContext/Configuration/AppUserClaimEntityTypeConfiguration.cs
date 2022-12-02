using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Portfolio.Domain.Models.Entites.Identity;

namespace Portfolio.Domain.Models.DataContext.Configurations
{
    public class AppUserClaimEntityTypeConfiguration : IEntityTypeConfiguration<AppUserClaim>
    {
        public void Configure(EntityTypeBuilder<AppUserClaim> builder)
        {
            builder.ToTable("UserClaims", "Membership");
        }
    }
}
