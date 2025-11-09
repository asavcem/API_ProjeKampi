using API_ProjeKampi.WebUI.DTOs.ServiceDTOs;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace API_ProjeKampi.WebUI.ViewComponents
{
    public class _ServiceDefaultCompopnentPartial : ViewComponent
    {
        //public IViewComponentResult Invoke()
        //{
        //    return View();
        //}

        private readonly IHttpClientFactory _httpClientFactory;

        public _ServiceDefaultCompopnentPartial(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:7211/api/Services/");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ResultServiceDTO>>(jsonData);
                return View(values);
            }

            return View();
        }
    }
}
