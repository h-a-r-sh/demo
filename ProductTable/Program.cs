using Microsoft.EntityFrameworkCore;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Security.Cryptography;
using System.Transactions;
using ProductTable.Models;
using ProductTable.Functionality;
using ProductTable.Services;



public class Controller
{
    public static void Main()
    {
        IProductOperation productoperation= new ProductOperation();

        // --------------- adding new record (disconnected architecture)
        Product obj= new Product();
        //obj.ProductName="ipad";
        //obj.ProductDescription="apple new gen ipad pro";
        //obj.ProductPrice=100000;
        //var temp=productoperation.AddProduct(obj);
        //if(temp==1)
        //{
        //    Console.WriteLine("record is saved");
        //}
        //else
        //{
        //    Console.WriteLine("record was not saved");
        //}
        //---------------- returning the product list
        // var res=productoperation.ProductList();
        // foreach(var t in res)
        // {
        //     Console.WriteLine("\n"+t.ProductID+" "+ t.ProductName+ " " + t.ProductDescription + " "+ t.ProductPrice);
        // }

        // ----------------- seaching the data using filter from the record
        var a = productoperation.SearchProductById(2);
        Console.WriteLine("\n" + a.ProductID + " " + a.ProductName + " " + a.ProductDescription + " " + a.ProductPrice);

        // // ------------------ Deleting a record by id
        // var r=productoperation.RemoveProduct(5);
        // if(r==1)
        // {
        //     Console.WriteLine("record is saved");
        // }
        // else
        // {
        //     Console.WriteLine("record was not saved");
        // }

        // // ------------------ updating a record
        // var update=productoperation.UpdateProduct(4,"Smart watch");
        // if(update==1)
        // {
        //     Console.WriteLine("Record is updated");
        // }
        // else
        // {
        //     Console.WriteLine("Record was not saved");
        // }

        // Remarks
        /*
        1. Uprofessional code(No structure, declaration and implementation should be separated)
        2. Strongly recommended to implement interface
        3.
        */
    }
}