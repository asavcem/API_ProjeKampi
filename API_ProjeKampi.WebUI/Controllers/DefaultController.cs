using Microsoft.AspNetCore.Mvc;

namespace API_ProjeKampi.WebUI.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
