using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Lab2.Controllers
{
    public class CategoriesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        //- Each category links to /categories/details and passes the category name as a link parameter In your controller, add a function called Details that accepts 1 string parameter.This method sends back a string to the view using the ViewBag that says "You selected category: [paramater-value-here]"
        public IActionResult Details(string category)
        {
            ViewBag.category = category;
            return View();
        } 
    }
}
