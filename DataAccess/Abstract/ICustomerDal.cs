using Core.DataAccess;
using Entities;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    public interface ICustomerDal : IEntityRepository<Customer>
    {
        List<CustomerDetailDto> GetCustomerDetails();
    }
}
