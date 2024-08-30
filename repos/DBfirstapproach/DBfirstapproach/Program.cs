using DBfirstapproach.Models;
using System.Runtime.CompilerServices;

public interface IProductOperation
{
    int AddProduct(Product product);
    int UpdateProduct(int ID, string name);
    int DeleteProduct(int ID);
    List<Product> GetProduct();
    Product GetProductByID(int ID);
}

public class ProductOperation : IProductOperation
{
    CoforgeDbContext coforgeDbContext;
    public ProductOperation()
    {
        coforgeDbContext= new CoforgeDbContext();
    }
    int IProductOperation.AddProduct(Product product)
    {
        coforgeDbContext.Products.Add(product);    //record added in local memory
        return coforgeDbContext.SaveChanges();   //commit to database

    }

    int IProductOperation.DeleteProduct(int ID)
    {
        var del = coforgeDbContext.Products.Where(e => e.Id == ID).FirstOrDefault();
        coforgeDbContext.Products.Remove(del);
        return coforgeDbContext.SaveChanges();
    }

    List<Product> IProductOperation.GetProduct()
    {
        var temp = coforgeDbContext.Products.ToList();
        return temp;

    }

    Product IProductOperation.GetProductByID(int ID)
    {
        var result = coforgeDbContext.Products.Where(e => e.Id == ID).FirstOrDefault();
        return result;
    }

    int IProductOperation.UpdateProduct(int ID, string name)
    {
        var re = coforgeDbContext.Products.Where(e => e.Id == ID).FirstOrDefault();
        re.ProductName = name;
        coforgeDbContext.Products.Update(re);
        return coforgeDbContext.SaveChanges();

    }
}

class Controller
{
    public static void Main()
    {
        
        IProductOperation productOperation = new ProductOperation();
        
        // // add record in Database
        // Product product = new Product();
        // product.ProductName = "AC";
        // product.ProductPrice = 300;
        // product.ProductDetails = "Nice";
        // var temp =productOperation.AddProduct(product);
        // if(temp==1){
        //     Console.WriteLine("Record is saved");
        // }


        // search record 
        var res = productOperation.GetProduct();
        foreach (var i in res)
        {
            Console.WriteLine(i.Id + " " + i.ProductName + " " + i.ProductPrice + " " + i.ProductDetails);

        }


        // //searching for result by ID
        // var result=productOperation.GetProductByID(2);
        // Console.WriteLine(result.Id + " " + result.ProductName + " " + result.ProductPrice + " " + result.ProductDetails);


        // //Deleting A record By ID
        // var deleted =productOperation.DeleteProduct(2);
        // if(deleted==1){
        //     Console.WriteLine("Record is Deleted");
        // }


        // // update records
        // var update =productOperation.UpdateProduct(3,"coolerrrr");
        // if(update==1){
        //     Console.WriteLine("Record is updated");
        // }
    }
}