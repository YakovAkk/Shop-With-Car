using System.Collections.Generic;
using ShopWithCar.data.interfaces;
using ShopWithCar.data.Models;

namespace ShopWithCar.data.mocks
{
    public class MockCategory : ICarsCategory
    {
        public IEnumerable<Category> allCategories
        {
            get {
                return new List<Category>
                {
                    new Category {categoryName = "ElectroCars" , description = "these are Modern mode of transport"},
                    new Category {categoryName = "Simple Cars" , description = "these are very simple"}
                };
            }
        }
    }
}
