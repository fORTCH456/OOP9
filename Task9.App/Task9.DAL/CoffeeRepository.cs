using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task9.Model;

namespace Task9.DAL
{
    public class CoffeeRepository : ICoffeeRepository
    {
        private static List<Coffee> coffees;

        public CoffeeRepository()
        {
            if (coffees == null)
                LoadCoffees();
        }

        public Coffee GetCoffee()
        {
            return coffees.FirstOrDefault();
        }

        public List<Coffee> GetCoffees()
        {
            return coffees;
        }

        public Coffee GetCoffeeById(int id)
        {
            return coffees.FirstOrDefault(c => c.CoffeeId == id);
        }

        public void DeleteCoffee(Coffee coffee)
        {
            coffees.Remove(coffee);
        }

        public void UpdateCoffee(Coffee coffee)
        {
            var coffeeToUpdate = coffees.FirstOrDefault(c => c.CoffeeId == coffee.CoffeeId);
            if (coffeeToUpdate != null)
            {
                coffeeToUpdate.CoffeeName = coffee.CoffeeName;
                coffeeToUpdate.Description = coffee.Description;
                coffeeToUpdate.ImageId = coffee.ImageId;
                coffeeToUpdate.AmountInStock = coffee.AmountInStock;
                coffeeToUpdate.InStock = coffee.InStock;
                coffeeToUpdate.FirstAddedToStockDate = coffee.FirstAddedToStockDate;
                coffeeToUpdate.OriginCountry = coffee.OriginCountry;
                coffeeToUpdate.Price = coffee.Price;
            }
        }

        private void LoadCoffees()
        {
            coffees = new List<Coffee>()
            {
            new Coffee()
{
    CoffeeId = 1,
    CoffeeName = "Shimano Stella",
    Description = "Легендарная рыболовная катушка премиум-класса с плавным ходом и высокой надежностью.",
    ImageId = 1,
    AmountInStock = 15,
    InStock = true,
    FirstAddedToStockDate = new DateTime(2024, 3, 15),
    OriginCountry = Country.Япония,
    Price = 45000
},
new Coffee()
{
    CoffeeId = 2,
    CoffeeName = "Daiwa Tatula",
    Description = "Спиннинговое удилище с нанокарбоновым бланком для профессиональной ловли хищника.",
    ImageId = 2,
    AmountInStock = 8,
    InStock = true,
    FirstAddedToStockDate = new DateTime(2023, 11, 20),
    OriginCountry = Country.Япония,
    Price = 25000
},
new Coffee()
{
    CoffeeId = 3,
    CoffeeName = "Rapala X-Rap",
    Description = "Популярная серия воблеров с агрессивной игрой для ловли щуки и судака.",
    ImageId = 3,
    AmountInStock = 50,
    InStock = true,
    FirstAddedToStockDate = new DateTime(2024, 1, 10),
    OriginCountry = Country.Финляндия,
    Price = 1200
},
new Coffee()
{
    CoffeeId = 4,
    CoffeeName = "Garmin Striker",
    Description = "Эхолот с GPS навигацией и CHIRP-сонаром для точного определения рельефа дна.",
    ImageId = 4,
    AmountInStock = 5,
    InStock = true,
    FirstAddedToStockDate = new DateTime(2023, 9, 5),
    OriginCountry = Country.США,
    Price = 32000
},
new Coffee()
{
    CoffeeId = 5,
    CoffeeName = "Norfin Storm",
    Description = "Непромокаемый костюм для рыбалки с мембранной технологией и вентиляцией.",
    ImageId = 5,
    AmountInStock = 12,
    InStock = true,
    FirstAddedToStockDate = new DateTime(2024, 2, 28),
    OriginCountry = Country.Латвия,
    Price = 18000
},
new Coffee()
{
    CoffeeId = 6,
    CoffeeName = "Owner Hook",
    Description = "Премиальные рыболовные крючки из высокоуглеродистой стали с химической заточкой.",
    ImageId = 6,
    AmountInStock = 200,
    InStock = true,
    FirstAddedToStockDate = new DateTime(2024, 4, 10),
    OriginCountry = Country.Япония,
    Price = 500
},
new Coffee()
{
    CoffeeId = 7,
    CoffeeName = "Flambeau Tuff Krate",
    Description = "Прочный рыболовный ящик с системой организации снастей и аксессуаров.",
    ImageId = 7,
    AmountInStock = 7,
    InStock = true,
    FirstAddedToStockDate = new DateTime(2023, 12, 15),
    OriginCountry = Country.США,
    Price = 9000
}

        };
        }
    }
}
