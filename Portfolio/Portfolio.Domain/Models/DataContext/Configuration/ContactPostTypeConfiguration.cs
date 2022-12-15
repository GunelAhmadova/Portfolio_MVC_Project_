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
    public class ContactPostTypeConfiguration : IEntityTypeConfiguration<ContactPost>
    {
        public void Configure(EntityTypeBuilder<ContactPost> builder)
        {

            builder.Property(t => t.Name)
                .IsRequired();

            builder.Property(t => t.Email)
                .IsRequired();

            builder.Property(t => t.Subject)
                .IsRequired();

            builder.Property(t => t.Message)
                .IsRequired();
        }
    }
}
