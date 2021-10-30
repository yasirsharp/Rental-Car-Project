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
            #region Car
            //Car car1 = new Car { BrandId = 1003, ColorId = 5, DailyPrice = 1300, ModelYear = 2006, Description = "Araç hakkında bilgi bulunmamaktadır."};
            //Car car2 = new Car { BrandId = 1005, ColorId = 2, DailyPrice = 120, ModelYear = 1992, Description = "Araç hakkında bilgi bulunmamaktadır."};
            //Car car3 = new Car { BrandId = 1002, ColorId = 6, DailyPrice = 980, ModelYear = 1990, Description = "Araç hakkında bilgi bulunmamaktadır."};
            //carManager.Add(car1);
            //carManager.Add(car2);
            //carManager.Add(car3);
            //LocalGetCar(carManager);
            #endregion

            BrandManager brandManager = new BrandManager(new EfBrandDal());
            #region Brand
            //LocalBrandTest(brandManager);
            #endregion

            ColorManager colorManager = new ColorManager(new EfColorDal());
            #region Color
            //LocalColorTest(colorManager);
            #endregion

            UserManager userManager = new UserManager(new EfUserDal());
            #region User
            //User user = new User { FirstName = "Sude", LastName = "Keskin", EMail = "sude.keskin@yasirsharp.cs", Password = "sk6584@" };
            //User user2 = new User { FirstName = "Hilal", LastName = "Şahadet", EMail = "hilal.sahadet@yasirsharp.cs", Password = "hs65165@" };
            //User user3 = new User { FirstName = "Eda", LastName = "İpek", EMail = "eda.ipek@yasirsharp.cs", Password = "ei135@" };
            //User user4 = new User { FirstName = "Yağmur", LastName = "Öztürk", EMail = "yagmur.ozturk@yasirsharp.cs", Password = "yo8185@" };
            //User user5 = new User { FirstName = "Mehmet", LastName = "Kaya", EMail = "mehmet.kaya@yasirsharp.cs", Password = "mk7894@" };
            //User user6 = new User { FirstName = "Fatih", LastName = "Kılıçaslan", EMail = "fatih.kılıcaslan@yasirsharp.cs", Password = "fk32198@" };
            //User user7 = new User { FirstName = "Onur", LastName = "erdoğan", EMail = "onxer@yasirsharp.cs", Password = "oe2000@" };
            //userManager.Add(user);
            //userManager.Add(user2);
            //userManager.Add(user3);
            //userManager.Add(user4);
            //userManager.Add(user5);
            //userManager.Add(user6);
            //userManager.Add(user7);
            //User userToDelete = new User { Id = 2005};
            //userManager.Delete(userToDelete);
            //LocalUserTest(userManager);
            #endregion

            CustomerManager customerManager = new CustomerManager(new EfCustomerDal());
            #region Customer
            //Customer customer  = new Customer { UserId = 2004, CompanyName = "Bilsoft"};
            //Customer customer2 = new Customer { UserId = 3005, CompanyName = "Turkcell"};
            //Customer customer3 = new Customer { UserId = 3006, CompanyName = "Arcelik"};
            //Customer customer4 = new Customer { UserId = 3007, CompanyName = "FORD"};
            //Customer customer5 = new Customer { UserId = 3008, CompanyName = "TOFAŞK"};
            //Customer customer6 = new Customer { UserId = 3009, CompanyName = "Amazon"};
            //Customer customer7 = new Customer { UserId = 3010, CompanyName = "Apple"};
            //Customer customer8 = new Customer { UserId = 3011, CompanyName = "Microsoft"};
            //customerManager.Add(customer);
            //customerManager.Add(customer2);
            //customerManager.Add(customer3);
            //customerManager.Add(customer4);
            //customerManager.Add(customer5);
            //customerManager.Add(customer6);
            //customerManager.Add(customer7);
            //customerManager.Add(customer8);
            //LocalCustomerTest(customerManager);
            #endregion

            RentalManager rentalManager = new RentalManager(new EfRentalDal());
            #region Rental

            //DateTime dateTime = DateTime.Today;

            //Rental rental  = new Rental { CarId = 1, CustomerId = 1007, RentDate = dateTime, ReturnDate = dateTime.AddDays(2) };
            //Rental rental2 = new Rental { CarId = 3, CustomerId = 1005, RentDate = dateTime, ReturnDate = dateTime.AddDays(2) };
            //Rental rental3 = new Rental { CarId = 4, CustomerId = 2, RentDate = dateTime, ReturnDate = dateTime.AddDays(2) };
            //Rental rental4 = new Rental { CarId = 5, CustomerId = 1009, RentDate = dateTime, ReturnDate = dateTime.AddDays(2) };
            //Rental rental5 = new Rental { CarId = 6, CustomerId = 1009, RentDate = dateTime, ReturnDate = dateTime.AddDays(2) };
            //Rental rental6 = new Rental { CarId = 7, CustomerId = 1006, RentDate = dateTime, ReturnDate = dateTime.AddDays(2) };
            //Rental rental7 = new Rental { CarId = 1004, CustomerId = 1008, RentDate = dateTime, ReturnDate = dateTime.AddDays(2) };
            //Rental rental8 = new Rental { CarId = 1006, CustomerId = 1004, RentDate = dateTime, ReturnDate = dateTime.AddDays(2) };
            //rentalManager.Add(rental);
            //rentalManager.Add(rental2);
            //rentalManager.Add(rental3);
            //rentalManager.Add(rental4);
            //rentalManager.Add(rental5);
            //rentalManager.Add(rental6);
            //rentalManager.Add(rental7);
            //rentalManager.Add(rental8);


            LocalRentalTest(rentalManager);
            

            #endregion
        }

        private static void LocalRentalTest(RentalManager rentalManager)
        {
            var result = rentalManager.GetRentalCarDetails();
            if (result.Success)
            {
                Console.WriteLine("-----Rental Cars-----");
                foreach (var rental in result.Data)
                {
                    Console.WriteLine(
                        $"Rent Id:                      {rental.RentalId} \n" +
                        $"Customer Name:                {rental.CustomerFName} {rental.CustomerLName}\n" +
                        $"Customer Company Name:        {rental.CustomerCompanyName}\n" +
                        $"Car Brand:                    {rental.BrandName}\n" +
                        $"Rent Date:                    {rental.RentDate} - {rental.ReturnDate} \n" +
                        $"---------------------"
                    );
                }
                Console.WriteLine(result.Message);
            }
            else
            {
                Console.WriteLine(result.Message);
            }
        }

        private static void LocalUserTest(UserManager userManager)
        {
            var result = userManager.GetAll();
            if (result.Success)
            {
                Console.WriteLine($"User Info: \n");
                foreach (var user1 in result.Data)
                {
                    Console.WriteLine(
                        $"User Id:          {user1.Id} \n" +
                        $"User Name:        {user1.FirstName} \n" +
                        $"User E-Mail:      {user1.EMail}  \n" +
                        $"--------------------------------");
                }
                Console.WriteLine(result.Message);
            }
            else
            {
                Console.WriteLine(result.Message);
            }
        }

        private static void LocalCustomerTest(CustomerManager customerManager)
        {
            var result = customerManager.GetCustomerDetails();
            if (result.Success)
            {
                foreach (var customer in result.Data)
                {
                    Console.WriteLine($"customer Info: \n" +
                        $"Customer Id:                      {customer.CustomerId} \n" +
                        $"Customer of company name:         {customer.CompanyName} \n" +
                        $"Customer of full name:            {customer.UserFName} {customer.UserLName}\n" +
                        $"--------------------------------");
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }
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
                        $"Car Id:           {car.CarId} \n" +
                        $"Brand Name:       {car.BrandName} \n" +
                        $"Color Name:       {car.ColorName} \n" +
                        $"Daily Price:      {car.DailyPrice} \n" +
                        $"Car Description:  {car.Description}\n" +
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
