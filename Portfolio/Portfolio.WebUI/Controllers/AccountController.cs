using MediatR;
using Microsoft.AspNetCore.Mvc;
using Portfolio.Domain.AppCode.Bussines.AccountModule;
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

        [HttpPost]
        public async Task<IActionResult> Register(RegisterCommand command)
        {
            var response = await mediator.Send(command);
            if (!ModelState.IsValid)
            {
                return View(command);
            }

            TempData["Message"] = $"{command.Email} - E-poct`a gonderilen linkle qeydiyyati tamamlayin";
            return RedirectToAction(nameof(SignIn));
        }



        public async Task<IActionResult> EmailConfirmation(RegisterConfirmationCommand command)
        {
            var response = await mediator.Send(command);

            if (!ModelState.IsValid)
            {
                return View(command);
            }
            return RedirectToAction(nameof(SignIn));
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
        //public IActionResult ForgetPassword()
        //{
        //    return View();
        //}
      
        public async Task <IActionResult> SignOut(SignOutCommand command)
        {
            var respone = await mediator.Send(command);
               return RedirectToAction("About", "Home");
        }
        [Route("/email-confirm")]
        public async Task<IActionResult> ConfirmEmail (RegisterConfirmationCommand command)
        {
            var response = await mediator.Send(command);

            return RedirectToAction(nameof(SignIn));
        }
       
    }
}
