using Portfolio.Domain.AppCode.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portfolio.Domain.Models
{
    public class  Person: BaseEntity
    {
        public string Name { get; set; } 
        public int Age { get; set; }
        public int? Fax { get; set; }
        public string Phone { get; set; }
        public string Location { get; set; }
        public string Degree { get; set; }
        public string CareerLevel { get; set; }
        public string Email { get; set; }
        public string Website { get; set; }


        public virtual ICollection<Profile> Profiles { get; set; }
        public ICollection<Experience> Experiences { get; set; } 
         

         






    }
}
