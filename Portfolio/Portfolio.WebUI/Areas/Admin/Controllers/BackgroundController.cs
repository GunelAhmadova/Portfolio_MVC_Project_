using MediatR;
using Microsoft.AspNetCore.Mvc;
using Portfolio.Domain.AppCode.Bussines.BackgroundModule;
using Portfolio.Domain.AppCode.Bussines.ServiceModule;
using Portfolio.Domain.AppCode.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Portfolio.WebUI.Areas.Admin.Controllers
{

    [Area("Admin")]
    public class BackgroundController : Controller
    {
        private readonly IMediator mediator;

        public BackgroundController(IMediator mediator)
        {
            this.mediator = mediator;
        }
        public async Task<IActionResult> Index()
        {
            var query = new BackgroundAllQuery();
          var response= await mediator.Send(query);
            if (response == null) return NotFound();
            
            return View(response);
        }
        public IActionResult Create() 
        {
            ViewBag.BackList = (IEnumerable<string>)Enum.GetNames(typeof(BackgroundType));
            ViewBag.AcademicTypes = (IEnumerable<string>)Enum.GetNames(typeof(Academiclevel));
            ViewBag.ProLevels = (IEnumerable<string>)Enum.GetNames(typeof(ProLevel));
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(BackgroundCreateCommand command)
        {
            if (!ModelState.IsValid) return View(command);
            var respone = await mediator.Send(command);
            return RedirectToAction(nameof(Index));
        }


        public async Task<IActionResult> Edit(BackgroundSingleQuery query)
        {
            var response = await mediator.Send(query);
            if (response == null) return NotFound();

            return View(response);
        }

        [HttpPost]

        public async Task<IActionResult> Edit(BackgroundEditCommand command)
        {
            if (!ModelState.IsValid) return View(command);
            var data = await mediator.Send(command);
            if (data == null)
            {
                return View(data);
            }

            return RedirectToAction(nameof(Index));
        }


        public async Task<IActionResult> Detail(BackgroundSingleQuery query)
        {

            var response = await mediator.Send(query);

            return View(response);
        }

        [HttpGet]
        public async Task<IActionResult> Remove(BackgroundRemoveCommand command)
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
