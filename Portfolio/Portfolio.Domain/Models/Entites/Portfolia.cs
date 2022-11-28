using Microsoft.AspNetCore.Http;
using Portfolio.Domain.AppCode.Infrastructure;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portfolio.Domain.Models.Entites
{
   public class Portfolia: BaseEntity   
    {
        public string Title { get; set; }
        public string ImageUrl { get; set; } 

        public string ProjectLink { get; set; }

        public int CategoryId { get; set; }
        public Category Category { get; set; }

        [NotMapped]
        public IFormFile ImageFile { get; set; }

    }
}
