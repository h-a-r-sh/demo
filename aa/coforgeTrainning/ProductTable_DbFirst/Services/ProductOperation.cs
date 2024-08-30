using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProductTable.Functionality;
using ProductTable_DbFirst.Models;


namespace ProductTable.Services
{
    public class ProductOperation:IProductOperation
    {
        CoforgeDbContext Context;
        public ProductOperation()
        {
            Context = new CoforgeDbContext();
        }
        int IProductOperation.AddProduct(Product product)
        {
            Context.Products.Add(product);    //record added in local memory
            return Context.SaveChanges();   //commit to database

        }

        int IProductOperation.DeleteProduct(int ID)
        {
            var del = Context.Products.Where(e => e.Id == ID).FirstOrDefault();
            Context.Products.Remove(del);
            return Context.SaveChanges();
        }

        List<Product> IProductOperation.GetProduct()
        {
            var temp = Context.Products.ToList();
            return temp;

        }

        Product IProductOperation.GetProductByID(int ID)
        {
            var result = Context.Products.Where(e => e.Id == ID).FirstOrDefault();
            return result;
        }

        int IProductOperation.UpdateProduct(int ID, string name)
        {
            var re = Context.Products.Where(e => e.Id == ID).FirstOrDefault();
            re.ProductName = name;
            Context.Products.Update(re);
            return Context.SaveChanges();

        }
    }
}