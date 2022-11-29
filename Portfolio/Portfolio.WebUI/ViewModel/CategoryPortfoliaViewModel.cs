using Portfolio.Domain.Models.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Portfolio.WebUI.ViewModel
{
    public class CategoryPortfoliaViewModel
    {

        public ICollection<Category> Categories { get; set; }
        public ICollection<Portfolia> Portfolias { get; set; }
    }
}
