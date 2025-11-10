using Microsoft.AspNetCore.Mvc;

namespace API_ProjeKampi.WebUI.ViewComponents._DefaultMenuViewComponents
{
    public class _DefaultMenuViewComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
