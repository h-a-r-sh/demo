using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UserManagement.Database;
using UserManagement.Functionality;
using UserManagement.Models;

namespace UserManagement.Service
{
    public class ProductServices : IProductOperation
    {
        UserDbContext pdbContext;
        public ProductServices()
        {
            pdbContext = new UserDbContext();
        }
        int IProductOperation.AddProduct(Product product)
        {
            pdbContext.Products.Add(product);
            return pdbContext.SaveChanges();
        }

        int IProductOperation.DeleteProcduct(int id)
        {
            var del=pdbContext.Products.Where(d=> d.ID==id).FirstOrDefault();
            pdbContext.Products.Remove(del);
            return pdbContext.SaveChanges();
        }

        List<Product> IProductOperation.ShowProduct()
        {
            var temp=pdbContext.Products.ToList();
            return temp;
        }

        int IProductOperation.UpdateProduct(int id, string Name, string des, int price)
        {
            var up=pdbContext.Products.Where(d=> d.ID==id).FirstOrDefault();
            up.ProductName=Name;
            up.ProductDescription=des;
            up.ProductPrice=price;
            return pdbContext.SaveChanges();
        }
    }
}