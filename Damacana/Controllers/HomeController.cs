using Damacana.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace Damacana.Controllers
{
    
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            // crete an instance product
            Product product1 = new Product();
            
                product1.Id = 1;
                product1.Name = "Erikli 19L";
                product1.Price = (decimal)10.5;
            
       
           

           Product product2 = new Product();

            product2.Id = 2;
            product2.Name = "Erikli 5L";
            product2.Price = (decimal)5.5;


            //send product to the view engine
            List<Product> products = new List<Product>();
            products.Add(product1);
            products.Add(product2);

            return View( products);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}