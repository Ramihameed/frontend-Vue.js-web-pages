using Microsoft.AspNetCore.Mvc;
using Test_3.Models;
using System.Collections.Generic;
using Test_3.Services.CarServices;
using Test_3.Data;

namespace Test_3.Controllers
{
    public class WheelsController : Controller
    {
        private readonly ICarService _wheels;
        private readonly ApplicationDbContext _context;
        public WheelsController(ICarService wheelss, ApplicationDbContext test)
        {
            this._wheels = wheelss;
            this._context= test;
        }
        public IActionResult Index()
        {
            // Sample data (this would typically come from a database)
            var wheelsList = new List<wheels>
            {
                new wheels { id = 0, name = "Alloy Wheel", pressure = 32 },
                new wheels { id = 1, name = "Steel Wheel", pressure = 30 },
                new wheels {  id = 3, name = "Chrome Wheel", pressure = 34 }
            };

            return View(wheelsList); // Pass the list of wheels to the view
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var wheeltoedit = _context.wheels.FirstOrDefault(w => w.id == id);
            if (wheeltoedit == null)
            {
                return NotFound(); // Return 404 if wheel not found
            }

            return View(wheeltoedit); // Pass the wheel object to the view
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, wheels updatedWheel)
        {
            // Check if the model is valid
            if (ModelState.IsValid)
            {
                var wheelToEdit = _context.wheels.FirstOrDefault(w => w.id == id);
                if (wheelToEdit == null)
                {
                    return NotFound(); // Return 404 if wheel not found
                }

                // Update the wheel properties with the new values
                wheelToEdit.name = updatedWheel.name;
                wheelToEdit.pressure = updatedWheel.pressure;

                // Save the changes to the database
                _context.SaveChanges();

                // Redirect to the Index or another page after successful update
                return RedirectToAction("Index");
            }

            // If the model state is invalid, return the view with the updated wheel
            return View(updatedWheel);
        }




    }
}
