using Core.DataAccess.EntitiyFramework;
using DataAccess.Abstract;
using Entities;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntitiyFramework
{
    public class EfCarDal : EfEntityRepositoryBase<Car, NorthwindContext>, ICarDal
    {
        public List<CarDetailDto> GetCarDetails(Expression<Func<Car, bool>> filter=null)
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                var result = from car in filter == null ? context.Cars :context.Cars.Where(filter)
                             join brand in context.Brands on car.BrandId equals brand.Id
                             join color in context.Colors on car.ColorId equals color.Id
                             join image in context.CarImages on car.Id equals image.CarId 
                             orderby car.DailyPrice descending
                             select new CarDetailDto
                             {
                                 Id = car.Id,
                                 CarName = car.CarName,
                                 BrandId = brand.Id,
                                 BrandName = brand.BrandName,
                                 ColorId = color.Id,
                                 ColorName = color.ColorName,
                                 DailyPrice = car.DailyPrice,
                                 ModelYear = car.ModelYear,
                                 Description = car.Description,
                                 ImagePath = image.ImagePath,
                                 Date = image.Date
                                                                  
                             };
                return result.ToList();
            }
        }

    
    }


}
