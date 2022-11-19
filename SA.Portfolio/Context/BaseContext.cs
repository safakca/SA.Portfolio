using SA.Portfolio.Models;
using System.Data.Entity; 

namespace SA.Portfolio.Context
{
    public class BaseContext : DbContext
    {
        public BaseContext() : base("DefaultConnection")
        {

        }

        protected override void OnModelCreating(DbModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }

        public DbSet<About> Abouts { get; set; }
        public DbSet<Admin> Admins { get; set; }
        public DbSet<Members> Members { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<ServiceFeatures> ServiceFeatures { get; set; }
        public DbSet<Testimonial> Testimonials { get; set; }
    }
}