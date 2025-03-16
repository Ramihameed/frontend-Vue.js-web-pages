namespace Test_3.Services.CarServices
{
    public interface ICarService<T> where T : class
    {

        // Create: Add a new car
        void addCar(int carId, string name, int price);

        // Read: Get a car by its ID
        cars getCarById(int carId);

            // Read: Get all cars
            List<cars> getAllCars();

            // Update: Update car details
            void updateCar(int carId, cars updatedCar);

            // Delete: Remove a car by its ID
            void deleteCar(int carId);
        }

    }
