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
       static List<Product> products = new List<Product>();
        Product product1 = new Product()
        {   Id = 1,
            Name = "Erikli 19L",
            Price = (decimal)10.5 };

        
        public ActionResult Index()
        {
            // crete an instance product
           

         //  products.Add(product1);
         

            //send product to the view engine

          
           
            return View( products);  
        }

        public ActionResult ProductList()
        {
            return View(products);
        }
        public ActionResult AddProduct()
        {
            //create an empty product
            Product product = new Product();
           //products.Add(product);
            return View(product);

        }

       [HttpPost]
        public ActionResult SaveProduct(Product product)
        {

           products.Add(product);
            return View(product);
        }

      public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult EditProduct(string name)
        {
            //   products.Add(product);
                 ViewBag.Message = "Your application description page.";
                   Product product = new Product();

                    foreach (var find in products)
                    {

                        if (find.Name == name)
                        {


                            product.Name = find.Name;
                            product.Price = find.Price;
                            product.Id = find.Id;
                   
                   
                    products.Remove(find);
                    break;
                        }
                    
                    }
                     return View(product);
        }
        [HttpGet]
        public ActionResult DeleteProduct(string name)
        {
            ViewBag.Message = "Your application description page.";
            foreach (var find in products)
            {

                if (find.Name == name)
                {
                    products.Remove(find);
                    break;
                }

            }
            return View(products);
        }
       
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}