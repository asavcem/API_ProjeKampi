using API_ProjeKampi.WebAPI.Context;
using API_ProjeKampi.WebAPI.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API_ProjeKampi.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestimonialController : ControllerBase
    {
        private readonly API_Context _context;

        public TestimonialController(API_Context context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult GetTestimonial()
        {
            var values = _context.Testimonials;
            return Ok(values);
        }

        [HttpPost]
        public IActionResult CreateTestimonial(Testimonial _testimonial)
        {
            _context.Testimonials.Add(_testimonial);
            _context.SaveChanges();
            return Ok("Referans ekleme işlemi tamamlandı.");
        }

        [HttpDelete]
        public IActionResult DeleteTestimonial(int id)
        {
            var values = _context.Testimonials.Find(id);
            _context.Testimonials.Remove(values);
            _context.SaveChanges();
            return Ok("Referans silme işlemi tamamlandı.");
        }

        [HttpGet("GetTestimonialId")]
        public IActionResult GetTestimonialById(int id)
        {
            var values = _context.Testimonials.Find(id);
            return Ok(values);
        }

        [HttpPut]
        public IActionResult PutTestimonial(Testimonial testimonial)
        {
            _context.Testimonials.Update(testimonial);
            _context.SaveChanges();
            return Ok("Referans güncellemesi tamamlandı.");
        }
    }
}
