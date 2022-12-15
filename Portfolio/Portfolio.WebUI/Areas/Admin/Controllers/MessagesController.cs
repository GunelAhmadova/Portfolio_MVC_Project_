using MediatR;
using Microsoft.AspNetCore.Mvc;
using Portfolio.Domain.AppCode.Bussines.ContactPostModule;
using System.Threading.Tasks;

namespace Portfolio.WebUI.Areas.Admin.Controllers
{

    [Area("Admin")]
    public class MessagesController: Controller
    {
        private readonly IMediator mediator;

        public MessagesController(IMediator mediator)
        {
            this.mediator = mediator;
        }
        public async Task <IActionResult> Index(ContactPostAllQuery query)
        {
          var response=  await mediator.Send(query);
            return View(response);
        } 
        
    }
}
