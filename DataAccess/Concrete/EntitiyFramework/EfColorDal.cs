using Core.DataAccess.EntitiyFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Linq;

namespace DataAccess.Concrete.EntitiyFramework
{
    class EfColorDal : EfEntityRepositoryBase<Color, NorthwindContext>, IColorDal
    {
        public List<ColorDetailDto> GetCarDetails()
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                var result = from color in context.Colors
                             join car  in context.Cars
                             on color.ColorId equals car.ColorId
                             orderby car.DailyPrice descending
                             select new ColorDetailDto
                             {
                                 CarName = car.CarName,
                                 ColorId = car.ColorId,
                                 ColorName = color.ColorName,
                             };
                return result.ToList();
            }
        }

        
    }
}
