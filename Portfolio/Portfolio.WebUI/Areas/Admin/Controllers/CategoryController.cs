using BigOn.Domain.Business.CategoryModule;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Portfolio.Domain.AppCode.Bussines.CategoryModule;
using Portfolio.Domain.Business.CategoryModule;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Portfolio.WebUI.Areas.Admin.Controllers
{  

    [Area("Admin")]
    public class CategoryController : Controller
    {  
        private readonly IMediator mediator;

        public CategoryController(IMediator mediator)
        {
            this.mediator = mediator;
        } 

        public async Task <IActionResult> Index(CategoryAllQuery query)
        {
            var response = await mediator.Send(query);
            return View(response);
        } 

        public IActionResult Create()
        {

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(CategoryCreateCommand command)
        {
            var response = await mediator.Send(command);

            return RedirectToAction(nameof(Index));
        }


        public async Task<IActionResult> Detail(CategorySingleQuery query)
        {

            var response = await mediator.Send(query);

            return View(response);
        }

        public async  Task<IActionResult> Edit(CategorySingleQuery query)
        {
            var response = await mediator.Send(query);
            return View(response);
        }
         

        [HttpPost]

        public async Task<IActionResult> Edit(CategoryEditCommand command)
        {
            var response = await mediator.Send(command);
           return RedirectToAction(nameof(Index));
            
        }

    }
}
