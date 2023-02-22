using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.IO;

namespace Portfolio.WebUI.Areas.Admin.Controllers
{

    [Area("Admin")]
    //[Authorize(Roles ="admin,moderator")]
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return View();

        }
    }
}
