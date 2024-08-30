using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UsermgmtS.models;

namespace UsermgmtS.functionality
{
    public interface IProductService
    {
        int ProductAdd(Product product);
        int ProductUpdate(Product product);
        int ProductDelete(Product product);
        List<Product> GetProduct();
        Product GetProductById(int id);
    }
}