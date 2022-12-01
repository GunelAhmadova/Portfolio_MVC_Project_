using MediatR;
using Microsoft.AspNetCore.Mvc;
using Portfolio.Domain.AppCode.Bussines.AccountModule;
using Portfolio.Domain.DTOs;
using Portfolio.Domain.Models.Entites.Identity;
using System.Threading.Tasks;

namespace Portfolio.WebUI.Controllers
{
    public class AccountController : Controller
    {
        private readonly IMediator mediator;

        public AccountController(IMediator mediator)
        {
            this.mediator = mediator;
        }

        public IActionResult Register()
        {
            return View();
        }
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public async  Task<IActionResult> Register(AppUser user)
        {
            if (!ModelState.IsValid)
            {
                return View(user);
            }
            RegisterCommand command = new();

            var response = await mediator.Send(command);

            return Json(response);
        } 
    }
}
