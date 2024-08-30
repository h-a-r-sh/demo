using Microsoft.EntityFrameworkCore;
using MVCRevision.Models;
namespace MVCRevision.DataBase

{
    public class AccountDbContext : DbContext
    {
        public AccountDbContext() { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-DE69VTH\\SQLSERVER;Initial Catalog=MVCRevisionDb;integrated security=true;multipleactiveresultsets=True;Encrypt=False");
        }
        public DbSet<Account> Account { get; set; } 
    }
}
