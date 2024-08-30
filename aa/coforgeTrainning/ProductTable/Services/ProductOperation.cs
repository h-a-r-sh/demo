using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProductTable.Connections;
using ProductTable.Functionality;
using ProductTable.Models;

namespace ProductTable.Services
{
    public class ProductOperation:IProductOperation
    {
        ProductDbContext Context;
        public ProductOperation()
        {
            Context = new ProductDbContext();
        }
        int IProductOperation.AddProduct(Product product)
        {
            Context.products.Add(product);    //record added in local memory
            return Context.SaveChanges();   //commit to database

        }

        int IProductOperation.DeleteProduct(int ID)
        {
            var del = Context.products.Where(e => e.ID == ID).FirstOrDefault();
            Context.products.Remove(del);
            return Context.SaveChanges();
        }

        List<Product> IProductOperation.GetProduct()
        {
            var temp = Context.products.ToList();
            return temp;

        }

        Product IProductOperation.GetProductByID(int ID)
        {
            var result = Context.products.Where(e => e.ID == ID).FirstOrDefault();
            return result;
        }

        int IProductOperation.UpdateProduct(int ID, string name)
        {
            var re = Context.products.Where(e => e.ID == ID).FirstOrDefault();
            re.ProductName = name;
            Context.products.Update(re);
            return Context.SaveChanges();

        }
    }
}