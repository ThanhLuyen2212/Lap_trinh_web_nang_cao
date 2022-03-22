using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Buoi02.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string PriductName { get; set; }    
        public string ProductType { get; set; }
        public string ProductPrice { get; set; }

        public string ProductImage { get; set; }

        public Product() { }
    }
}