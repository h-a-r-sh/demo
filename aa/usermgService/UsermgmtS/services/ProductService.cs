using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UsermgmtS.database;
using UsermgmtS.functionality;
using UsermgmtS.models;

namespace UsermgmtS.services
{
    public class ProductService : IProductService
    {   UserDbContext userDbContext;
        public ProductService()
        {
            userDbContext=new UserDbContext();
        }
        List<Product> IProductService.GetProduct()
        {
            var temp=userDbContext.products.ToList();
            return temp;
        }

        Product IProductService.GetProductById(int id)
        {
            var temp=userDbContext.products.Where(e=>e.ID==id).FirstOrDefault();
            return temp;
        }

        int IProductService.ProductAdd(Product product)
        {   
            var temp=userDbContext.products.Add(product);
            return userDbContext.SaveChanges();
        }

        int IProductService.ProductDelete(Product product)
        {
            var del=userDbContext.products.Where(e=>e.ID==product.ID).FirstOrDefault();
            var temp=userDbContext.products.Remove(del);
            return userDbContext.SaveChanges();
        }

        int IProductService.ProductUpdate(Product product)
        {
            var update=userDbContext.products.Where(e=>e.ID==product.ID).FirstOrDefault();
            update.ProductName=product.ProductName;
            update.ProductDescription=product.ProductDescription;
            update.ProductPrice=product.ProductPrice;
            return userDbContext.SaveChanges();
            
        }
    }
}