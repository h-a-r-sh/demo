

using ProductTable_DbFirst.Models;

namespace ProductTable.Functionality
{
    public interface IProductOperation
    {
        int AddProduct(Product product);
        int UpdateProduct(int ID, string name);
        int DeleteProduct(int ID);
        List<Product> GetProduct();
        Product GetProductByID(int ID);
    }
}