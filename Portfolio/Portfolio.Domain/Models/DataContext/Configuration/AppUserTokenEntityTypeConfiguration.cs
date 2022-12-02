using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Portfolio.Domain.Models.Entites.Identity;

namespace Portfolio.Domain.Models.DataContext.Configurations
{
    public class AppUserTokenEntityTypeConfiguration : IEntityTypeConfiguration<AppUserToken>
    {
        public void Configure(EntityTypeBuilder<AppUserToken> builder)
        {
            builder.ToTable("UserTokens", "Membership");
        }
    }
}
