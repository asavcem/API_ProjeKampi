namespace API_ProjeKampi.WebAPI.Dtos.ProductDtos
{
    public class ResultProductListWithCategoriesDto
    {
        public string Name { get; set; }

        public string Description { get; set; }

        public decimal Price { get; set; }

        public string ImageURL { get; set; }

        public int CategoryID { get; set; }

        public string CategoryName { get; set; }

    }
}
