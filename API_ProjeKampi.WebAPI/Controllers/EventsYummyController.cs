using API_ProjeKampi.WebAPI.Context;
using API_ProjeKampi.WebAPI.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API_ProjeKampi.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EventsYummyController : ControllerBase
    {
        private readonly API_Context _context;

        public EventsYummyController(API_Context context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult GetEventsYummy()
        {
            var values = _context.EventsYummy;
            return Ok(values);
        }

        [HttpPost]
        public IActionResult CreateEventsYummy(EventsYummy _eventsYummy)
        {
            _context.EventsYummy.Add(_eventsYummy);
            _context.SaveChanges();
            return Ok("Etkinlik ekleme işlemi tamamlandı.");
        }

        [HttpDelete]
        public IActionResult DeleteEventsYummy(int id)
        {
            var values = _context.EventsYummy.Find(id);
            _context.EventsYummy.Remove(values);
            _context.SaveChanges();
            return Ok("Etkinlik silme işlemi tamamlandı.");
        }


        [HttpGet("GetEventsYummy")]
        public IActionResult GetEventsYummyById(int Id)
        {
            var values = _context.EventsYummy.Find(Id);
            return Ok(values);
        }

        [HttpPut]
        public IActionResult PutEventsYummt(EventsYummy eventsYummy)
        {
            _context.EventsYummy.Update(eventsYummy);
            _context.SaveChanges();
            return Ok("Etkinlik güncellenmesi tamamlandı.");
        }

    }
}
