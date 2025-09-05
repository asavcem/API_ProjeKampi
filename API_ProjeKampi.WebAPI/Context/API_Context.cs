
using API_ProjeKampi.WebAPI.Entities;
using System.Collections.Generic;

namespace API_ProjeKampi.WebAPI.Context
{
    public class API_Context
    {

        public DbSet<Category> Categories { get; set; }

        public DbSet<Chef> Categories { get; set; }

        public DbSet<Contact> Categories { get; set; }

        public DbSet<Feature> Categories { get; set; }

        public DbSet<Image> Categories { get; set; }

        public DbSet<Message> Categories { get; set; }

        public DbSet<Product> Categories { get; set; }

        public DbSet<Reservation> Categories { get; set; }

        public DbSet<Service> Categories { get; set; }

        public DbSet<Testimonial> Categories { get; set; }
    }  
}
