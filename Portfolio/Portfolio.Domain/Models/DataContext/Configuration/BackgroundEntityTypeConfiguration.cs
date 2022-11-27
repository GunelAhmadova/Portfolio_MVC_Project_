using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Portfolio.Domain.Models.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portfolio.Domain.Models.DataContext.Configuration
{
    public class BackgroundEntityTypeConfiguration : IEntityTypeConfiguration<Background>
    {
        public void Configure(EntityTypeBuilder<Background> builder)
        {
            builder.Property(pf => pf.Title).IsRequired().HasMaxLength(64);
            builder.Property(pf => pf.Location).IsRequired().HasMaxLength(64);
            builder.Property(pf => pf.DateRange).IsRequired().HasMaxLength(64);
            builder.Property(pf => pf.ImageUrl).IsRequired();
            builder.Property(pf => pf.Description).IsRequired().HasMaxLength(512);
            builder.Property(pf => pf.BackgroundType).IsRequired();


        }
    }
}
