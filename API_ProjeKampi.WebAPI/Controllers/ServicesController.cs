using API_ProjeKampi.WebAPI.Context;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using API_ProjeKampi.WebAPI.Entities;

namespace API_ProjeKampi.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ServicesController : ControllerBase
    {
        private readonly API_Context _context;

        public ServicesController(API_Context context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult GetService()
        {
            var values = _context.Services;
            return Ok(values);
        }

        [HttpPost]
        public IActionResult CreateService(Service _service)
        {
            _context.Services.Add(_service);
            _context.SaveChanges();
            return Ok("Servis ekleme işlemi tamamlandı.");
        }

        [HttpDelete]
        public IActionResult DeleteService(int id)
        {
            var values = _context.Services.Find(id);
            _context.Services.Remove(values);
            _context.SaveChanges();
            return Ok("Servis silme işlemi tamamlandı.");
        }

        [HttpGet("GetServiceId")]
        public IActionResult GetServiceById(int id)
        {
            var values = _context.Services.Find(id);
            return Ok(values);
        }

        [HttpPut]
        public IActionResult PutService(Service _service)
        {
            _context.Services.Update(_service);
            _context.SaveChanges();
            return Ok("Servis güncellemesi tamamlandı.");
        }
    }
}
