using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using System.Globalization;
using Arnaud.Models;

namespace Arnaud.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index(string searchCriteria)
        {
            var factory = new ShopFactory();
            IQueryable<Product> prods = factory.Products.OrderBy(p => p.Name); //list of products where we can use Query
            if(searchCriteria != null)
            {
                //if we have a string, we'll go through the products and pick the ones where the search string can be found in the name
                prods = prods.Where(p => p.Name.Contains(searchCriteria)); 
            }

            var products = prods.Take(10).ToList();
            return View(products);
        }

        //product details
        public ActionResult Details(int id) //details view. right click on ActionResult - new model
        {
            var factory = new ShopFactory();
            var found = factory.Products.Where(p => p.ID == id).FirstOrDefault(); //db, table
            return View(found); //a list called found
        }

        public ActionResult About()
        {
            ViewBag.Message = "Read more about our products";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Contact us";

            return View();
        }

    }
}