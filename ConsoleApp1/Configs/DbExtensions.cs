using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Reflection.Emit;
using System.Runtime.CompilerServices;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public static class DbExtensions
    {
        public static void SeedData(this ModelBuilder builder)
        {
            builder.Entity<Country>().HasData(new[]
            {
                new Country() { Id = 1, Name = "Ukraine" },
                new Country() { Id = 2, Name = "USA" },
                new Country() { Id = 3, Name = "Poland" },
                new Country() { Id = 4, Name = "Switzerland" },
                new Country() { Id = 5, Name = "German" },
                new Country() { Id = 6, Name = "Turkey" },
                new Country() { Id = 7, Name = "Japan" },
                new Country() { Id = 8, Name = "China" },
                new Country() { Id = 9, Name = "Greenland" },
                new Country() { Id = 10, Name = "Iceland" },
                new Country() { Id = 11, Name = "UK" },
            });

            builder.Entity<City>().HasData(new[]
            {
                new City() { Id = 1, Name = "Rivne", CountryId = 1 },
                new City() { Id = 2, Name = "New York", CountryId = 2 },
                new City() { Id = 3, Name = "Katowice", CountryId = 3 },
                new City() { Id = 4, Name = "Geneva", CountryId = 4 },
                new City() { Id = 5, Name = "Gamburg", CountryId = 5 },
                new City() { Id = 6, Name = "Denzili", CountryId = 6 },
                new City() { Id = 7, Name = "Tokyo", CountryId = 7 },
                new City() { Id = 8, Name = "Hong Kong", CountryId = 8 },
                new City() { Id = 9, Name = "Nuuk", CountryId = 9 },
                new City() { Id = 10, Name = "Hofn", CountryId = 10 },
                new City() { Id = 11, Name = "London", CountryId = 11 },
            });



            builder.Entity<Category>().HasData(new[]
            {
                new Category() { Id = 1, Name = "Drink" },
                new Category() { Id = 2, Name = "Eat" },
                new Category() { Id = 3, Name = "Cloth" },
                new Category() { Id = 4, Name = "Electronic" },
                new Category() { Id = 5, Name = "For Home" },
            });

            builder.Entity<Position>().HasData(new[]
            {
                new Position() { Id = 1, Name = "Worker" },
                new Position() { Id = 2, Name = "Cashier" },
                new Position() { Id = 3, Name = "Sales Associate" },
                new Position() { Id = 4, Name = "Store Manager" }
            });

            builder.Entity<Products>().HasData(new[]
            {
                new Products() { Id = 1, Name = "Coca-Cola", CategoryId = 1, Price = 15, isinStock = true, Quantity = 100, Discount = 0 },
                new Products() { Id = 2, Name = "Pizza", CategoryId = 2, Price = 80, isinStock = true, Quantity = 50, Discount = 10 },
                new Products() { Id = 3, Name = "T-shirt", CategoryId = 3, Price = 120, isinStock = false, Quantity = 0, Discount = 0 },
                new Products() { Id = 4, Name = "Laptop", CategoryId = 4, Price = 15000, isinStock = true, Quantity = 10, Discount = 5 },
                new Products() { Id = 5, Name = "Sofa", CategoryId = 5, Price = 5000, isinStock = true, Quantity = 5, Discount = 15 },
                new Products() { Id = 6, Name = "Tea", CategoryId = 1, Price = 10, isinStock = true, Quantity = 200, Discount = 0 },
                new Products() { Id = 7, Name = "Burger", CategoryId = 2, Price = 60, isinStock = true, Quantity = 40, Discount = 0 },
            });

            builder.Entity<Shop>().HasData(new[]
            {
                new Shop() { Id = 1, Name = "MegaMarket", Address = "Soborna St. 12", CityId = 1, ParkingArea = 50 },
                new Shop() { Id = 2, Name = "Apple Store", Address = "5th Avenue, 767", CityId = 2, ParkingArea = 20 },
                new Shop() { Id = 3, Name = "Pizza Hut", Address = "ul. Warszawska, 5", CityId = 3, ParkingArea = 10 },
                new Shop() { Id = 4, Name = "IKEA", Address = "Route de Meyrin, 28", CityId = 4, ParkingArea = 100 },
                new Shop() { Id = 5, Name = "H&M", Address = "Mönckebergstraße, 11", CityId = 5, ParkingArea = 30 },
                new Shop() { Id = 6, Name = "Baklava House", Address = "Atatürk Bulvarı, 34", CityId = 6, ParkingArea = 15 },
            });

            builder.Entity<Worker>().HasData(new[]
            {
                new Worker() { Id = 1, Email = "james.smith@gmail.com", PhoneNumber = "123456", Name = "James", Surname = "Smith", Salary = 2500, ShopId = 1, PositionId = 1 },
                new Worker() { Id = 2, Email = "anna.jones@yahoo.com",  PhoneNumber = "123456",Name = "Anna", Surname = "Jones", Salary = 3000, ShopId = 2, PositionId = 3 },
                new Worker() { Id = 3, Email = "michael.brown@outlook.com",  PhoneNumber = "123456",Name = "Michael", Surname = "Brown", Salary = 2800, ShopId = 3, PositionId = 2 },
                new Worker() { Id = 4, Email = "sarah.wilson@icloud.com", PhoneNumber = "123456", Name = "Sarah", Surname = "Wilson", Salary = 3200, ShopId = 4, PositionId = 4 },
                new Worker() { Id = 5, Email = "david.lee@gmail.com", PhoneNumber = "123456", Name = "David", Surname = "Lee", Salary = 2700, ShopId = 5, PositionId = 1 },
                new Worker() { Id = 6, Email = "emma.williams@yahoo.com", PhoneNumber = "123456", Name = "Emma", Surname = "Williams", Salary = 3100, ShopId = 6, PositionId = 3 },
                new Worker() { Id = 7, Email = "john.davis@outlook.com", PhoneNumber = "123456", Name = "John", Surname = "Davis", Salary = 2900, ShopId = 1, PositionId = 2 },
                new Worker() { Id = 8, Email = "lisa.taylor@icloud.com",  PhoneNumber = "123456",Name = "Lisa", Surname = "Taylor", Salary = 3300, ShopId = 2, PositionId = 4 },
                new Worker() { Id = 9, Email = "robert.miller@gmail.com", PhoneNumber = "123456", Name = "Robert", Surname = "Miller", Salary = 2600, ShopId = 3, PositionId = 1 },
                new Worker() { Id = 10, Email= "mary.johnson@yahoo.com", PhoneNumber = "123456", Name= "Mary", Surname= "Johnson", Salary=3000, ShopId=4, PositionId=3 }
            });



        }
    }
}
