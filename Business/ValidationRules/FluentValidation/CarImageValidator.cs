using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules.FluentValidation
{
    public class CarImageValidator : AbstractValidator<CarImage>
    {
        public CarImageValidator()
        {
            RuleFor(carImg => carImg.CarId).NotEmpty();
            RuleFor(carImg => carImg.CarId).NotNull();
            //RuleFor(carImg => carImg.ImgPath).NotEmpty();
            //RuleFor(carImg => carImg.ImgPath).MinimumLength(2);

        }
    }
}
