using Microsoft.EntityFrameworkCore;
using ProductTable.Models;

namespace ProductTable.Connection
{//defining EF core
    public class ProductDbContext : DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Data Source=TRD-417\\MSSQLSERVER2;Initial Catalog=CoforgeDB;integrated security=true;multipleactiveresultsets=True;Encrypt=False");
    }
    // CoforgeDb will be the database name in the server
    public DbSet<Product> products{ get; set;} // "products" will be table name
}
}