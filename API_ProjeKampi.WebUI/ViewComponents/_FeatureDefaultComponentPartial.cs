using Microsoft.AspNetCore.Mvc;

namespace API_ProjeKampi.WebUI.ViewComponents
{
    public class _FeatureDefaultComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
