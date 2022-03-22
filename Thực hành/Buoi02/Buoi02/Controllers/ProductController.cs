using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Buoi02.Models;

namespace Buoi02.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product  

        public ActionResult GetProduct()        
        { 
            List<Product> products = new List<Product>();
            Product product = new Product();
            product.Id = 1;
            product.PriductName = "iphone X14";
            product.ProductType = "electric equiment";
            product.ProductPrice = "15000$";
            product.ProductImage = "~/image/iphone_14.png";
                

            products.Add(product);

            product = new Product();
            product.Id = 2;
            product.PriductName = "Dell XPS1 15 9510";
            product.ProductType = "electric equiment";
            product.ProductPrice = "35000$";
            product.ProductImage = string.Format("~/image/xps_15_9510.png");
            products.Add(product);

            product = new Product();
            product.Id = 3;
            product.PriductName = "Dell insprison 16";
            product.ProductType = "electric equiment";
            product.ProductPrice = "25000$";
            product.ProductImage = "~/image/dell_inspiron_16.png";
            products.Add(product);    
            
            ViewBag.Products = products;

            return View();
        }
    }
}