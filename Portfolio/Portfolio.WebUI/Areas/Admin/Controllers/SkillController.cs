using MediatR;
using Microsoft.AspNetCore.Mvc;
using Portfolio.Domain.AppCode.Bussines.ServiceModule;
using Portfolio.Domain.AppCode.Bussines.SkillModule;
using Portfolio.Domain.AppCode.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Portfolio.WebUI.Areas.Admin.Controllers
{

    [Area("Admin")]
    public class SkillController : Controller
    {
        private readonly IMediator mediator;

        public SkillController(IMediator mediator)
        {
            this.mediator = mediator;
        }
        public async Task <IActionResult>Index(SkillAllQuery query) 

        {
            var response = await mediator.Send(query);
            return View(response);
        }


        public IActionResult Create()
        {
            ViewBag.SkillTypes = Enum.GetNames(typeof(SkillType));
            return View();
        }

        [HttpPost]

        public async Task<IActionResult> Create(SkillCreateCommand command) 
        {
            if (!ModelState.IsValid) return View(command);
            var response = await mediator.Send(command);

            if (response == null)
            {
                return View(response);
            }

            return RedirectToAction(nameof(Index));

          
        }

        public async Task <IActionResult> Edit(SkillSingleQuery query)
        {
            var response = await mediator.Send(query);
            if (response == null) return NotFound();

            return View(response);
        } 

        [HttpPost] 

        public async Task <IActionResult> Edit(SkillEditCommand command)
        {
            if (!ModelState.IsValid) return View(command);
            var data = await mediator.Send(command);
            if (data == null)
            {
                return View(data);
            }

            return RedirectToAction(nameof(Index));
        } 


        public async Task <IActionResult> Detail(SkillSingleQuery query)
        {

            var response = await mediator.Send(query);

            return View(response);
        }

        [HttpGet]
        public async Task<IActionResult> Remove(SkillRemoveCommand command)
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
