using Microsoft.AspNetCore.Mvc;
using Test_3.Models;
using System.Collections.Generic;

namespace Test_3.Controllers
{
    public class WheelsController : Controller
    {
        // GET: Wheels

        private static List<wheels> _wheels = new List<wheels>
        {
            new wheels { id = 1, name = "Wheel A", pressure = 32 },
            new wheels { id = 2, name = "Wheel B", pressure = 30 }
        };


        public IActionResult Index()
        {
            // Sample data (this would typically come from a database)
            var wheelsList = new List<wheels>
            {
                new wheels { name = "Alloy Wheel", pressure = 32 , id = 0},
                new wheels { name = "Steel Wheel", pressure = 30, id = 1 },
                new wheels { name = "Chrome Wheel", pressure = 34 , id = 3}
            };

            return View(wheelsList); // Pass the list of wheels to the view
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            // Find the wheel by id
            var wheel = _wheels.FirstOrDefault(w => w.id == id);
            if (wheel == null)
            {
                return NotFound(); // Return 404 if not found
            }
            return View(wheel); // Pass the wheel model to the view
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, wheels updatedWheel)
        {
            // Validate if the model state is valid
            if (ModelState.IsValid)
            {
                // Find the wheel by id
                var wheel = _wheels.FirstOrDefault(w => w.id == id);
                if (wheel == null)
                {
                    return NotFound(); // Return 404 if the wheel is not found
                }

                // Update the wheel properties
                wheel.name = updatedWheel.name;
                wheel.pressure = updatedWheel.pressure;

                // After updating, redirect to the Index page (or another appropriate page)
                return RedirectToAction(nameof(Index));
            }

            // If model state is invalid, return the same view with the updated wheel
            return View(updatedWheel);
        }



    }
}
