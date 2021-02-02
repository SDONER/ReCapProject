using DataAccess.Abstract;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _car;
        public InMemoryCarDal()
        {
            _car = new List<Car> {
            new Car { Id = 1, BrandId = 1, ColorId = 1, DailyPrice = 150, Description = "BMW" },
            new Car { Id = 1, BrandId = 1, ColorId = 1, DailyPrice = 150, Description = "AUDI" },
            new Car { Id = 1, BrandId = 1, ColorId = 1, DailyPrice = 150, Description = "MERCEDES" }

           };
        }
        public void Add(Car car)
        {

            _car.Add(car);

        }

        public void Delete(Car car)
        {
            //LINQ
            Car carToDelete;
            carToDelete = _car.SingleOrDefault(c => c.Id == car.Id);
            _car.Remove(carToDelete);
        }

        public List<Car> GetAll()
        {
            return _car;
        }

        public List<Car> GetByAll(int Id)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetByAllBrandId(int BrandId)
        {
            return _car.Where(c => c.BrandId == BrandId).ToList();
        }

        public List<Car> GetById()
        {
            return _car;
        }

        public void Update(Car car)
        {
            //LINQ
            Car carToUpdate =  _car.SingleOrDefault(c => c.Id == car.Id);
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
            carToUpdate.ModelYear = car.ModelYear;

        }

       
    }
}
