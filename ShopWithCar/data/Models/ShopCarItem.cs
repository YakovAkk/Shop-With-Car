namespace ShopWithCar.data.Models
{
    public class ShopCarItem
    {
        public int id { get; set; } 
        public Car car { get; set; }
        public ulong price { get; set; }

        public string ShopCarId { get; set; }
    }
}
