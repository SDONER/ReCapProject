using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
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

        public IResult Add(Car car)
        {
            if (car.CarName.Length<2)
            {
                return new ErrorResult(Messages.CarNameInvalid);
            }
            _carDal.Add(car);

            return new SuccessDataResult(Messages.CarAdded);
        }

        public IResult Delete(Car car)
        {
            _carDal.Delete(car);
            return new SuccessDataResult(Messages.CarDeleted);
        }

        public IDataResult<List<Car>> GetAll()
        {
            if (DateTime.Now.Hour==20)
            {
                return new ErrorDataResult<List<Car>>(Messages.MaintenanceTime);
            }
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(),Messages.CarsListed);
        }

        public IDataResult<List<Car>> GetByBrandId(int Id)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<Car>> GetByBrandName(string Id)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<Car>> GetByBrandName(int MinLength, int MaxLength)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<Car>> GetByCarName(string Id)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<Car>> GetByColorId(int Id)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<Car>> GetByDailyPrice(decimal min, decimal max)
        {
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(c => c.DailyPrice >= 0));
        }

        public IDataResult<List<Car>> GetByDescription(string Id)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<Car>> GetByModelYear(int Id)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<ColorDetailDto>> GetCarDetails()
        {
            return new SuccessDataResult<List<ColorDetailDto>>(_carDal.GetCarDetails());
        }

        public IDataResult<List<Car>> GetCarsByBrandId(int Id)
        {
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(c => c.BrandId == Id));
        }

        public IDataResult<List<Car>> GetCarsByColorId(int Id)
        {
            throw new NotImplementedException();
        }

        public IResult Update(Car car)
        {
            _carDal.Update(car);
            return new SuccessDataResult(Messages.CarUpdated);
        }
    }
}
