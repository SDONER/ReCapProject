using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class RentalManager : IRentalService
    {
        IRentalDal _rentalDal;

        public RentalManager(IRentalDal rentalDal)
        {
            this._rentalDal = rentalDal;
        }

        public IResult Add(Rental rental)
        {
            if (rental.ReturnDate == null || _rentalDal.GetRentDetails(r => r.CarId == rental.CarId).Count > 0)
            {
                return new ErrorResult(Messages.RentalCancelled);
            }
            _rentalDal.Add(rental);

            return new SuccessDataResult(Messages.RentalAdded);
        }

        public IResult Delete(Rental rental)
        {
            return new SuccessDataResult<List<Rental>>(Messages.RentalDeleted);
        }

        public IDataResult<List<Rental>> GetAll()
        {
            return new SuccessDataResult<List<Rental>>(_rentalDal.GetAll(),Messages.RentalListed);
        }

        public IDataResult<List<Rental>> GetById(int userId)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<RentalDetailDto>> GetRentDetails()
        {
            return new SuccessDataResult<List<RentalDetailDto>>(_rentalDal.GetRentDetails(), Messages.RentalDetailListed);
        }

        public IResult Update(Rental rental)
        {
            return new SuccessDataResult<List<Rental>>(Messages.RentalUpdated);
        }
    }
}
