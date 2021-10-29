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
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            ColorManager colorManager = new ColorManager(new EfColorDal());


            //LocalColorTest(colorManager);
            //LocalBrandTest(brandManager);
            LocalGetCar(carManager);
        }

        private static void LocalColorTest(ColorManager colorManager)
        {
            foreach (var color in colorManager.GetAll())
            {
                Console.WriteLine($"Color Info: \n" +
                    $"Color Id:         {color.ColorId} \n" +
                    $"Color Name:       {color.ColorName} \n" +
                    $"--------------------------------");
            }
        }

        private static void LocalBrandTest(BrandManager brandManager)
        {
            foreach (var brand in brandManager.GetAll())
            {
                Console.WriteLine($"Brand Info: \n" +
                    $"Brand Id:         {brand.BrandId} \n" +
                    $"Brand Name:       {brand.BrandName} \n" +
                    $"--------------------------------");
            }
        }

        private static void LocalGetCar(CarManager carManager)
        {
            Console.WriteLine("-----------------Car Info-----------------\n");
            foreach (var car in carManager.GetCarDetail())
            {
                Console.WriteLine(
                    $"" +
                    $"Car Id:       {car.CarId}        \n" +
                    $"Brand Name:   {car.BrandName}    \n" +
                    $"Color:        {car.ColorName}    \n" +
                    $"Daily Price   {car.DailyPrice}   \n" +
                    $"------------------------------------\n");
            }
        }
    }
}
