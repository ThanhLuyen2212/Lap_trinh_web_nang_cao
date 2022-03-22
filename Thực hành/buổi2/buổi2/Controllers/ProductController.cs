using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using buổi2.Models;

namespace buổi2.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        public ActionResult GetProduct()
        {
            List<Product> products = new List<Product>();
            Product product = new Product();
            product.Id = 1;
            product.ProductName = "Iphone 14";
            product.ProductPrice = "40.000.000 VND";
            product.ProductType = "Electri equipment";
            product.ProductImage = Url.Content(@"~\Image\iphone_14.png"); 
            products.Add(product);

            product = new Product();
            product.Id = 2;
            product.ProductName = "xps 15 9510";
            product.ProductPrice = "65.000.000 VND";
            product.ProductType = "Electri equipment";
            product.ProductImage = Url.Content(@"~\Image\xps_15_9510.png");
            products.Add(product);

            product = new Product();
            product.Id = 1;
            product.ProductName = "dell inspiron 16";
            product.ProductPrice = "100.000.000 VND";
            product.ProductType = "Electri equipment";
            product.ProductImage = Url.Content(@"~\Image\dell_inspiron_16.png");
            products.Add(product);
            
            ViewBag.Products = products;                  

            return View();
        }
    }
}