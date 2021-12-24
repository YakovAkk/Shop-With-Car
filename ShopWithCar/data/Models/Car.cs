

namespace ShopWithCar.data.Models
{
    public class Car
    {
        public int id { get; set; }
        public string name { get; set; }
        public string shortDescription { get; set; }
        public string longDescription { get; set; }
        public string img { get; set; } 
        public ulong price { get; set; }
        public bool isFavorite { get; set; }
        public bool available { get; set; }
        public int categoryID { get; set; }
        public virtual Category Category { get; set; }
    }
}
