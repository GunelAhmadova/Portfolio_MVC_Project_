using Microsoft.EntityFrameworkCore;
using Portfolio.Domain.Models.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portfolio.Domain.Models.DataContext.Configuration
{
    public class PortfoliaEntityTypeConfiguration : IEntityTypeConfiguration<Portfolia>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Portfolia> builder)
        {

            builder.Property(pr=>pr.Title).IsRequired().HasMaxLength(64);
            builder.Property(pr => pr.ImageUrl).IsRequired();

            builder.Property(pr => pr.CategoryId).IsRequired();
        }
    }
}
