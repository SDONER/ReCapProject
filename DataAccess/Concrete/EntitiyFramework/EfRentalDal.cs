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
                             join car in context.Cars on rental.CarId equals car.Id
                             join customer in context.Customers on rental.CustomerId equals customer.Id
                             join user in context.Users on rental.CustomerId equals user.Id
                             join brand in context.Brands on car.BrandId equals brand.Id
                             join color in context.Colors on car.ColorId equals color.Id

                             select new RentalDetailDto
                             {
                                 Id = rental.Id,
                                 CarId = rental.CarId,
                                 BrandId = brand.Id,
                                 BrandName = brand.BrandName,
                                 ColorName = color.ColorName,
                                 Description = car.Description,
                                 CarName = car.CarName,
                                 DailyPrice = car.DailyPrice,
                                 ModelYear = car.ModelYear,
                                 RentDate = rental.RentDate,
                                 ReturnDate = rental.ReturnDate,
                                 CompanyName = user.FirstName + " " + user.LastName,

                             };
                return result.ToList();
            }
        }
    }
}
