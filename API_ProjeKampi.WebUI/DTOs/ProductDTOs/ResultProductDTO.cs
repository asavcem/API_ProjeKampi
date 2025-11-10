namespace API_ProjeKampi.WebUI.DTOs.ProductDTOs
{
    public class ResultProductDTO
    {
        public int ID { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public decimal Price { get; set; }

        public string ImageURL { get; set; }

        public int? CategoryID { get; set; }

        //public Category Categories { get; set; }
    }
}
