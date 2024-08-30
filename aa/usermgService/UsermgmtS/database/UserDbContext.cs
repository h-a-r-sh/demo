using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using UsermgmtS.models;

namespace UsermgmtS.database
{
    public class UserDbContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-DE69VTH\\SQLSERVER;Initial Catalog=UserManagementDb;integrated security=true;multipleactiveresultsets=True;Encrypt=False");
        }
        
        public DbSet<User> users{get; set;}
        public DbSet<Product> products{get; set;}
    }
}