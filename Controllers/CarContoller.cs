using Microsoft.AspNetCore.Mvc;
using Test_3.Models;
using System.Collections.Generic;
using Test_3.Services.CarServices;
namespace Test_3.Controllers;

public class CarController : Controller
{
    private readonly CarService<cars> _carService;

    public CarController(CarService<cars> carService)
    {
        this._carService = carService;
    }
    public IActionResult Index()
    {
        // Create a list of cars to pass to the view
        var cars = new List<cars>
{
    new cars { Id = 0, name = "name", price = 0 },
    new cars { Id = 1, name = "Car1", price = 10000 },
    new cars { Id = 2, name = "Car2", price = 20000 }
};

        // Pass the list of cars to the view
        return View(cars);
    }


    [HttpGet]
    public IActionResult getAllCar()
    {
        // Create a list of cars to pass to the view
        var cars = new List<cars>
        {
            new cars { Id = 781, name = "Toyota",  price = 2020 },
            new cars { Id = 2, name = "Honda", price = 2021 }
        };

        // Pass the list of cars to the view as JSON string
        return Ok(cars);
    }

    [HttpPost]
    public IActionResult postCars([FromBody] List<cars> carsss)
    {
        if (carsss == null)
        {
            return BadRequest("No cars provided.");
        }

        return Ok(carsss);
    }


}
