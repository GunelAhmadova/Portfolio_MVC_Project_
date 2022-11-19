using Microsoft.AspNetCore.Mvc;


namespace Portfolio.WebUI.ViewComponents
{
    public class ContactMe: ViewComponent
    { 
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
