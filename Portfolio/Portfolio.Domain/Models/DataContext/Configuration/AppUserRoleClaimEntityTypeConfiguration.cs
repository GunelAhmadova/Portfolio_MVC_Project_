using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

using Portfolio.Domain.Models.Entites.Identity;

namespace Portfolio.Domain.Models.DataContext.Configurations
{
    public class AppUserRoleClaimEntityTypeConfiguration : IEntityTypeConfiguration<AppUserRole>
    {
        public void Configure(EntityTypeBuilder<AppUserRole> builder)
        {
            //composite primary key
            builder.HasKey(m => new
            {
                m.UserId,
                m.RoleId
            });

            builder.ToTable("UserRoles", "Membership");
        }
    }
}
