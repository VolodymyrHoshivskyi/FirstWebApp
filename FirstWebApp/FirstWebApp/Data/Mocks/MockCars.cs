using FirstWebApp.Data.Interfaces;
using FirstWebApp.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstWebApp.Data.Mocks
{
    public class MockCars : IAllCars
    {
        private readonly ICarsCategory _categoryCars = new MockCategory();
        public IEnumerable<Car> Cars
        {
            get
            {
                return new List<Car>
                {
                    new Car
                    {
                        name = "Tesla",
                        shortDesc = "Швидкий електрокар",
                        longDesc = "Красивий, швидкий, та дуже тихилий електрокар компанії Tesla",
                        img = "https://cdn2.riastatic.com/photosnew/auto/photo/tesla_model-s__374473957fx.webp",
                        price = 55000,
                        isFavourite = true,
                        available = true,
                        Category = _categoryCars.AllCategories.First()
                    },

                     new Car {
                        name = "Ford Fiesta",
                        shortDesc = "Тихий та спокійний",
                        longDesc = "Зручний автомобіль для життя в місті",
                        img = "https://cdn1.riastatic.com/photosnew/auto/photo/ford_fiesta__388859421fx.webp",
                        price = 11000,
                        isFavourite = false,
                        available = true,
                        Category = _categoryCars.AllCategories.Last()
                     },

                      new Car {
                        name = "BMW M3",
                        shortDesc = "Агресивний та стильний",
                        longDesc = "Зручний автомобіль для життя в місті",
                        img = "https://cdn3.riastatic.com/photosnew/auto/photo/bmw_m3__368572233fx.webp",
                        price = 65000,
                        isFavourite = true,
                        available = true,
                        Category = _categoryCars.AllCategories.Last()
                      },

                       new Car {
                        name = "Mercedes C class",
                        shortDesc = "Комфортний та великий",
                        longDesc = "Зручний автомобіль для життя в місті",
                        img = "https://cdn2.riastatic.com/photosnew/auto/photo/mercedes-benz_c-200__391659362fx.webp",
                        price = 50000,
                        isFavourite = false,
                        available = false,
                        Category = _categoryCars.AllCategories.Last()
                      },
                        new Car {
                        name = "Nissan Leaf",
                        shortDesc = "Безшумний та економний",
                        longDesc = "Зручний автомобіль для життя в місті",
                        img = "https://cdn3.riastatic.com/photosnew/auto/photo/nissan_leaf__389708583fx.webp",
                        price = 13000,
                        isFavourite = true,
                        available = true,
                        Category = _categoryCars.AllCategories.Last()
                      }


                };
            }
        }
        public IEnumerable<Car> getFavCars { get; set; }

        public Car getObjectCar(int carID)
        {
            throw new NotImplementedException();
        }
    }
}
