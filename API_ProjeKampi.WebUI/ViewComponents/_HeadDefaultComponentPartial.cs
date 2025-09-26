using Microsoft.AspNetCore.Mvc;

namespace API_ProjeKampi.WebUI.ViewComponents
{
    public class _HeadDefaultComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
