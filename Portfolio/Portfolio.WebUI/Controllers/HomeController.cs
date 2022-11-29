using BigOn.Domain.Business.CategoryModule;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Portfolio.Domain.AppCode.Bussines.BackgroundModule;
using Portfolio.Domain.AppCode.Bussines.PersonModule;
using Portfolio.Domain.AppCode.Bussines.PortfoliaModule;
using Portfolio.Domain.AppCode.Bussines.ServiceModule;
using Portfolio.Domain.AppCode.Bussines.SkillModule;
using Portfolio.Domain.AppCode.DTOs.ServiceDTOs;
using Portfolio.Domain.Models;
using Portfolio.Domain.Models.Entites;
using Portfolio.WebUI.ViewModel;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Portfolio.WebUI.Controllers
{
    public class HomeController : Controller
    {
        private readonly IMediator mediator;

        public HomeController(IMediator mediator)
        {
            this.mediator = mediator;
        }
       
        public async Task <IActionResult> About()
        {
            AboutMeViewModel vm = new();
            PersonAllQuery query = new PersonAllQuery();
            vm.PersonDto = await mediator.Send(query);
            ServiceAllQuery ServiceQuery = new ServiceAllQuery();
            vm.Services = (ICollection<ServiceDto>)await mediator.Send(ServiceQuery);
            SkillAllQuery skillQuery = new SkillAllQuery();
            vm.Skills = (ICollection<Skill>)await mediator.Send(skillQuery);


            return View(vm);
        }
        public async Task<IActionResult> Resume()
        {
            ResumeViewModel vm = new ResumeViewModel();
            PersonAllQuery query = new();
            vm.Person = await mediator.Send(query);
            SkillAllQuery skillquery = new();
            vm.Skills = (ICollection<Skill>)await mediator.Send(skillquery);
            BackgroundAllQuery Bquery = new();
            vm.Backgrounds = (ICollection<Background>)await mediator.Send(Bquery);

            return View(vm);
        }
        public IActionResult Contact()
        {
            return View();
        } 


        public async Task <IActionResult> Portfolia()
        {
            CategoryPortfoliaViewModel vm = new();
            CategoryAllQuery query = new();
            PortfoliaAllQuery Squery = new();
            vm.Categories = (ICollection<Category>)await mediator.Send(query);
            vm.Portfolias = (ICollection<Portfolia>)await mediator.Send(Squery);

            return View(vm);
        }





    }
}
