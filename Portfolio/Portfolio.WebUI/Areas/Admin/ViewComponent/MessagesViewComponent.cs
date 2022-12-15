using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Portfolio.Domain.AppCode.Bussines.ContactPostModule;

namespace Portfolio.WebUI.Areas.Admin.ViewComponents
{
    public class MessagesViewComponent:ViewComponent
    {
        private readonly IMediator mediator;

        public MessagesViewComponent(IMediator mediator)
        {
            this.mediator = mediator;
        }

        public  IViewComponentResult Invoke(ContactPostAllQuery query)
        {
           var response = mediator.Send(query); 
            return View(response);
        }
    }
}
