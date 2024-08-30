using MVCPractice.Models;

namespace MVCPractice.Functionality
{
    public interface IAccountServices
    {
        public int AccountCreate(User user);

        public int AccountLogin(string username,string password);
    }
}
