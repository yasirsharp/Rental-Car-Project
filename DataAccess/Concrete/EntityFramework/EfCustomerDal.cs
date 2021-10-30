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
    public class EfCustomerDal : EfEntityRepositoryBase<Customer, RentalCarContext>, ICustomerDal
    {
        public List<CustomerDetailDto> GetCustomerDetails(Expression<Func<Customer, bool>> filter = null)
        {
            using (RentalCarContext context = new RentalCarContext())
            {
                var result = from customer in filter is null ? context.Customers : context.Customers.Where(filter) 
                             join user in context.Users
                             on customer.UserId equals user.Id
                             select new CustomerDetailDto
                             {
                                 UserId = user.Id,
                                 UserFName = user.FirstName,
                                 UserLName = user.LastName,

                                 CompanyName = customer.CompanyName,
                                 CustomerId = customer.Id
                             };
                return result.ToList();
            }
        }
    }
}
