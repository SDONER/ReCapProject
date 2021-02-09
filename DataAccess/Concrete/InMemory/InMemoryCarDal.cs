using DataAccess.Abstract;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _car;
        public InMemoryCarDal()
        {
            _car = new List<Car> {
            new Car { Id = 1, BrandName = "BMW", ColorId = 1, DailyPrice = 150, Description = "BMW CAR" },
            new Car { Id = 1, BrandName = "AUDI", ColorId = 1, DailyPrice = 150, Description = "AUDI CAR" },
            new Car { Id = 1, BrandName = "MERCEDES", ColorId = 1, DailyPrice = 150, Description = "MERCEDES CAR"}

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

        public Car Get(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll()
        {
            return _car;
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetByAll(int Id)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetByAllBrandId(int BrandId)
        {
            return _car.Where(c => c.BrandName == c.BrandName).ToList();
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
            carToUpdate.BrandName = car.BrandName;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
            carToUpdate.ModelYear = car.ModelYear;

        }

       
    }
}
