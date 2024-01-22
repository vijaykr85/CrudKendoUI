using Microsoft.EntityFrameworkCore;

namespace CrudKendoUI.Models
{
    public class productContext : DbContext

    {
        public productContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Product> productDetails { get; set; }
    }
}
