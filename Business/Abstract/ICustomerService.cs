using Core.Utilities.Results;
using Entities;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICustomerService
    {
        List<Customer> GetAll();
        Customer GetById(int userId);

        List<CustomerDetailDto> GetCustomerDetails();

        IResult Add(Customer customer);
        IResult Update(Customer customer);
        IResult Delete(Customer customer);

    }
}
