using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UserManagement.Database;
using UserManagement.Functionality;
using UserManagement.Models;


namespace UserManagement.Service
{
    public class UserService : IUserOperation
    {
        UserDbContext dbContext;
        public UserService()
        {
            dbContext=new UserDbContext();
        }
        int IUserOperation.CreateAccount(User user)
        {
            dbContext.Users.Add(user);
            return dbContext.SaveChanges();
        }

        int IUserOperation.ValidateAccount(string username, string password)
        {
            var res=dbContext.Users.Where(r=> r.Username==username && r.Password==password).FirstOrDefault();
            if(res==null)
            {
                return 0;
            }
            return 1;
        }
    }
}