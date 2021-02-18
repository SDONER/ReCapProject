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
        IDataResult<List<Car>> GetAll();
        IDataResult<List<Car>> GetByBrandId(int Id);
        IDataResult<List<Car>> GetByColorId(int Id);
        IDataResult<List<Car>> GetByCarName(string Id);
        IDataResult<List<Car>> GetByDescription(string Id);
        IDataResult<List<Car>> GetByModelYear(int Id);
        IDataResult<List<Car>> GetByBrandName(string Id);
        IDataResult<List<Car>> GetByDailyPrice(decimal min, decimal max);
        IDataResult<List<Car>> GetByBrandName(int MinLength, int MaxLength);
        IDataResult<List<Car>> GetCarsByBrandId(int Id);
        IDataResult<List<Car>> GetCarsByColorId(int Id);


        IDataResult<List<ColorDetailDto>> GetCarDetails();

        IResult Add(Car car);
        IResult Update(Car car);
        IResult Delete(Car car);


    }
}
