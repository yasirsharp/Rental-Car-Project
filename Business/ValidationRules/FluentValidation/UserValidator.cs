using Core.Entities.Concrete;
using Entities.Concrete;
using Entities.IDtos;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules.FluentValidation
{
    public class UserValidator : AbstractValidator<UserForRegisterDto>
    {
        public UserValidator()
        {
            RuleFor(usr => usr.FirstName).NotEmpty();
            RuleFor(usr => usr.Email).NotEmpty();
            RuleFor(usr => usr.Password).NotEmpty();

            RuleFor(usr => usr.FirstName).MinimumLength(2);
            RuleFor(usr => usr.Email).MinimumLength(6);
        }
    }
}
