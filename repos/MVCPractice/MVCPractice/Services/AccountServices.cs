using MVCPractice.DataBase;
using MVCPractice.Functionality;
using MVCPractice.Models;

namespace MVCPractice.Services
{
    public class AccountServices : IAccountServices
    {
        DbfirstContext DbfirstContext;
        public AccountServices()
        {
            DbfirstContext = new DbfirstContext();
        }
        int IAccountServices.AccountCreate(User user)
        {
         DbfirstContext.Add(user);
            return DbfirstContext.SaveChanges();
        }

        int IAccountServices.AccountLogin(string username, string password)
        {
            var temp=DbfirstContext.Users.Where(e=>e.UserName==username&&e.Password==password).FirstOrDefault();
            if (temp == null)
            {
                return 0;
            }
            return 1;
        }
    }
}
