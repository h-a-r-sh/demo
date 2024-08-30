using System;
using Microsoft.AspNetCore.Mvc;
using UsermgmtS.functionality;
using UsermgmtS.models;
using UsermgmtS.services;

namespace UsermgmtS
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {   IUserService userService;
        public UserController()
        {
            userService=new UserService();
        }
        [HttpPost("CreateUser")]
        public ActionResult CreateUser(User user)
        {   
            string mssg="";
            int temp =userService.CreateAccount(user);
            if(temp>0)
            {
                return Ok(temp);
            }
            return Ok(temp);
        }
        [HttpPost("Login")]
        public ActionResult ValidateUser(LoginDTO loginDTO)
        {   
            
            int temp =userService.AccountValidate(loginDTO.username,loginDTO.password);
            if(temp>0)
            {
                return Ok(temp);
            }
            return Ok(temp);
        }
    }
}