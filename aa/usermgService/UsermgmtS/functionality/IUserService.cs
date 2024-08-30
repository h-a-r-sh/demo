using System;
using UsermgmtS.models;

namespace UsermgmtS.functionality
{
    public interface IUserService
    {
        public int CreateAccount(User user);
        public int AccountValidate(string username,string password);
    }
}