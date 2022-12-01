using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace Portfolio.Domain.Models.Entites.Identity
{
    public  class AppUser : IdentityUser
    {
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [DataType(DataType.Password),Compare(nameof(Password))]
        public string ConfirmPassword { get; set; }
    }
}
