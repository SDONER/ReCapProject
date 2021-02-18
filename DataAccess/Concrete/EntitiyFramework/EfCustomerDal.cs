using Core.DataAccess.EntitiyFramework;
using DataAccess.Abstract;
using Entities;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace DataAccess.Concrete.EntitiyFramework
{
    public class EfCustomerDal :EfEntityRepositoryBase<Customer, NorthwindContext>, ICustomerDal
    {
        public List<CustomerDetailDto> GetCustomerDetails()
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                var result = from customer in context.Customers
                             join user in context.Users
                             on customer.UserID equals user.Id
                             select new CustomerDetailDto
                             {
                                 UserID = user.Id ,
                                 FirstName = user.FirstName,
                                 LastName = user.LastName,
                                 Email = user.Email,
                                 CompanyName = customer.CompanyName,
                                 Password = user.Password
                             };
                return result.ToList();
            }
        }
    }
}
