using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UserManagement.Models;

namespace UserManagement.Functionality
{
    public interface IProductOperation
    {
        public int AddProduct(Product product);

        public int UpdateProduct(int id, string Name, string des, int price);

        public List<Product> ShowProduct();

        public int DeleteProcduct(int id);
    }
}