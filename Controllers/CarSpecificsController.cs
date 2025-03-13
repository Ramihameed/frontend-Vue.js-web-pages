using Microsoft.AspNetCore.Mvc;
using Test_3.Models;
using System.Collections.Generic;

namespace Test_3.Controllers
{
    using Microsoft.AspNetCore.Mvc;

    namespace Test_3.Controllers
    {
        public class CarsSpecificsController : Controller
        {
            public IActionResult Index()
            {
                // Create a list of cars to pass to the view
                var CarSpecifics = new List<CarSpecifics>
            {
                new CarSpecifics {name = "Toyota",type = "",  price = 2020 },
                new CarSpecifics {name = "Honda", type="", price = 2021 }
            };

                // Pass the list of cars to the view as JSON string
                return View(CarSpecifics);
            }
        }
    }

}
