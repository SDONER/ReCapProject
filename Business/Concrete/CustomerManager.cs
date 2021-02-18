using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CustomerManager : ICustomerService
    {
        ICustomerDal _customerDal;

        public CustomerManager(ICustomerDal customerDal)
        {
            _customerDal = customerDal;
        }

        public IResult Add(Customer customer)
        {
            return new SuccessDataResult(Messages.CustomerAdded);
        }

        public IResult Delete(Customer customer)
        {
            return new SuccessDataResult(Messages.CustomerDeleted);
        }

        public List<Customer> GetAll()
        {
            return _customerDal.GetAll();
        }

        public Customer GetById(int userId)
        {
            return _customerDal.Get(c => c.UserID == userId);
        }

        public List<CustomerDetailDto> GetCustomerDetails()
        {
            return _customerDal.GetCustomerDetails();
        }

        public IResult Update(Customer customer)
        {
            return new SuccessDataResult(Messages.CustomerUpdated);
        }
    }
}
