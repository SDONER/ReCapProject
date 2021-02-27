using Business.Concrete;
using DataAccess.Concrete.EntitiyFramework;
using DataAccess.Concrete.InMemory;
using Entities;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //CarTest();
            //CategoryTest();
            //CustomerTest();
            //RentalTest();
            //ReturnDateTest();
            ReturnDateErrorTest();
            //CustomerAddTest();


        }

        private static void CustomerAddTest()
        {
            CustomerManager customerManager = new CustomerManager(new EfCustomerDal());
            Customer customer = new Customer() { CustomerId = 4, CompanyName = "GMZLM LLC.", UserID = 23 };
            var result = customerManager.Add(customer);
            Console.WriteLine(result.Message);
        }

        private static void ReturnDateErrorTest()
        {
            RentalManager rentalManager = new RentalManager(new EfRentalDal());
            Rental rental = new Rental() { Id = 5, CarId = 3, CustomerId = 21, RentDate = DateTime.Now };
            var result = rentalManager.Add(rental);
            Console.WriteLine(result.Message);
        }

        private static void ReturnDateTest()
        {
            RentalManager rentalManager = new RentalManager(new EfRentalDal());

            var result = rentalManager.GetRentDetails();
            if (result.Success)
            {
                foreach (var rental in result.Data)
                {
                    Console.WriteLine(result.Success);
                }
            }
        }

        private static void RentalTest()
        {
            RentalManager rentalManager = new RentalManager(new EfRentalDal());

            var result = rentalManager.GetRentDetails();
            if (result.Success)
            {
                foreach (var rental in rentalManager.GetRentDetails().Data)
                {
                    Console.WriteLine(rental.RentDate + " */* "+  rental.CarName);
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }
           
            
        }

        private static void CustomerTest()
        {
            CustomerManager customerManager = new CustomerManager(new EfCustomerDal());
            foreach (var customer in customerManager.GetAll())
            {
                Console.WriteLine(customer.CompanyName + "*/*" + customer.UserID);
            }
        }

        private static void CategoryTest()
        {
            CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());
            //foreach (var category in categoryManager.GetAll())
            //{
           //     Console.WriteLine(category.CategoryName);
           // }
        }

        private static void CarTest()
        {

            CarManager carManager = new CarManager(new EfCarDal());

            var result = carManager.GetCarDetails();
            if (result.Success == true)
            {
                foreach (var car in result.Data)
                {
                    Console.WriteLine("Fiyatı 0'dan büyük olan araçlar listelendi.");
                    Console.WriteLine("Car Name" + " */* " + car.CarName + " */* " + "Color Name" + " */* " + car.ColorName + " */* "+"Brand Name" + " */* " + car.BrandName + " */* " + "Daily Price"+ " */* " + car.DailyPrice);
                }                   
            }
            else
            {
                Console.WriteLine(result.Message);
            }

        }

    }
}
