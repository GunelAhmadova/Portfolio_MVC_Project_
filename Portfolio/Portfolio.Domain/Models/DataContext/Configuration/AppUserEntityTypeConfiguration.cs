using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Portfolio.Domain.Models.Entites.Identity;

namespace Portfolio.Domain.Models.DataContext.Configurations
{
    public class AppUserEntityTypeConfiguration : IEntityTypeConfiguration<AppUser>
    {
        public void Configure(EntityTypeBuilder<AppUser> builder)
        {
            //builder.Property(m => m.Name)
            //    .IsRequired();

            //builder.Property(m => m.Surname)
            //    .IsRequired();

            builder.ToTable("Users","Membership");
        }
    }
}
