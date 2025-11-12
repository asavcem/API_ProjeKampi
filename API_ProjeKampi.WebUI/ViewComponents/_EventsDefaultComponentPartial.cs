using API_ProjeKampi.WebUI.DTOs.EventsYummyDTOs;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace API_ProjeKampi.WebUI.ViewComponents
{
    public class _EventsDefaultComponentPartial : ViewComponent
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public _EventsDefaultComponentPartial(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:7211/api/EventsYummy/");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ResultEventsYummyDTO>>(jsonData);
                return View(values);
            }

            return View();
        }
    }
}
