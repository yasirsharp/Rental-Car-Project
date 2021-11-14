using Business.Abstract;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.IDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class RentalManager : IRentalService
    {
        IRentalDal _rentalDal;

        public RentalManager(IRentalDal rentalDal)
        {
            _rentalDal = rentalDal;
        }

        [ValidationAspect(typeof(RentalValidator))]
        public IResult Add(Rental rental)
        {
            _rentalDal.Add(rental);
            return new SuccessResult(Messages.RentalAdded);
        }

        public IResult Delete(Rental rental)
        {
            if (rental.RentId < 1)
            {
                return new ErrorResult(Messages.RentalDeleteFailed);
            }

            _rentalDal.Delete(rental);
            return new SuccessResult(Messages.RentalDeleted);
        }

        public IResult Update(Rental rental)
        {
            if (rental.RentId !> 0)
            {
                return new ErrorResult(Messages.RentalUpdateFailed);
            }

            _rentalDal.Update(rental);
            return new SuccessResult(Messages.RentalUpdated);
        }

        public IDataResult<List<Rental>> GetAll()
        {
            if (DateTime.Now.Hour == 23)
            {
                return new ErrorDataResult<List<Rental>>(Messages.SystemOffline);
            }

            return new SuccessDataResult<List<Rental>>(_rentalDal.GetAll(), Messages.RentalListed);
        }

        public IDataResult<List<Rental>> GetById(int id)
        {
            if (DateTime.Now.Hour == 23)
            {
                return new ErrorDataResult<List<Rental>>(Messages.SystemOffline);
            }

            return new SuccessDataResult<List<Rental>>(_rentalDal.GetAll(p=>p.RentId==id), Messages.RentalListed);
        }

        public IResult ChechReturnDate(int carId)
        {
            var result = _rentalDal.GetCarRentalDetails(p=>p.CarId == carId && p.ReturnDate != null);
            if (result.Count > 0)
            {
                return new ErrorResult(Messages.RentalAddFailed);
            }
            return new SuccessResult(Messages.RentalAdded);
        }

        public IResult UpdateReturnDate(Rental rental)
        {
            var result = _rentalDal.GetAll(p=>p.RentId == rental.RentId);
            var updateRental = result.LastOrDefault();

            if (updateRental != null)
            {
                return new ErrorResult(Messages.RentalUpdateFailed);
            }

            updateRental.ReturnDate = rental.ReturnDate;
            _rentalDal.Update(updateRental);
            return new SuccessResult(Messages.RentalUpdated);
        }

        public IDataResult<List<CarRentalDetailDto>> GetRentalCarDetails()
        {
            return new SuccessDataResult<List<CarRentalDetailDto>>(_rentalDal.GetCarRentalDetails(), Messages.RentalListed);
        }
    }
}
