using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using AspNetCoreWebService.Models;

namespace AspNetCoreWebService.Controllers
{
    public class HomeController : Controller
    {
        private IThanksgivingRepository repo;

        public HomeController(IThanksgivingRepository context)
        {
            repo = context;
        }
        [HttpGet]
        public IActionResult Index()
        {
            IQueryable<foods> food = repo.foods;
            ViewBag.FoodList = food;
            return View();
        }
        [HttpPost]
        public IActionResult Index(IFormCollection form)
        {
            string f = form["filterselect"];
            IQueryable<foods> food = repo.foods;
            if (f == "protein")
            {
                food = food.Where(x => x.protein);
            }
            else if (f == "side")
            {
                food = food.Where(x => x.side);
            }
            else if (f == "appetizer")
            {
                food = food.Where(x => x.appetizer);
            }
            else if(f == "condiment")
            {
                food = food.Where(x => x.condiment);
            }
            else if(f == "drink")
            {
                food = food.Where(x => x.drink);
            }
            else if (f == "dessert")
            {
                food = food.Where(x => x.dessert);
            }
            ViewBag.FoodList = food;
            ViewBag.Selected = f;
            return View();
        }

    }
}
