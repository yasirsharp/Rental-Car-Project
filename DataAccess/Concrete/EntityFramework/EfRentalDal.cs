using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.IDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfRentalDal : EfEntityRepositoryBase<Rental, RentalCarContext>, IRentalDal
    {
        public List<CarRentalDetailDto> GetCarRentalDetails(Expression<Func<Rental, bool>> filter = null)
        {
            using (RentalCarContext context = new RentalCarContext())
            {
                var result = from rental in filter is null ? context.Rentals : context.Rentals.Where(filter)
                             join car in context.Cars on rental.CarId equals car.CarId
                             join brand in context.Brands on car.BrandId equals brand.BrandId
                             join color in context.Colors on car.ColorId equals color.ColorId
                             join customer in context.Customers on rental.CustomerId equals customer.Id
                             join user in context.Users on customer.UserId equals user.Id
                             select new CarRentalDetailDto
                             {
                                 RentalId = rental.RentId,
                                 CustomerId = customer.Id,
                                 CustomerFName = user.FirstName,
                                 CustomerLName = user.LastName,
                                 CustomerCompanyName = customer.CompanyName,
                                 BrandName = brand.BrandName,
                                 ColorName = color.ColorName,
                                 ModelYear = car.ModelYear,
                                 DailyPrice = car.DailyPrice,
                                 RentDate = rental.RentDate,
                                 ReturnDate = rental.ReturnDate,
                             };
                return result.ToList();

            }
        }
    }
}
