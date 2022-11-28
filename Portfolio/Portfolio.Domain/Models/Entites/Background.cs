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
  public  class Background:BaseEntity
    {
        public string DateRange { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public string Location { get; set; }
        public string BackgroundType { get; set; }
        public string BackgroundLevel { get; set; }

        [NotMapped]
        public IFormFile ImageFile { get; set; }


    }
}
