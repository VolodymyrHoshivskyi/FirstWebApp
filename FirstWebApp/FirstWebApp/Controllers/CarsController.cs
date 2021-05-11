using FirstWebApp.Data.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace FirstWebApp.Controllers
{
    public class CarsController : Controller  // функції при виклику яких повертається тип даних view result - у вигляді html сторінки
    {
        private readonly IAllCars _allCars;
        private readonly ICarsCategory _allCategories;

        public CarsController(IAllCars iAllCars, ICarsCategory iCarsCat)
        {
            _allCars = iAllCars;
            _allCategories = iCarsCat;

        }
        public ViewResult List()
        {
            var cars = _allCars;
            return View(cars);
        }
    }
}
