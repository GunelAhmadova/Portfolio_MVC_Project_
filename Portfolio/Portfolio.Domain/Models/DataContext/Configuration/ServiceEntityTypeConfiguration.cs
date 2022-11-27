using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portfolio.Domain.Models.DataContext.Configuration
{
    public class ServiceEntityTypeConfiguration : IEntityTypeConfiguration<Service>
    {
        public void Configure(EntityTypeBuilder<Service> builder)
        {
            builder.Property(s => s.Title).IsRequired().HasMaxLength(64);
            builder.Property(x => x.CreatedDate).HasDefaultValue(DateTime.UtcNow);

            builder.Property(s => s.Description).HasMaxLength(512);
        }
    }
}
