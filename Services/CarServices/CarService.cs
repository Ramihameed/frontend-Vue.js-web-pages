using Microsoft.AspNetCore.Cors.Infrastructure;
using Test_3.Controllers;
using Test_3.Data;
using Test_3.Models;
using Test_3.ViewModel.Cars; // Assuming the car model is defined here

namespace Test_3.Services.CarServices
{
    public class CarService : ICarService
    {
        private readonly ApplicationDbContext _dbContext;
        public CarService(ApplicationDbContext context)
        {
            _dbContext = context;
        }
        public async Task Create(List<CarsVM> modelList)
        {
            if (modelList == null || !modelList.Any())
            {
                throw new ArgumentException("The list of cars cannot be empty.");
            }

            try
            {
                // Convert CarsVM to cars entity
                var carsToAdd = modelList.Select(item => new cars
                {
                    name = item.name,
                    price = item.price
                }).ToList();

                // Add all the cars in one batch
                _dbContext.cars.AddRange(carsToAdd);

                // Save all changes at once
                await _dbContext.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                // Log the exception (use proper logging here)
                // _logger.LogError(ex, "Error while adding cars to the database.");
                throw new InvalidOperationException("An error occurred while saving cars.", ex);
            }
        }


        public async Task deleteCar(int carId)
        {
            throw new NotImplementedException();
        }

        public async Task<List<cars>> getAllCars()
        {
            throw new NotImplementedException();
        }

        public async Task<cars> getCarById(int id)
        {
            
            return await _dbContext.cars.FindAsync(id);

        }

        public Task updateCar(List<CarsVM> updatedCar)
        {
            throw new NotImplementedException();
        }
    }


     

        // Adds a car to the database





    }

