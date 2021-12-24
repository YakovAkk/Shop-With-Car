using Microsoft.EntityFrameworkCore;
using ShopWithCar.data.interfaces;
using ShopWithCar.data.Models;
using ShopWithCar.Data;


namespace ShopWithCar.data.Repository
{
    public class CarRepos : IAllCars
    {
        private readonly AppDBContent dBContent;

        public CarRepos(AppDBContent dBContent)
        {
            this.dBContent = dBContent; 
        }
        public IEnumerable<Car> cars => dBContent.Cars.Include(c => c.Category);

        public IEnumerable<Car> getFavoriteCar => dBContent.Cars.Where(c => c.isFavorite).Include(c => c.Category);
 
        public IEnumerable<Car> get()
        {
            var a = dBContent.Cars.Where(c => c.isFavorite).Include(c => c.Category);
            return a;
        }

        public Car getObjectCar(int carID)
        {
            return dBContent.Cars.FirstOrDefault(p => p.id == carID);
        }
    }
}
