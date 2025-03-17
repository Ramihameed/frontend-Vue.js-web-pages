using Test_3.ViewModel.Cars;

namespace Test_3.Services.CarServices
{
    public interface ICarService
    {

         Task<cars> getCarById(int id);

         Task<List<cars>> getAllCars();

         Task Create(List<CarsVM> modelList);
         Task updateCar(List<CarsVM> updatedCar);
         Task deleteCar(int carId);
    }

}
