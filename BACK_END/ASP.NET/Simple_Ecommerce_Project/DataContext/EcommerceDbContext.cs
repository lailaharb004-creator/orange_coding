using Microsoft.EntityFrameworkCore;
using Simple_Ecommerce_Project.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace Simple_Ecommerce_Project.DataContext

{
    public class EcommerceDbContext:IdentityDbContext
    {
        public EcommerceDbContext(DbContextOptions<EcommerceDbContext>options):base (options) { }
        public DbSet<Category>Categories { get; set; }
        public DbSet<Product> Products { get; set; }
    }
}
