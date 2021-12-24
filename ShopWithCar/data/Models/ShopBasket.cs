using Microsoft.EntityFrameworkCore;
using ShopWithCar.Data;

namespace ShopWithCar.data.Models
{
    public class ShopBasket
    {
        private readonly AppDBContent dBContent;

        public ShopBasket(AppDBContent dBContent)
        {
            this.dBContent = dBContent;
        }
        public string Id { get; set; }
        public List<ShopCarItem> listShopItems { get; set; } 

        public static ShopBasket getCard(IServiceProvider service) 
        {
            ISession session = service.GetRequiredService<IHttpContextAccessor>()?.HttpContext.Session;
            session.SetString("Id", Guid.NewGuid().ToString());

            var context = service.GetService<AppDBContent>();

            string shopBasketId = session.GetString("Id") ?? Guid.NewGuid().ToString();
            
          

            session.SetString("Id", shopBasketId);
            return new ShopBasket(context) { Id = shopBasketId };
        }

        public void AddToBasket(Car car)
        {
            dBContent.ShopCarItems.Add(new ShopCarItem
            {
                ShopCarId = Id,
                car = car,
                price = car.price
            });
            dBContent.SaveChanges();
        }

        public List<ShopCarItem> getShopItems()
        {
            return dBContent.ShopCarItems.Where(i => i.ShopCarId == Id).Include(s => s.car).ToList();
        }
    }
}
