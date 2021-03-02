using Business.Concrete;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleUI
{
    class Program
    {
        public static object CarManager { get; private set; }

        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new InMemoryCarDal());

            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine("Araba modeli : " + car.Description + "Günlük kiralama fiyatı : " + car.DailyPrice );
            }

            
        }
    }
}
