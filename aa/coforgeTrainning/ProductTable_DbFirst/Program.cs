using ProductTable_DbFirst.Models;

class Controller
{
    public static void Main()
    {
        CoforgeDbContext coforgeDbContext=new CoforgeDbContext();
        var res=coforgeDbContext.Products.ToList();
        foreach (var item in res)
        {
            Console.WriteLine(item.Id+" "+item.ProductName+" "+item.ProductPrice+" "+item.ProductDetails);
        }
        // Product product=new Product();
        // product.ProductName="Kuch naya";
        // product.ProductPrice=400;
        // product.ProductDetails="Kuch to hee";
        // coforgeDbContext.Products.Add(product);
        // coforgeDbContext.SaveChanges();
    }
}