namespace API_ProjeKampi.WebAPI.Entities
{
    public class Product
    {
        public int ID { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public decimal Price { get; set; }

        public string ImageURL { get; set; } 
    }
}
