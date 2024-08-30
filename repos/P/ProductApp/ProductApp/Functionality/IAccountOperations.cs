using ProductApp.Models;

namespace ProductApp.Functionality
{
    public interface IAccountOperations
    {
        int AccountCreate(Account account);
        int AccountValidation(string username, string password);
    }
}
