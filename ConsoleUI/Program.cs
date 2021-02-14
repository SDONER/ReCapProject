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
            CarManager carManager = new CarManager(new EfCarDal());
            foreach (var car in carManager.GetByDailyPrice(0,150))
            {
                Console.WriteLine("Fiyatı 0'dan büyük olan araçlar listelendi.");
                Console.WriteLine("Açıklama" + ' ' + car.Description + ' ' + "Fiyat" + ' ' + car.DailyPrice);
            }

        }


       
    }
}
