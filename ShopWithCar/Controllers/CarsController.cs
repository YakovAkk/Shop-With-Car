using Microsoft.AspNetCore.Mvc;
using ShopWithCar.data.interfaces;
using ShopWithCar.data.Models;
using ShopWithCar.VievModels;

namespace ShopWithCar.data
{
    public class CarsController : Controller
    {
        private readonly IAllCars _allCars;

        private readonly ICarsCategory _carsCategory;

        public CarsController(IAllCars allCars, ICarsCategory carsCategory)
        {
            _allCars = allCars;
            _carsCategory = carsCategory;
        }

        [Route("Cars/List")]
        [Route("Cars/List/{category}")]
        public ViewResult List(string category)
        {
            string categ = category;
            IEnumerable<Car> cars = null;
            string currCategory = "";

            if (string.IsNullOrEmpty(category))
            {
                cars = _allCars.cars.OrderBy(c => c.id);
            }
            else if (string.Equals("electro" , category,StringComparison.OrdinalIgnoreCase))
            {
                cars = _allCars.cars.Where(c => c.categoryID == 1);
                currCategory = "Electro Cars";
            }
            else if (string.Equals("fuel", category, StringComparison.OrdinalIgnoreCase))
            {
                cars = _allCars.cars.Where(c => c.categoryID == 2);
                currCategory = "Simple Cars";
            }


            var carObj = new CarsListViewModel
            {
                allCars = cars,
                carCategory = currCategory
                
            };

            ViewBag.Title = "Page with cars";
            
            return View(carObj);
        }
    }
}
