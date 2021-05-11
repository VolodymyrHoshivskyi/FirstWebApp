using FirstWebApp.Data.Models;
using System.Collections.Generic;

namespace FirstWebApp.Data.Interfaces
{
    public interface IAllCars
    {

        IEnumerable<Car> Cars { get; }
        IEnumerable<Car> getFavCars { get; set; }
        Car getObjectCar (int carID);

    }
}
