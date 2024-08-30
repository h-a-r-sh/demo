using System;
using UsermgmtS.database;
using UsermgmtS.functionality;
using UsermgmtS.models;

namespace UsermgmtS.services
{
    public class UserService : IUserService
    {   UserDbContext dbContext;
        public UserService()
        {
            dbContext=new UserDbContext();
        }
        
        int IUserService.AccountValidate(string username, string password)
        {
            var res=dbContext.users.Where(e=>e.Username==username && e.Password==password).FirstOrDefault();
            if(res==null){
                return 0;
            }
            return 1;
        }

        int IUserService.CreateAccount(User user)
        {
            dbContext.users.Add(user);
            return dbContext.SaveChanges();
        }
    }
}