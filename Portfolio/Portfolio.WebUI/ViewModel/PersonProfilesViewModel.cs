using Portfolio.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portfolio.WebUI.ViewModel
{
    public class PersonProfilesViewModel
    {
        public Person Person { get; set; }
        public ICollection<Social> Profiles { get; set; }
    }

    
}
