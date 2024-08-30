using ProductTable.Connection;
using ProductTable.Functionality;
using ProductTable.Models;

namespace ProductTable.Services
{
    public class ProductOperation : IProductOperation
{
    ProductDbContext context;
    public ProductOperation()
    {
        context=new ProductDbContext();
    }
    int IProductOperation.AddProduct(Product products)
    {
        context.products.Add(products); // new record is added to local memory
        return context.SaveChanges(); // commit to database
    }

    List<Product> IProductOperation.ProductList()
    {
        var result=context.products.ToList();
        return result;
    }

    int IProductOperation.RemoveProduct(int id)
    {
        var del = context.products.Find(id); // takes id by default
        context.products.Remove(del);
        return context.SaveChanges();
    }

    Product IProductOperation.SearchProductById(int id)
    {
        var fetch= context.products.Where(t=> t.ProductID==id).FirstOrDefault();
        return fetch;
    }

    int IProductOperation.UpdateProduct(int id, string Name)
    {
        var s=context.products.Where(a=> a.ProductID==id).FirstOrDefault();
        s.ProductName=Name;
        // var u= context.products.Update(s);
        return context.SaveChanges();
    }
}
}