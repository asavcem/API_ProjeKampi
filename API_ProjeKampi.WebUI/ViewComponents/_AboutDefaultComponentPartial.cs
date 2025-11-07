using Microsoft.AspNetCore.Mvc;

namespace API_ProjeKampi.WebUI.ViewComponents
{
    public class _AboutDefaultComponentPartial: ViewComponent 
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
