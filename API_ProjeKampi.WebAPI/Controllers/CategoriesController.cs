using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using API_ProjeKampi.WebAPI.Context;
using API_ProjeKampi.WebAPI.Entities;

namespace API_ProjeKampi.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        private readonly API_Context _context;

        public CategoriesController(API_Context context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult GetCategory()
        {
            var values = _context.Categories;
            return Ok(values);
        }

        [HttpPost]
        public IActionResult CreateCategory(Category category)
        {
            _context.Categories.Add(category);
            _context.SaveChanges();
            return Ok("Kategori ekleme işlemi tamamlandı. ");
        }

        [HttpDelete]
        public IActionResult DeleteCategory(int id)
        {
            var values = _context.Categories.Find(id);
            _context.Categories.Remove(values);
            _context.SaveChanges();
            return Ok("Kategori silme işlemi tamamlandı. ");
        }

        [HttpGet("GetCategoryId")]
        public IActionResult GetCategoryById(int id)
        {
            var values = _context.Categories.Find(id);
            return Ok(values);
        }

        [HttpPut]
        public IActionResult PutCategory(Category category)
        {
            _context.Categories.Update(category);
            _context.SaveChanges();
            return Ok("Kategori güncellenmesi tamamlandı. ");
        }
               
    }
}
