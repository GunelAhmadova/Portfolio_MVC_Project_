using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portfolio.Domain.Models.DataContext.Configuration
{
    public class SkillEntityTypeConfiguration : IEntityTypeConfiguration<Skill>
    {
        public void Configure(EntityTypeBuilder<Skill> builder)
        {
            builder.Property(s => s.SkillName).IsRequired().HasMaxLength(64);
            builder.Property(x => x.Rate);

            builder.Property(s => s.Description).IsRequired().HasMaxLength(512);
        }
    }
}
