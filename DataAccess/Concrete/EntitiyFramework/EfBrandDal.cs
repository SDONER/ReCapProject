using Core.DataAccess.EntitiyFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntitiyFramework
{
    public class EfBrandDal : EfEntityRepositoryBase<Brand, NorthwindContext>, IBrandDal
    {
        public List<BrandDetailDto> GetBrandDetails()
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                var result = from brand in context.Brands
                             join car in context.Cars
                             on brand.CarId equals car.Id
                             
                             select new BrandDetailDto
                             {
                                 Id = brand.Id,
                                 BrandName = brand.BrandName,
                                 CarId = car.Id
                                 
                             };
                return result.ToList();
            }
        }
    }
}
