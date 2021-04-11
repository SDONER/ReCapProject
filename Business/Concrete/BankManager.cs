using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class BankManager : IBankService
    {

        IBankDal _bankDal;

        public BankManager(IBankDal bankDal)
        {
            _bankDal = bankDal;
        }

        public IResult Add(Bank bank)
        {
          _bankDal.Add(bank);
            return new SuccessResult("Kredi kartınız sisteme eklenmiştir.");
        }

        public IResult Delete(Bank bank)
        {
            _bankDal.Delete(bank);
            return new SuccessResult("Kredi kartı tanımınız silinmiştir.");
        }
    }
}
