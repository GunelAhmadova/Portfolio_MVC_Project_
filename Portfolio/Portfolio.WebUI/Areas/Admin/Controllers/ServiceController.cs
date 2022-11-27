﻿using MediatR;
using Microsoft.AspNetCore.Mvc;
using Portfolio.Domain.AppCode.Bussines.PersonModule;
using Portfolio.Domain.AppCode.Bussines.ServiceModule;
using Portfolio.Domain.AppCode.DTOs.ServiceDTOs;
using Portfolio.Domain.Models.DataContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Portfolio.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ServiceController : Controller
    {
        private readonly IMediator mediator;
        public ServiceController(IMediator mediator)
        {
            this.mediator = mediator;
        }

        public async Task<IActionResult> Index()
        {
            var query = new ServiceAllQuery();

            var response = await mediator.Send(query);
            return View(response);
        }
       
       
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(ServiceDto serviceDto)
        {
            if (!ModelState.IsValid) return View(serviceDto);
            ServiceCreateCommand command = new();
            command.serviceDto = serviceDto;
            var response = await mediator.Send(command);
            return RedirectToAction(nameof(Index));
        } 

        public async Task<IActionResult> Edit(ServiceSingleQuery query)
        {
           
           
            var response =await mediator.Send(query);
            return View(response);
        }
        [HttpPost]
        public async Task<IActionResult> Edit(ServiceDto serviceDto)
        {
            if (!ModelState.IsValid) return View(serviceDto);
            ServiceEditCommand command = new ServiceEditCommand()
            {
                serviceDto = serviceDto
            };
            var response =await mediator.Send(command);
            return RedirectToAction(nameof(Index));
        }
         


     public async Task<IActionResult> Detail(ServiceSingleQuery query)
        {

            var response = await mediator.Send(query);
            return View(response);
        } 


        [HttpGet]
        public async Task<IActionResult> Remove(ServiceRemoveCommand command)
        {
            var response =await mediator.Send(command);

            if (response == null)
            {
                return NotFound();
            } 

            return RedirectToAction(nameof(Index));
        }
    }
}
