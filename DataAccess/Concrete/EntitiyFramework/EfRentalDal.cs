using Core.DataAccess.EntitiyFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Linq.Expressions;

namespace DataAccess.Concrete.EntitiyFramework
{
    public class EfRentalDal : EfEntityRepositoryBase<Rental,NorthwindContext>,IRentalDal
    {
        public List<RentalDetailDto> GetRentDetails(Expression<Func<Rental, bool>> filter = null)

        {
            using (NorthwindContext context = new NorthwindContext())
            {
                var result = from rental in  context.Rentals 
                             join car in context.Cars
                             on rental.CarId equals car.Id
                             select new RentalDetailDto
                             {
                                 Id = car.CarId,
                                 Description = car.Description,
                                 CarName = car.CarName,
                                 DailyPrice = car.DailyPrice,
                                 ModelYear = car.ModelYear
                             };
                return result.ToList();
            }
        }
    }
}
