using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portfolio.Domain.Models.DataContext.Configuration
{
    internal class ProfileEntityTypeConfiguration : IEntityTypeConfiguration<Social>
    {
        public void Configure(EntityTypeBuilder<Social> builder)
        {
            builder.Property(pf => pf.ProfileName).IsRequired().HasMaxLength(64);
            builder.Property(pf => pf.Url);


        }
    }
}
