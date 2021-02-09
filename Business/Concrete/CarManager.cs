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
        ICarDal _iCarDal;
      

        public CarManager(ICarDal iCarDal)
        {
            _iCarDal = iCarDal;
        }

        public List<Car> GetAll()
        {
            return _iCarDal.GetAll();
        }

        public List<Car> GetByBrandId(int Id)
        {
            throw new NotImplementedException();
        }


        public List<Car> GetByBrandName(int MinLength, int MaxLength)
        {
            return _iCarDal.GetAll(c => c.BrandName.Length >= 2 && c.DailyPrice >= 0);
        }


        public List<Car> GetByColorId(int Id)
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

        public List<Car> GetByName(string Id)
        {
            throw new NotImplementedException();
        }
    }
}
