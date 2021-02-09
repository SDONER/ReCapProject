using Entities;
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
        List<Car> GetByName(string Id);
        List<Car> GetByDescription(string Id);
        List<Car> GetByModelYear(int Id);


        List<Car> GetByBrandName(int MinLength, int MaxLength);
    }
}
