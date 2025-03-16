
using Test_3.Data;

namespace Test_3.Services.CarServices
{
    public class CarService<T>: ICarService<T> where T : class
    {
        private List<cars> _carsList = new List<cars>();


        private readonly ApplicationDbContext _context;

        public CarService(ApplicationDbContext context)
        {
            _context = context;
        }
        public void addCar(int carId, string name, int price)
        {
            // Create a new car object and assign the values
            cars newCar = new cars
            {
                Id = carId,
                name = name,
                price = price
            };

            // Add the car to the in-memory list
            _carsList.Add(newCar);
        }

        // Other methods (getCarById, getAllCars, etc.) will go here


        public cars getCarById(int carId)
        {
            throw new NotImplementedException();
        }

        public List<cars> getAllCars()
        {
            return _context.cars.ToList();
        }

        public void updateCar(int carId, cars updatedCar)
        {
            throw new NotImplementedException();
        }

        public void deleteCar(int carId)
        {
            throw new NotImplementedException();
        }
    }
}
