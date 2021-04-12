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
    public class EfColorDal : EfEntityRepositoryBase<Color, NorthwindContext>, IColorDal
    {
        public List<ColorDetailDto> GetColorDetails()
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                var result = from color in context.Colors
                             join car  in context.Cars
                             on color.Id equals car.ColorId
                             orderby car.DailyPrice descending
                             select new ColorDetailDto
                             {
                                 
                                 CarId = car.Id,
                                 ColorId = color.Id,
                                 ColorName = color.ColorName                            
                             };
                return result.ToList();
            }
        }
    }
}
