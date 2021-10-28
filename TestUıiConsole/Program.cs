using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;
using System.Collections.Generic;

namespace TestUıiConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new EfCarDal());



            foreach (var car in carManager.GetAllCars())
            {
                Console.WriteLine($"Car Info: \n" +
                    $"Model:        {car.ModelName} \n" +
                    $"Year:         {car.ModelYear} \n" +
                    $"Price:        {car.DailyPrice}\n" +
                    $"Description:  {car.Description}\n" +
                    $"--------------------------------");
            }
        }
    }
}
