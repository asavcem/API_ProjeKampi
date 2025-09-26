using Microsoft.AspNetCore.Mvc;

namespace API_ProjeKampi.WebUI.ViewComponents
{
    public class _NavbarDefaultComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
