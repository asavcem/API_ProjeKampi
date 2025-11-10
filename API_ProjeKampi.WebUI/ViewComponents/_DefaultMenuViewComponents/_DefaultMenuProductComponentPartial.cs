using API_ProjeKampi.WebUI.DTOs.CategoryDTOs;
using API_ProjeKampi.WebUI.DTOs.ProductDTOs;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace API_ProjeKampi.WebUI.ViewComponents._DefaultMenuViewComponents
{
    public class _DefaultMenuProductComponentPartial : ViewComponent
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public _DefaultMenuProductComponentPartial(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:7211/api/Products");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ResultProductDTO>>(jsonData);
                return View(values);
            }

            return View();
        }
    }
}
