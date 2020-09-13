using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
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
        
            public ActionResult Movie()
        {
            var movie = new Movies() { Name = "Shrek!" };
            var movie2 = new Movies() { Name = "OldGuard" };

            ViewData["Movies"] = movie2;


            var customers = new List<Customer> { 
                new Customer { Name = "Mr Abayomi"},
                new Customer { Name = "Mr Olayinka"}
            };

            var viewModel = new RandomMovieViewModel()
            {
                Customers = customers,
                Movies = movie
            }; 
            
            //An instance of RandomMovieViewModel is passed to the view method
            return View(viewModel);
        }
    }
}