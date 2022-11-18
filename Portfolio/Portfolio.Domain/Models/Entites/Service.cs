using Portfolio.Domain.AppCode.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portfolio.Domain.Models
{
    public class Service: BaseEntity
    { 
        public string Title { get; set; } 
        public string Description { get; set; }
    }
}
