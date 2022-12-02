using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Portfolio.Domain.Models.Entites.Identity;

namespace Portfolio.Domain.Models.DataContext.Configurations
{
    public class AppUserLoginEntityTypeConfiguration : IEntityTypeConfiguration<AppUserLogin>
    {
        public void Configure(EntityTypeBuilder<AppUserLogin> builder)
        {
            builder.ToTable("UserLogins", "Membership");
        }
    }
}
