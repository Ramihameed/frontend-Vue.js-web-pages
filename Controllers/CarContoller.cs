using Microsoft.AspNetCore.Mvc;
using Test_3.Models;
using System.Collections.Generic;

namespace Test_3.Controllers
{
    public class CarController : Controller
    {
        public IActionResult Index()
        {
            // Create a list of cars to pass to the view
            var cars = new List<cars>
            {
                new cars { Id = 1, name = "Toyota",  price = 2020 },
                new cars { Id = 2, name = "Honda", price = 2021 }
            };

            // Pass the list of cars to the view as JSON string
            return View(cars);
        }
    }
}
