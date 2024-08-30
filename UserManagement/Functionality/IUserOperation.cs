using System;
using UserManagement.Models;

namespace UserManagement.Functionality
{
    public interface IUserOperation
    {
        public int CreateAccount(User user);

        public int ValidateAccount(string username, string password);

        
    }
}