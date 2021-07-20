using Business.Concretes;
using DataAccess.Concretes.InMemory;
using Entity.Concretes;
using System;
using System.Collections.Generic;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new InMemoryCarDal());

            Car car = new Car() { Id = 6, BrandId = 7, ColorId = 3, ModelYear = 2000, DailyPrice = 5, Description = "Dosta Gider" };


            //carManager.Add(car);
            //carManager.Delete(car);
            //
            //carManager.Add(car);
            //carManager.Update(new Car() { Id = 6, BrandId = 7, ColorId = 3, ModelYear = 2000, DailyPrice = 5, Description = "Dosta Gider2" });
            //

            List<Car> result = carManager.GetById(4);

            Console.WriteLine(result[0].Description);


            foreach (var item in carManager.GetAll())
            {
                Console.WriteLine(item.Description);
            }
        }
    }
}
