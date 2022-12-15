using Portfolio.Domain.AppCode.Infrastructure;
using Portfolio.Domain.Models.Entites.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portfolio.Domain.Models.Entites
{ 
   public class BlogPostComment:BaseEntity
    {
        public string Comment { get; set; }
        public int AppUserId { get; set; }
        public AppUser AppUser { get; set; }

        public int BlogPostId { get; set; }
        public BlogPost BlogPost { get; set; }
    }
}
