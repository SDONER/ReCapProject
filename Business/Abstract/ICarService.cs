using Core.Utilities.Results;
using Entities;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICarService
    {
        IResult Add(Car car);
        IResult Update(Car car);
        IResult Delete(Car car);

        IDataResult<List<Car>> GetAll();
        IDataResult<Car> GetById(int Id);
        IDataResult<List<Car>> GetByBrandId(int Id);
        IDataResult<List<Car>> GetByCarId(int Id);
        IDataResult<List<Car>> GetByCarName(string Id);
        IDataResult<List<Car>> GetByDescription(string Id);
        IDataResult<List<Car>> GetByModelYear(int Id);
        IDataResult<List<Car>> GetByBrandName(string brandName);
        IDataResult<List<Car>> GetCarsByBrandId(int brandId);
        IDataResult<List<Car>> GetCarsByCarId(int Id);

        IDataResult<List<CarDetailDto>> GetCarDetails();

        IDataResult<List<Car>> GetByDailyPrice(decimal min, decimal max);
        IDataResult<List<Car>> GetByBrandName(int MinLength, int MaxLength);

        IResult AddTransactionalTest(Car car);
        IDataResult<List<Car>> GetCarsByColorId(int colorId);
        IDataResult<List<CarDetailDto>> GetCarDetailsByCarId(int carId);
        IDataResult<List<CarDetailDto>> GetImageByCarId(int carId);
    }
}
