using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace Portfolio.Domain.Models.Entites.Identity
{
    public  class AppUser : IdentityUser<int>
    {
        public string Name { get; set; }
        public string Surname { get; set; }

    }
}
