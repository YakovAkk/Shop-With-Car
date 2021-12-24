namespace ShopWithCar.data.Models
{
    public class OrderDetail
    {
        public int id { get; set; }
        public int orderID { get; set; }
        public int carID { get; set; }
        public ulong price { get; set; }
        public virtual Car car { get; set; }
        public virtual Order order { get; set; }

    }
}
