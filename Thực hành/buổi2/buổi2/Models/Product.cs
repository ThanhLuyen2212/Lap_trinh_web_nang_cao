using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace buổi2.Models
{
    public class Product
    {
        public int Id { get; set; } 
        public string ProductName { get; set; }
        public string ProductType { get; set; }
        public string ProductPrice { get; set; }
        public string ProductImage { get; set; }
        public Product() { }
    }
}