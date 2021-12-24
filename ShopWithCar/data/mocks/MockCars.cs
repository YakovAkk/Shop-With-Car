

using System.Collections.Generic;
using System.Linq;
using ShopWithCar.data.interfaces;
using ShopWithCar.data.Models;

namespace ShopWithCar.data.mocks
{
    public class MockCars : IAllCars
    {
        private readonly ICarsCategory _categoryCars = new MockCategory();
        public IEnumerable<Car> cars
        {
            get
            {
                return new List<Car> { new Car {
                    name = "Tesla model S",
                    shortDescription = "Quick car",
                    longDescription = "Beautiful quiet car from company Tesla",
                    img = "/images/TeslaModel_S.jpg",
                    price = 1000000,
                    isFavorite = true,
                    available = true,
                    Category = _categoryCars.allCategories.First() },

                    new Car { name = "Ford Fiestra",
                    shortDescription = "Power Car",
                    longDescription = "This car needs strong and charismatic host",
                    img = "/images/FordFiestra.jpg",
                    price = 2000000,
                    isFavorite = false,
                    available = true,
                    Category = _categoryCars.allCategories.Last() },

                    new Car { name = "BMW x7",
                    shortDescription = "For fucking serious cat",
                    longDescription = "Car like this you haven't ever seen",
                    img = "/images/bmw-x7.jpg",
                    price = 100000000,
                    isFavorite = true,
                    available = true,
                    Category = _categoryCars.allCategories.Last() },

                    new Car { name = "Nissan Leaf",
                    shortDescription = "silent car",
                    longDescription = "car for ninja",
                    img = "/images/Nissan-Leaf.jpg",
                    price = 3,
                    isFavorite = true,
                    available = true,
                    Category = _categoryCars.allCategories.First() },

                    new Car { name = "Mercedes",
                    shortDescription = "Just car",
                    longDescription = "for mortals person",
                    img = "/images/Mersedes.jpg",
                    price = 100000000,
                    isFavorite = true,
                    available = true,
                    Category = _categoryCars.allCategories.Last() }
                };
            }

           
        }
        public IEnumerable<Car> getFavoriteCar { get; set; }

        public Car getObjectCar(int carID)
        {
            throw new System.NotImplementedException();
        }
    }
}
