using Microsoft.AspNetCore.Http;
using Portfolio.Domain.AppCode.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portfolio.Domain.Models.Entites
{
    public class BlogPost: BaseEntity
    {
        public string Title { get; set; }
        public string Slug { get; set; }
        public string Body { get; set; }
        public string ImagePath { get; set; }
        
        public DateTime? PublishDate { get; set; } 

        public IFormFile  ImageFile { get; set; }
    }
}
