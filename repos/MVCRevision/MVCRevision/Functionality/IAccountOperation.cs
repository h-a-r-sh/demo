using MVCRevision.Models;

namespace MVCRevision.Functionality
{
    public interface IAccountOperation
    {
        public int createAccount(Account account);
        public int AccountValidation(String username,String Password);
        
        
    }
}
