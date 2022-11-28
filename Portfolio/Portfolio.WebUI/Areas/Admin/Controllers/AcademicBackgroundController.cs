using Microsoft.AspNetCore.Mvc;

namespace Portfolio.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AcademicBackgroundController : Controller
    {
        public IActionResult Index() 

        {
            return View();
        }
    }
}
