

using System.Collections.Generic;
using ShopWithCar.data.Models;

namespace ShopWithCar.data.interfaces
{
    public interface ICarsCategory
    {
        IEnumerable<Category> allCategories { get; }
    }
}
