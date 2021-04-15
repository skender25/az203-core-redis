using Microsoft.EntityFrameworkCore;

namespace az203_core.Models
{
    public class ProductContext : DbContext
    {
        // Replace the database connection string  here
        readonly string connectionstring = "Server=tcp:demovm.database.windows.net,1433;Initial Catalog=appregdemo;Persist Security Info=False;User ID=demouser;Password=Demo123456789-;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
        public DbSet<Product> Products { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer(connectionstring);
            base.OnConfiguring(options);
        }

    }
}
