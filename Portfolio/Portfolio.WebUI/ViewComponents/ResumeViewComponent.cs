using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Portfolio.WebUI.ViewComponents
{
    public class ResumeViewComponent: ViewComponent
    {

        public IViewComponentResult Invoke()
        {

            return View();
        }
    }
}
