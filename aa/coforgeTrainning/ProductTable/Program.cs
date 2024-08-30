//Implementing ORM principle with code first approach
//This class will convert to table
using Microsoft.EntityFrameworkCore;
using ProductTable.Functionality;
using ProductTable.Models;
using ProductTable.Services;




// public class ProductDbContext : DbContext
//     {
//         protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
//         {
//             optionsBuilder.UseSqlServer("Data Source=DESKTOP-DE69VTH\\SQLSERVER;Initial Catalog=CoforgeDb;integrated security=true;multipleactiveresultsets=True;Encrypt=False");
//         }
//         public DbSet<Product> products { get; set; }  //product will be table name
//     }


public class Controller
{
    public static void Main()
    {
        IProductOperation productOperation=new ProductOperation();
        
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
            Console.WriteLine(i.ID + " " + i.ProductName + " " + i.ProductPrice + " " + i.ProductDetails);

        }
        

        // // //searching for result by ID
        // var result=productOperation.GetProductByID(2);
        // Console.WriteLine(result.ID + " " + result.ProductName + " " + result.ProductPrice + " " + result.ProductDetails);

        //Deleting A record By ID
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