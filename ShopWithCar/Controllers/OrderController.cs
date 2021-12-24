using Microsoft.AspNetCore.Mvc;
using ShopWithCar.data.interfaces;
using ShopWithCar.data.Models;

namespace ShopWithCar.Controllers
{
    public class OrderController : Controller
    {
        private readonly IAllOrders _allOrders;
        private readonly ShopBasket _shopBasket;

        public OrderController(IAllOrders allOrders, ShopBasket shopBasket)
        {
            _allOrders = allOrders;
            _shopBasket = shopBasket;
        }

        public IActionResult Checkout()
        {
            _shopBasket.listShopItems = _shopBasket.getShopItems();
            if (_shopBasket.listShopItems.Count == 0)
            {
                //ModelState.AddModelError("", "You should have a car!");
               
                return RedirectToAction("Index" , "ShopBasket");
            }
            else
            {
                return View();
            }
           
        }

        [HttpPost]
        public IActionResult Checkout(Order order)
        {
            _shopBasket.listShopItems = _shopBasket.getShopItems();

            if (ModelState.IsValid)
            {
                _allOrders.createOrder(order);
                return RedirectToAction("Complete");
            }
            return View(order);
        }

        public IActionResult Complete()
        {

            ViewBag.Message = "Order processed succesfuly";
            return View();
        }
    }
}
