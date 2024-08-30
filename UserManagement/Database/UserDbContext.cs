using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using UserManagement.Models;

namespace UserManagement.Database
{
    public class UserDbContext: DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=TRD-417\\MSSQLSERVER2;Initial Catalog=UserDb;integrated security=true;multipleactiveresultsets=True;Encrypt=False");
        }

        public DbSet<User> Users {get; set; }

        public DbSet<Product> Products {get; set;}
    }
}