using MVCRevision.DataBase;
using MVCRevision.Functionality;
using MVCRevision.Models;

namespace MVCRevision.Services
{
    public class AccountServices : IAccountOperation
    {
        AccountDbContext Context;
        public AccountServices() { 
        Context=new AccountDbContext();
                }
        int IAccountOperation.createAccount(Account account)
        {   
            Context.Account.Add(account);
            return Context.SaveChanges();
        }
        int IAccountOperation.AccountValidation(string username, string Password)
        {
            var result = Context.Account.Where(e => e.UserName == username && e.Password == Password).FirstOrDefault();
            if (result == null)
            {
                return 0;
            }
            return 1;
        }

        
    }
}
