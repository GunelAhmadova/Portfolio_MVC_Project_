using Microsoft.AspNetCore.Mvc;
using Portfolio.Domain.DTOs;
using Portfolio.Domain.Models.Entites.Identity;

namespace Portfolio.WebUI.Areas.Admin.Controllers
{

    [Area("Admin")]
    public class AccountController : Controller
    {
        public IActionResult Register()
        {
            return View();
        }
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public  IActionResult Register(RegisterDTO dto)
        {
            if (!ModelState.IsValid)
            {
                return View(dto);
            }
            AppUser user = new()
            {
                Email = dto.Email,
                

            };
            return Json(dto);
        } 
    }
}
