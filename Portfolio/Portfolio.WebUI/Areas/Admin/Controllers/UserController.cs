using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Portfolio.Domain.AppCode.Bussines.UserModule;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Portfolio.WebUI.Areas.Admin.Controllers
{
    [Authorize(Roles = "admin")]

    [Area("Admin")]
    public class UserController :Controller
    {
        private readonly IMediator mediator;

        public UserController(IMediator mediator)
        {
            this.mediator = mediator;
        }
        public async Task<IActionResult> Index(UserPagedQuery query)
        {
            var data = await mediator.Send(query);

            return View(data);
        }

        public async Task<IActionResult> Detail(UserDetailQuery query)
        {
            ViewBag.AvailableRoles = await mediator.Send(new UserAvailableRolesQuery() { UserId = query.Id });
            
            var data = await mediator.Send(query);

            return View(data);
        } 

        [HttpPost]
        public async Task<IActionResult> SetRole(UserSetRoleCommand command)
        {
            var response = await mediator.Send(command);
            return Json(response);
        }


    }
}
