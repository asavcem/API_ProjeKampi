using API_ProjeKampi.WebAPI.Context;
using API_ProjeKampi.WebAPI.Dtos.ProductDtos;
using API_ProjeKampi.WebAPI.Entities;
using AutoMapper;
using FluentValidation;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API_ProjeKampi.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IValidator<Product> _validator;
        private readonly API_Context _context;
        private readonly IMapper _mapper;

        public ProductsController(IValidator<Product> validator, API_Context context, IMapper mapper)
        {
            _validator = validator;
            _context = context;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult GetProducts()
        {
            var values = _context.Products;
            return Ok(values);
        }

        [HttpPost]
        public IActionResult PostProduct(CreateProductDto product)
        {
            var valueMap = _mapper.Map<Product>(product);
            var validationResult = _validator.Validate(valueMap);
            if (!validationResult.IsValid)
            {
                return BadRequest(validationResult.Errors.Select(x => x.ErrorMessage));
            }

            _context.Products.Add(valueMap);
            _context.SaveChanges();
            return Ok(new
            {
                message = "Ürün ekleme işlemi başarılı.",
                data = product
            });
        }

        [HttpDelete]
        public IActionResult DeleteProduct(int id)
        {
            var value = _context.Products.Find(id);
            _context.Products.Remove(value);
            _context.SaveChanges();
            return Ok("Ürün silme işlemi başarılı.");
        }

        [HttpGet("GetByIdProduct")]
        public IActionResult GetByIdProduct(int id)
        {
            var value = _context.Products.Find(id);
            return Ok(value);
        }

        [HttpPut]
        public IActionResult PutProduct(Product product)
        {
            var validationResult = _validator.Validate(product);
            if (!validationResult.IsValid)
            {
                return BadRequest(validationResult.Errors.Select(x => x.ErrorMessage));
            }

            _context.Products.Update(product);
            _context.SaveChanges();
            return Ok(new
            {
                message = "Ürün güncelleme işlemi başarılı.",
                data = product
            });
        }

        [HttpGet("ProductListWithCategory")]
        public IActionResult ProductListWithCategory()
        {
            var value = _context.Products.Include(x => x.Categories);
            return Ok(_mapper.Map<List<ResultProductListWithCategoriesDto>>(value));
        }

    }
}
