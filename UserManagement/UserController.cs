using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using UserManagement.Functionality;
using UserManagement.Models;
using UserManagement.Service;

namespace UserManagement
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {
        IUserOperation uoperation;
        public UserController()
        {
            uoperation =new UserService();
        }
        [HttpPost("Signup")]
        public ActionResult CreateAccount(User user)
        {
            int temp= uoperation.CreateAccount(user);
            if(temp!=null)
            {
                return Ok(temp);
            }
            else
            {
            return Ok(0);
            }
        }
        [HttpPost("Login")]
        public ActionResult ValidateAccount(LoginDTO loginn)
        {
            int temp= uoperation.ValidateAccount(loginn.userName, loginn.passWord);
            if(temp!=null)
            {
                return Ok(temp);
            }
            else
            {
            return Ok(0);
            }
        }
    }
}