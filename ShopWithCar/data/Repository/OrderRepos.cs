using ShopWithCar.data.interfaces;
using ShopWithCar.data.Models;
using ShopWithCar.Data;

namespace ShopWithCar.data.Repository
{
    public class OrderRepos : IAllOrders
    {
        private readonly AppDBContent _appDBContent;
        private readonly ShopBasket _shopBasket;

        public OrderRepos(AppDBContent appDBContent, ShopBasket shopBasket)
        {
            _appDBContent = appDBContent;
            _shopBasket = shopBasket;
        }

        public void createOrder(Order order)
        {
           order.orderTime = DateTime.Now;
           _appDBContent.Orders.Add(order);
           _appDBContent.SaveChanges();
            var items = _shopBasket.listShopItems;
           
            foreach (var el in items)
            {
                var orderDetail = new OrderDetail
                {
                    carID = el.car.id,
                    orderID = order.id,
                    price = el.car.price
                };
                _appDBContent.OrderDetails.Add(orderDetail);
            }
            _appDBContent.SaveChanges();

        }
    }
}
