using System.Collections;
using System.Collections.Generic;
using ShopWithCar.data.Models;

namespace ShopWithCar.data.interfaces
{
    public interface IAllCars
    {
        IEnumerable<Car> cars { get; }
        IEnumerable<Car> getFavoriteCar { get; }

        Car getObjectCar(int carID);
    }
}
