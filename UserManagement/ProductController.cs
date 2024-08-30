using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using UserManagement.Functionality;
using UserManagement.Models;
using UserManagement.Service;

namespace UserManagement
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductController : ControllerBase
    {
        IProductOperation productOperation;
        public ProductController()
        {
            productOperation=new ProductServices();
        }

        [HttpPost("Add_Product")]
        public ActionResult ProductAdd(Product product)
        {
            string msg="";
            var temp=productOperation.AddProduct(product);
            if(temp>0)
            {
                msg="Product Added";
            }
            return Ok(msg);
        }

        [HttpPost("ProductUpdated")]
        public ActionResult ProductUpdate(int id,string name, int price, string desc)
        {
            string msg = "Product not updated,Wrong ID";
            int value = productOperation.UpdateProduct(id,name,desc,price);
            if(value > 0){
                msg = "Product Updated!!!";
            }
            return Ok(msg);
        }
        [HttpPost("ProductDeleted")]
        public ActionResult ProductDelete(int id)
        {
            string msg = "Product not deleted";
            int value = productOperation.DeleteProcduct(id);
            if(value > 0)
            {
                msg = "Product Deleted!!!";
            }
            return Ok(msg);
        }

        [HttpGet("GetProduct")]
        public ActionResult GetProduct()
        {
            // string msg = "Product not deleted";
            var value = productOperation.ShowProduct();
            if(value == null){
                return null;
            }
            return Ok(value);
        }
    }
}