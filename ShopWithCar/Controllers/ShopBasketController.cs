using Microsoft.AspNetCore.Mvc;
using ShopWithCar.data.interfaces;
using ShopWithCar.data.Models;
using ShopWithCar.VievModels;

namespace ShopWithCar.Controllers
{
    public class ShopBasketController : Controller
    {
        private readonly IAllCars _carRepos;
        private readonly ShopBasket _shopBasket;

        public ShopBasketController(IAllCars carRep, ShopBasket shopBasket)
        {
            _carRepos = carRep;
            _shopBasket = shopBasket;
        }

        public ViewResult Index()
        {
            var items = _shopBasket.getShopItems();
            _shopBasket.listShopItems = items;

            var obj = new ShopBasketViewModel
            {
                shopBasket = _shopBasket
            };

            return View(obj);
        }

        public RedirectToActionResult addToBasket(int id)
        {
            var item = _carRepos.cars.FirstOrDefault(x => x.id == id); 
            if (item != null)
            {
                _shopBasket .AddToBasket(item);
            }
            return RedirectToAction("Index");
        }
    }
}
