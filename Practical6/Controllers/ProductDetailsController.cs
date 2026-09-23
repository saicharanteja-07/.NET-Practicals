using Practical6.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Practical6.Controllers
{
    public class ProductDetailsController : Controller
    {
        public ActionResult Index()
        {
            List<Product> P = GetProduct();

            return View("Product", P);
        }

        public ActionResult Details(int id)
        {
            List<Product> P = GetProduct();
            Product selectedProduct = P.FirstOrDefault(x => x.ProductID == id);
            return View(selectedProduct);
        }
        
        private List<Product> GetProduct()
        {
            List<Product> P = new List<Product>();

            Product p1 = new Product();
            p1.ProductID = 101;
            p1.ProductName = "Mobile";
            p1.Category = "Mobile";
            p1.Price = 10000;
            p1.Imageurl = "https://loremflickr.com/150/150/mobile";

            Product p2 = new Product();
            p2.ProductID = 102;
            p2.ProductName = "Laptop";
            p2.Category = "Electronics";
            p2.Price = 65000;
            p2.Imageurl = "https://loremflickr.com/150/150/laptop";

            Product p3 = new Product();
            p3.ProductID = 103;
            p3.ProductName = "HeadPhones";
            p3.Category = "Accessories";
            p3.Price = 1500;
            p3.Imageurl = "https://loremflickr.com/150/150/headphones";

            P.Add(p1);
            P.Add(p2);
            P.Add(p3);

            return P;
        }
    }
}