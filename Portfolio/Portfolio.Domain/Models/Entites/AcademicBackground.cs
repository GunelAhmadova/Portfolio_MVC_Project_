using Portfolio.Domain.AppCode.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portfolio.Domain.Models.Entites
{
    public class AcademicBackground: BaseEntity
    {

        public string Date { get; set; }
        public string WorkPlace { get; set; }
        public string Description { get; set; }
        public string Profession { get; set; }

    }
}
