using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules.FluentValidation
{
    public class CustomerValidator : AbstractValidator<Customer>
    {
        public CustomerValidator()
        {
            RuleFor(cus => cus.CompanyName).NotEmpty();
            RuleFor(cus => cus.CompanyName).MinimumLength(5);
            RuleFor(cus => cus.UserId).NotEmpty();
            RuleFor(cus => cus.UserId).GreaterThan(0);
        }
    }
}
