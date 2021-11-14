using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules.FluentValidation
{
    public class UserValidator : AbstractValidator<User>
    {
        public UserValidator()
        {
            RuleFor(usr => usr.FirstName).NotEmpty();
            RuleFor(usr => usr.EMail).NotEmpty();
            RuleFor(usr => usr.Password).NotEmpty();

            RuleFor(usr => usr.FirstName).MinimumLength(2);
            RuleFor(usr => usr.EMail).MinimumLength(6);
            RuleFor(usr => usr.Password).MinimumLength(10);
        }
    }
}
