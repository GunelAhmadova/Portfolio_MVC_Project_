using MediatR;
using Microsoft.AspNetCore.Mvc;
using Portfolio.Domain.AppCode.Bussines.AccountModule;
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

        public IActionResult SignIn()
        {
            return View();
        }
        public IActionResult ForgetPassword()
        {
            return View();
        }
        public IActionResult Register()
        {
            return View();
        }
       
        [HttpPost]
        public async  Task<IActionResult> Register(RegisterCommand command)
        {
            if (!ModelState.IsValid)
            {
                return View(command);
            }
            

            var response = await mediator.Send(command);

            return Json(response);
        } 
        
        public IActionResult SignOut()
        {
            return View();
        }
    }
}
