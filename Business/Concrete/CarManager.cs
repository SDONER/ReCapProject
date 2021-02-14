using Business.Abstract;
using DataAccess.Abstract;
using Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _CarDal;
      

        public CarManager(ICarDal carDal)
        {
            _CarDal = carDal;
        }

        public List<Car> GetAll()
        {
            throw new NotImplementedException();
        }

        public List<Car> GetByBrandId(int Id)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetByBrandName(string Id)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetByBrandName(string MinLength, string MaxLength)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetByBrandName(int MinLength, int MaxLength)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetByCarName(string Id)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetByColorId(int Id)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetByDailyPrice(decimal min, decimal max)
        {
            return _CarDal.GetAll(c => c.DailyPrice >= min && c.DailyPrice <= max);
        }

        public List<Car> GetByDailyPrice(float Id)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetByDescription(string Id)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetByModelYear(int Id)
        {
            throw new NotImplementedException();
        }
    }
}
