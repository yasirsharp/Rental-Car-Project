using Business.Concrete;
using DataAccess.Concrete.InMemory;
using DataAccess.Concrete.InMemoryTest;
using System;

namespace TestUıiConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Car:");
            CarManager carManager = new CarManager(new InMemoryCarDal());
            foreach (var cars in carManager.GetAllCars())
            {
                Console.WriteLine($"{cars.Description}");
            }

            Console.WriteLine("Hello World!");
        }
    }
}
