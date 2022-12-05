using BigOn.Domain.Business.BlogPostModule;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Portfolio.Domain.Business.BlogPostModule;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Portfolio.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
     public class BlogPostController : Controller
    {
        private readonly IMediator mediator;

        public BlogPostController(IMediator mediator)
        {
            this.mediator = mediator;
        }
        public async Task <IActionResult> Index(BlogPostPagedQuery query)
        {
            var response = await mediator.Send(query);
            return View(response);
        } 
        public IActionResult Create()
        {
            return View();
        } 

        [HttpPost]
        public async Task<IActionResult> Create(BlogPostCreateCommand command)
        {
            var response = await mediator.Send(command);
            return RedirectToAction(nameof(Index));
        }



        public async Task<IActionResult> Detail(BlogPostSingleQuery query)
        {
            var response = await mediator.Send(query);

            if (response == null)
            {
                return NotFound();
            }

            return View(response);
        }

        public async Task<IActionResult> Edit(BlogPostSingleQuery query)
        {
            var response = await mediator.Send(query);

            if (response == null)
            {
                return NotFound();
            }

            return View(response);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(BlogPostEditCommand command)
        {
            var response = await mediator.Send(command);

            return RedirectToAction(nameof(Index));
        }


        [HttpGet]

        public async Task<IActionResult> Remove(BlogPostRemoveCommand command)
        {
            var response = await mediator.Send(command);

            if (response == null)
            {
                return NotFound();
            }

            return RedirectToAction(nameof(Index));
        }


    }
}

