using API_ProjeKampi.WebAPI.Context;
using API_ProjeKampi.WebAPI.Entities;
using FluentValidation;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API_ProjeKampi.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IValidator<Product> _validator;
        private readonly API_Context _context;

        public ProductsController(IValidator<Product> validator, API_Context context)
        {
            _validator = validator;
            _context = context;
        }

        [HttpGet]
        public IActionResult GetProducts()
        {
            var values = _context.Products;
            return Ok(values);
        }

        [HttpPost]
        public IActionResult PostProduct(Product product)
        {
            var validationResult = _validator.Validate(product);
            if (!validationResult.IsValid)
            {
                return BadRequest(validationResult.Errors.Select(x => x.ErrorMessage));
            }

            _context.Products.Add(product);
            _context.SaveChanges();
            return Ok(new
            {
                message = "Ürün ekleme işlemi başarılı.",
                data = product
            });
        }
    }
}
