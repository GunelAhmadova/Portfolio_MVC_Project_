using Portfolio.Domain.AppCode.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portfolio.Domain.Models
{
    public class Social: BaseEntity
    { 
        public string ProfileName { get; set; }
        public string Url { get; set; }

        public int PersonId { get; set; } 

        public virtual Person Person { get; set; }
    }
}
