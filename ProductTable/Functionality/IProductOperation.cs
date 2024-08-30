using ProductTable.Models;
namespace ProductTable.Functionality
{
    interface IProductOperation
{
    int AddProduct(Product products);
    int UpdateProduct(int id, string Name);
    int RemoveProduct(int id);
    List<Product> ProductList();//returns list of products
    Product SearchProductById(int id);// returns one row
}
}