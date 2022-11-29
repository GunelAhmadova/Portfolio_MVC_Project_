using MediatR;
using Microsoft.AspNetCore.Mvc;
using Portfolio.Domain.Business.BlogPostModule;
using Portfolio.Domain.Models.DataContext;
using System;
using System.Collections.Generic;
using System.Linq;
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

            return View(response);
        }
    }
}
