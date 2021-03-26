using Core.DataAccess;
using Entities;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    public interface ICarDal : IEntityRepository<Car>
    {
        List<CarDetailDto> GetCarDetails();
        //List<Car> GetById();
        //void Add(Car car);
        //void Update(Car car);
        //void Delete(Car car);

        //List<Car> GetByAllBrandId(int Id);
    }

  
}
