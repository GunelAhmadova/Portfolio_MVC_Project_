using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Portfolio.Domain.Models;
using Portfolio.Domain.Models.Entites;
using System;

namespace BigOn.Domain.Models.DataContexts.Configurations
{
    public class BlogPostEntityTypeConfiguration : IEntityTypeConfiguration<BlogPost>
    {
        public void Configure(EntityTypeBuilder<BlogPost> builder)
        {
            builder.Property(t => t.Title)
                .IsRequired();

            builder.Property(t => t.Slug)
                .IsRequired();

            builder.HasIndex(t => t.Slug)
                .IsUnique();

            builder.Property(t => t.Body)
                .IsRequired();

            builder.Property(t => t.ImagePath)
                .IsRequired();

            builder.Ignore(x => x.ImageFile);

        }
    }
}
