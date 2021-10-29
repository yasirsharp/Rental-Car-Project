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
            var result = colorManager.GetAll();
            if (result.Success)
            {
                foreach (var color in result.Data)
                {
                    Console.WriteLine($"Color Info: \n" +
                        $"Color Id:         {color.ColorId} \n" +
                        $"Color Name:       {color.ColorName} \n" +
                        $"--------------------------------");
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }
        }

        private static void LocalBrandTest(BrandManager brandManager)
        {
            var result = brandManager.GetAll();
            if (result.Success)
            {
                foreach (var brand in result.Data)
                {
                    Console.WriteLine($"Brand Info: \n" +
                        $"Brand Id:         {brand.BrandId} \n" +
                        $"Brand Name:       {brand.BrandName} \n" +
                        $"--------------------------------");
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }
        }

        private static void LocalGetCar(CarManager carManager)
        {
            var result = carManager.GetCarDetail();
            if (result.Success)
            {
                Console.WriteLine("-----------------Car Info-----------------\n");
                foreach (var car in result.Data)
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
            else
            {
                Console.WriteLine(result.Message);
            }

            
        }
    }
}
