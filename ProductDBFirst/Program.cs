using Microsoft.EntityFrameworkCore;
using System;
using ProductDBFirst.Models;

public class Controller
{
    public static void Main()
    {
        CoforgeDbContext coforgeDbContext=new CoforgeDbContext();
        Product pro=new Product();
        pro.ProductName="Electrio rc car";
        pro.ProductDescription="Kuch toh hai";
        pro.ProductPrice=4500000;
        coforgeDbContext.Products.Add(pro);
        coforgeDbContext.SaveChanges();
        var res=coforgeDbContext.Products.ToList();
        foreach(var item in res)
        {
            Console.WriteLine(item.ProductId+" "+item.ProductName+" "+item.ProductDescription+" "+item.ProductPrice);
        }
        
    }

}