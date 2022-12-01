using MediatR;
using Microsoft.AspNetCore.Mvc;
using Portfolio.Domain.AppCode.Extension;
using Portfolio.Domain.Business.BlogPostModule;
using Portfolio.Domain.Models.DataContext;
using System.Threading.Tasks;

namespace Portfolio.WebUI.Controllers
{
    public class BlogPostController : Controller
    {
        private readonly IMediator mediator;
        private readonly PortfolioDbContext db;

        public BlogPostController(IMediator mediator)
        {
            this.mediator = mediator;
            
        }

       
        public async Task<IActionResult> Index(BlogPostPagedQuery query)
        {
            var response = await mediator.Send(query);
            if (Request.IsAjaxRequest())
            {
                return PartialView("_BlogsPartialView", response);
            }
            return View(response);
        }
    }
}
