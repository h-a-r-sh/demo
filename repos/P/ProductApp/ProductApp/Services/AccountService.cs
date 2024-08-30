using ProductApp.Database;
using ProductApp.Functionality;
using ProductApp.Models;

namespace ProductApp.Services
{
    public class AccountService : IAccountOperations
    {
        AccountDBContext accountDBContext;
        public AccountService() { 
            accountDBContext = new AccountDBContext();  
        }
        int IAccountOperations.AccountCreate(Account account)
        {
            accountDBContext.Accounts.Add(account);
            return accountDBContext.SaveChanges();
        }

        int IAccountOperations.AccountValidation(string username, string password)
        {
            var result=accountDBContext.Accounts.Where(e=>e.Username == username && e.Password==password).FirstOrDefault();
            if (result == null)
            {
                return 0;
            }
            return 1;
        }
    }
}
