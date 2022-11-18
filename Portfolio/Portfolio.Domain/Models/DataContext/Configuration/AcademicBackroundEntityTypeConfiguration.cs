using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Portfolio.Domain.Models.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portfolio.Domain.AppCode.Infrastructure.Configuration
{
    public class AcademicBackroundEntityTypeConfiguration : IEntityTypeConfiguration <AcademicBackground>
    {
        public void Configure(EntityTypeBuilder<AcademicBackground> builder)
        {
            //AcademicBackround academic = new();
            //builder.HasData(academic);
            builder.Property(a => a.Date).IsRequired();
            builder.Property(a => a.WorkPlace).IsRequired();
            builder.Property(a => a.Description).IsRequired();
            builder.Property(a => a.Profession).IsRequired();
        }
    }
}
