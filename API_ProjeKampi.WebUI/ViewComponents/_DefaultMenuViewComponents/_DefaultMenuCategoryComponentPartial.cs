using API_ProjeKampi.WebUI.DTOs.CategoryDTOs;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace API_ProjeKampi.WebUI.ViewComponents._DefaultMenuViewComponents
{
    public class _DefaultMenuCategoryComponentPartial : ViewComponent
    {
      //public IViewComponentResult Invoke()
      //  {
      //      return View();
      //  }

        private readonly IHttpClientFactory _httpClientFactory;

        public _DefaultMenuCategoryComponentPartial(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:7211/api/Categories");
            if(responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ResultCategoryDTO>>(jsonData);
                return View(values);
            }

            return View();
        }
    }
}
