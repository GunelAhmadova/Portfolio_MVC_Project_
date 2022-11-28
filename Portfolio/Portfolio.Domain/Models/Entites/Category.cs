using Portfolio.Domain.AppCode.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portfolio.Domain.Models.Entites
{
   public class Category:BaseEntity
    {
        public string Name { get; set; }

        public ICollection<Portfolia> Portfolias { get; set; } 
    }
}
