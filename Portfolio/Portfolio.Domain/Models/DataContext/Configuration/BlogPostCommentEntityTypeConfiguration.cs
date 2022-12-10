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
   public class BlogPostCommentEntityTypeConfiguration:IEntityTypeConfiguration<BlogPostComment>
    { 

        public void Configure (EntityTypeBuilder<BlogPostComment> builder)
        {
            builder.Property(bl => bl.Comment).IsRequired();

        }
    }
}
