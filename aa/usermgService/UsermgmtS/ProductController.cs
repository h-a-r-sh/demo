using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using UsermgmtS.functionality;
using UsermgmtS.models;
using UsermgmtS.services;

namespace UsermgmtS
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductController : ControllerBase
    {
        IProductService productService;
        public ProductController()
        {
            productService =new ProductService();            
        }

        [HttpPost ("AddProduct")]
        public ActionResult ProductAdd(Product product)
        {
            var temp=productService.ProductAdd(product);
        
            return Ok(temp);
        }

        [HttpPost ("DeleteProduct")]
        public ActionResult ProductDelete(Product product)
        {
            var temp=productService.ProductDelete(product);
            
            return Ok(temp);
        }

         [HttpPut ("ProductUpdated")]
        public ActionResult ProductUpdate(Product product)
        {
            int value = productService.ProductUpdate(product);
            return Ok(value);
        }
        
        
        [HttpGet("GetProduct")]
        public ActionResult GetProduct()
        {
            // string msg = "Product not deleted";
            var value = productService.GetProduct();
            return Ok(value);
        }



        [HttpGet ("GetProductById/{id}")]
        public ActionResult GetProductById(int id)
        {
            var value = productService.GetProductById(id);
            return Ok(value);
        }
        
        
    }
}