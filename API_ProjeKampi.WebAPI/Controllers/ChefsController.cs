using API_ProjeKampi.WebAPI.Context;
using API_ProjeKampi.WebAPI.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API_ProjeKampi.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ChefsController : ControllerBase
    {
        private readonly API_Context _context;

        public ChefsController(API_Context context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult GetChefs()
        {
            var values = _context.Chefs;
            return Ok(values);
        }

        [HttpGet("GetChef")]
        public  IActionResult GetChefId(int ID)
        {
            var value = _context.Chefs.Find(ID);
            return Ok(value);
        }

        [HttpPost]
        public IActionResult CreateChef(Chef chef)
        {
            _context.Chefs.Add(chef);
            _context.SaveChanges();
            return Ok("Şef ekleme işlemi tamamlandı. ");
        }

        [HttpDelete]
        public IActionResult DeleteChef(int ID)
        {
            var value = _context.Chefs.Find(ID);
            _context.Chefs.Remove(value);
            _context.SaveChanges();

            return Ok("Şef silme işlemi tamamlandı. ");
        }

        [HttpPut]
        public IActionResult PutChef(Chef chef)
        {
            _context.Chefs.Update(chef);
            _context.SaveChanges();
            return Ok("Şef güncelleme işlemi tamamlandı. ");
        }
    }
}
