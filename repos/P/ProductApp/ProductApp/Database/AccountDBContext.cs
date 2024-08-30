using Microsoft.EntityFrameworkCore;
using ProductApp.Models;

namespace ProductApp.Database
{
    public class AccountDBContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-DE69VTH\\SQLSERVER;Initial Catalog=MVCDb;integrated security=true;multipleactiveresultsets=True;Encrypt=False");
        }
        public DbSet<Account> Accounts { get; set; }
        public DbSet<Employee> Employees { get; set; }
    }
}
