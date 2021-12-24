using ShopWithCar.data.interfaces;
using ShopWithCar.data.Models;
using ShopWithCar.Data;

namespace ShopWithCar.data.Repository
{
    public class CategoryRepos : ICarsCategory
    {
        private readonly AppDBContent dBContent;

        public CategoryRepos(AppDBContent dBContent)
        {
            this.dBContent = dBContent;
        }
        public IEnumerable<Category> allCategories => dBContent.Categories;
    }
}
