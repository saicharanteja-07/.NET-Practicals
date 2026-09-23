using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Practical6.Models
{
    public class Product
    {
        public int ProductID { get; set; }

        public string ProductName { get; set; }

        public string Category { get; set; }

        public double Price { get; set; }

        public string Imageurl { get; set; }
    }
}