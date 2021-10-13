using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemoryTest
{
    public class InMemoryTestCarDal : ICarDal
    {
        List<Car> _cars;

        public InMemoryTestCarDal()
        {
            _cars = new List<Car> {
                new Car{CarId = 1, BrandId = 1, ColorId = 2, DailyPrice = 469, ModelYear = 2021, Description = "Modifiers R35"},
                new Car{CarId = 2, BrandId = 3, ColorId = 2, DailyPrice = 234, ModelYear = 2018, Description = "Honda Civic"},
                new Car{CarId = 3, BrandId = 5, ColorId = 4, DailyPrice = 890, ModelYear = 2000, Description = "Toyota Avensis"},
                new Car{CarId = 4, BrandId = 7, ColorId = 9, DailyPrice = 532, ModelYear = 1996, Description = "Toyota Corolla"},
                new Car{CarId = 5, BrandId = 2, ColorId = 7, DailyPrice = 356, ModelYear = 2011, Description = "Hundai i-20"}
            };
        }


        public void Add(Car car)
        {
            throw new NotImplementedException();
        }

        public void Delete(Car car)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Car car)
        {
            throw new NotImplementedException();
        }
    }
}
