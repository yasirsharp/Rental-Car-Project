﻿using Core.DataAccess;
using Entities.Concrete;
using Entities.IDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface IRentalDal:IEntityRepository<Rental>
    {
        List<CarRentalDetailDto> GetCarRentalDetails(Expression<Func<Rental, bool>> filter = null);
    }
}
