using Microsoft.AspNetCore.Mvc;
using Test_3.Models;
using System.Collections.Generic;
using Test_3.Services.CarServices;
using Test_3.ViewModel.Cars;
namespace Test_3.Controllers;

public class CarController : Controller
{
    private readonly ICarService _carService;

    public CarController(ICarService carService)
    {
        this._carService = carService;
    }
    public IActionResult Index()
    {
        return View();
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
    public async Task<IActionResult> postCars([FromBody] List<cars> carsss)
    {
        if (carsss == null)
        {
            return  BadRequest("No cars provided.");
        }

        return Ok(carsss);
    }

    [HttpPost]
    public async Task<IActionResult> Create([FromBody] List<CarsVM> modelList)
    {
        if (modelList == null || !modelList.Any())
        {
            return BadRequest("The list of cars cannot be empty.");
        }

        try
        {
            await _carService.Create(modelList);
            return Ok("Success");
        }
        catch (Exception ex)
        {
            return StatusCode(500, "Internal server error. Please try again later.");
        }
    }


    [HttpPost]
    public async Task<IActionResult> Update([FromBody] List<CarsVM> modelList)
    {
        await _carService.updateCar(modelList);

        return Ok("susess");

    }

    [HttpPost]
    public async Task<IActionResult> find([FromBody] int id)
    {
        var car = await _carService.getCarById(id);
        if (car == null)
        {
            return NotFound("Car not found");
        }
        return Ok(car);
    }


}
