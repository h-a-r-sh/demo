using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UsermgmtS.models
{
    public class User
    {
        public int ID { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public int Age { get; set; }
        public long PhoneNo { get; set; }
    }
}