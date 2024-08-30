
using Microsoft.EntityFrameworkCore;
using ProductTable.Models;

namespace ProductTable.Connections
{
    public class ProductDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-DE69VTH\\SQLSERVER;Initial Catalog=CoforgeDb;integrated security=true;multipleactiveresultsets=True;Encrypt=False");
        }
        public DbSet<Product> products { get; set; }  //product will be table name
    }
}