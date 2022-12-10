 using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Portfolio.Domain.AppCode.Bussines.PersonModule;
using System.Threading.Tasks;

namespace Portfolio.WebUI.Areas.Admin.Controllers
{

    [Authorize(Roles = "admin")]

    [Area("Admin")]
    public class PersonController : Controller
    {
        private readonly IMediator _mediator;



        public PersonController(IMediator mediator)
        {
            _mediator = mediator;
        }

        public async Task<IActionResult> Index()
        {
            var query = new PersonAllQuery();
            var response = await _mediator.Send(query);
            return View(response);
        }


        public async Task<IActionResult> Edit(PersonAllQuery query)
        {  
            var response = await _mediator.Send(query);

            return View(response);
        }   

        [HttpPost]

        public async Task<IActionResult> Edit(PersonEditCommand command)
        {
           
           
            var responce = await _mediator.Send(command);
           
            return RedirectToAction(nameof(Index));
        }

    }
}

