using API_ProjeKampi.WebAPI.Entities;

namespace API_ProjeKampi.WebAPI.Dtos.ProductDtos
{
    public class CreateProductDto
    {

        public string Name { get; set; }

        public string Description { get; set; }

        public decimal Price { get; set; }

        public string ImageURL { get; set; }

        public int? CategoryID { get; set; }

    }
}
