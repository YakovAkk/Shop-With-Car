using ShopWithCar.data.mocks;
using ShopWithCar.data.Models;
using ShopWithCar.Data;

namespace ShopWithCar.data
{
    enum CategoriesEnum
    {
        ElectroCar = 1,
        SimpleCar = 2
        
    }
    public class DBObjects
    {
        public static void Init(AppDBContent content)
        {

            if (!content.Categories.Any())
            {
                content.Categories.AddRange(Categories.Select(c => c.Value));
            }

            if (!content.Cars.Any())
            {
                content.AddRange(
                    new Car
                    {
                        name = "Tesla model S",
                        shortDescription = "Quick car",
                        longDescription = "Beautiful quiet car from company Tesla",
                        img = "/images/TeslaModel_S.jpg",
                        price = 1000000,
                        isFavorite = true,
                        available = true,
                        categoryID = (int)CategoriesEnum.ElectroCar,
                        // Category = Categories["ElectroCars"]
                    },

                    new Car
                    {
                        name = "Ford Fiestra",
                        shortDescription = "Power Car",
                        longDescription = "This car needs strong and charismatic host",
                        img = "/images/FordFiestra.jpg",
                        price = 2000000,
                        isFavorite = false,
                        available = true,
                        categoryID = (int)CategoriesEnum.SimpleCar,
                        // Category = Categories["Simple Cars"]
                    },

                    new Car
                    {
                        name = "BMW x7",
                        shortDescription = "For fucking serious cat",
                        longDescription = "Car like this you haven't ever seen",
                        img = "/images/bmw-x7.jpg",
                        price = 100000000,
                        isFavorite = true,
                        available = true,
                        categoryID = (int)CategoriesEnum.SimpleCar,
                        //Category = Categories["Simple Cars"]
                    },

                    new Car
                    {
                        name = "Nissan Leaf",
                        shortDescription = "silent car",
                        longDescription = "car for ninja",
                        img = "/images/Nissan-Leaf.jpg",
                        price = 3,
                        isFavorite = true,
                        available = true,
                        categoryID = (int)CategoriesEnum.ElectroCar,
                        //Category = Categories["ElectroCars"]
                    },

                    new Car
                    {
                        name = "Mercedes",
                        shortDescription = "Just car",
                        longDescription = "for mortals person",
                        img = "/images/Mersedes.jpg",
                        price = 100000000,
                        isFavorite = true,
                        available = true,
                        categoryID = (int)CategoriesEnum.SimpleCar,
                        //Category = Categories["Simple Cars"]
                    }
                    );
            }
            content.SaveChanges();
        }

        private static Dictionary<string, Category> _category;
        public static Dictionary<string,Category> Categories
        {
            get
            {
                if(_category == null)
                {
                    var carM = new MockCategory();
                

                   _category = new Dictionary<string, Category>();
                    foreach (var item in carM.allCategories)
                    {
                        _category.Add(item.categoryName, item);
                    }

                }

                return _category;
            }
        }
       
    }
}
