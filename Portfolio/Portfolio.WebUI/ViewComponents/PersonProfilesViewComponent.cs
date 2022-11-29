 using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Portfolio.Domain.Models.DataContext;
using Portfolio.WebUI.ViewComponents;
using Portfolio.WebUI.ViewModel;
using System.Linq;
using System.Threading.Tasks;

namespace Portfolio.WebUI.ViewComponents
{
    public class PersonProfilesViewComponent : ViewComponent
    {
        public readonly PortfolioDbContext db;

        public PersonProfilesViewComponent(PortfolioDbContext db)
        {
            this.db = db;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {

            var person =await db.People.FirstOrDefaultAsync();

            var profiles =await db.Profiles.ToListAsync();


            PersonProfilesViewModel vm = new();
            vm.Person = person;
            vm.Profiles = profiles;
            
            return View(vm);

        } 

      





    }

    }

