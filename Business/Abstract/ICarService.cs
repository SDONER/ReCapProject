using Entities;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICarService
    {
        List<Car> GetAll();
        List<Car> GetByBrandId(int Id);
        List<Car> GetByColorId(int Id);
        List<Car> GetByCarName(string Id);
        List<Car> GetByDescription(string Id);
        List<Car> GetByModelYear(int Id);
        List<Car> GetByBrandName(string Id);
        List<Car> GetByDailyPrice(decimal min, decimal max);
        List<Car> GetByBrandName(int MinLength, int MaxLength);
        List<Car> GetCarsByBrandId(int Id);
        List<Car> GetCarsByColorId(int Id);


        List<CarDetailDto> GetCarDetails();

        void Add(Car car);
        void Update(Car car);
        void Delete(Car car);


    }
}
