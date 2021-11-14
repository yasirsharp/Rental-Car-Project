using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules.FluentValidation
{
    public class CarValidator : AbstractValidator<Car>
    {
        public CarValidator()
        {
            RuleFor(car => car.BrandId).GreaterThan(0);
            RuleFor(car => car.DailyPrice).GreaterThan(100);
            RuleFor(car => car.Description).MinimumLength(10);
        }
    }
}
