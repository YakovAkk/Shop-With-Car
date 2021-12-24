


using System.Collections.Generic;
using ShopWithCar.data.Models;

namespace ShopWithCar.VievModels
{
    public class CarsListViewModel
    {
        public IEnumerable<Car> allCars { get; set; }    
        public string carCategory { get; set; } 

    }
}
