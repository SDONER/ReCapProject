using Business.Abstract;
using DataAccess.Abstract;
using Entities;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _carDal;
      

        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }

        public void Add(Car car)
        {
            _carDal.Add(car);
        }

        public void Delete(Car car)
        {
            _carDal.Delete(car);
        }

        public List<Car> GetAll()
        {
            return _carDal.GetAll();
        }

        public List<Car> GetByBrandId(int Id)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetByBrandName(string Id)
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
            return _carDal.GetAll(c => c.DailyPrice >= 0);
        }

        public List<Car> GetByDescription(string Id)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetByModelYear(int Id)
        {
            throw new NotImplementedException();
        }

        public List<CarDetailDto> GetCarDetails()
        {
            return _carDal.GetCarDetails();
        }

        public List<Car> GetCarsByBrandId(int Id)
        {
            return _carDal.GetAll(c => c.BrandId == Id);
        }

        public List<Car> GetCarsByColorId(int Id)
        {
            throw new NotImplementedException();
        }

        public void Update(Car car)
        {
            _carDal.Update(car);
        }
    }
}
