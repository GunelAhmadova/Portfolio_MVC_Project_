using BigOn.Domain.Business.CategoryModule;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Portfolio.Domain.AppCode.Bussines.PortfoliaModule;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Portfolio.WebUI.Areas.Admin.Controllers
{ 

    [Area("Admin")]
    public class PortfoliaController : Controller
    {
        private readonly IMediator mediator;

        public PortfoliaController(IMediator mediator)
        {
            this.mediator = mediator;
        }


        public async Task<IActionResult> Index(PortfoliaAllQuery query)
        {
            var response = await mediator.Send(query);
            return View(response);
        } 

        public async Task <IActionResult> Create()
        {
            CategoryAllQuery query = new();
            var categories = await mediator.Send(query);


            ViewBag.CategoryList = categories;


            return View();
        } 

        [HttpPost]

        public async Task <IActionResult> Create(PortfoliaCreateCommand command)
        {
            CategoryAllQuery query = new();
            var categories = await mediator.Send(query);


            ViewBag.CategoryList = categories;
            var response = await mediator.Send(command);
            return RedirectToAction(nameof(Index));
        }


    }
}
