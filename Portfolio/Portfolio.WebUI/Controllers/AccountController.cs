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
        [HttpPost]
        public async Task<IActionResult> SignIn(SigninCommand command)
        {
           var response= await mediator.Send(command);
            if (!ModelState.IsValid)
            {
                return View(command);
            }
            return RedirectToAction("About", "Home");
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
            var response = await mediator.Send(command);
            if (!ModelState.IsValid)
            {
                return View(command);
            }
            


            return Json(response);
        } 
        
        public async Task <IActionResult> SignOut(SignOutCommand command)
        {
            var respone = await mediator.Send(command);
               return RedirectToAction("About", "Home");
        }
        //[Route("/confirm-email")]
        //public async Task<IActionResult> ConfirmEmail(string token)
        //{
            
        //}
    }
}
