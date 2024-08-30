using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UsermgmtS.models
{
    public class Product
    {
        public int ID { get; set; }
        
        public string ProductName { get; set; }
        public string ProductDescription { get; set; }
        public int ProductPrice { get; set; }

    }
}