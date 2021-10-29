using DataAccess.Abstract;
using Entities.Concrete;
using Entities.IDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;

        public InMemoryCarDal()
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
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(p=>p.CarId==car.CarId);
            _cars.Remove(carToDelete);
        }

        public void Update(Car car)
        {
            Car carToUpdate= _cars.SingleOrDefault(p => p.CarId == car.CarId);

            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
            carToUpdate.ModelYear = car.ModelYear;
        }


        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<CarDetailDto> GetCarOrderDetail()
        {
            throw new NotImplementedException();
        }
    }
}
