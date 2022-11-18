using Portfolio.Domain.AppCode.Infrastructure;
using Portfolio.Domain.Models.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portfolio.Domain.Models
{
    public class Experience: AcademicBackground
    {  
        public string Img { get; set; }
        public int PersonId { get; set; }
        public Person Person { get; set; }

    }
}
