using Core.Utilities.Results;
using Entities.Concrete;
using Entities.IDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IRentalService
    {
        IResult Add(Rental rental);
        IResult Update(Rental rental);
        IResult Delete(Rental rental);
        IResult ChechReturnDate(int carId);
        IResult UpdateReturnDate(Rental rental);


        IDataResult<List<Rental>> GetAll();
        IDataResult<List<CarRentalDetailDto>> GetRentalCarDetails();


    }
}
