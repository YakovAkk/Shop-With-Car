using Microsoft.AspNetCore.Mvc;
using ShopWithCar.data.interfaces;
using ShopWithCar.ViewModels;

namespace ShopWithCar.Controllers
{
    public class HomeController : Controller
    {
        private readonly IAllCars _allCars;

        public HomeController(IAllCars allCars)
        {
            _allCars = allCars;

        }

        public ViewResult Index()
        {
            var homeCars = new HomeViewModel
            {
                favCars = _allCars.getFavoriteCar
            };

            var a = homeCars.favCars.ToList();
            return View(homeCars);
        }


    }
}
