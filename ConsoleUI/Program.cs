using Business.Concrete;
using DataAccess.Concrete.EntitiyFramework;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //CarTest();
            //CategoryTest();
        }

        private static void CategoryTest()
        {
            CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());
            foreach (var category in categoryManager.GetAll())
            {
                Console.WriteLine(category.CategoryName);
            }
        }

        private static void CarTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            foreach (var car in carManager.GetCarDetails())
            {
                Console.WriteLine("Fiyatı 0'dan büyük olan araçlar listelendi.");
                Console.WriteLine("Car Name" + ' ' + car.CarName + ' ' + "Color Name" + ' ' + car.ColorName + "Brand Name"+ car.BrandName + "Daily Price" + car.DailyPrice );
            }
        }


    }
}
