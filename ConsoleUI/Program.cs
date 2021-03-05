using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using System;



namespace ConsoleUI
{
    class Program
    {
        public static object CarManager { get; private set; }

        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new EfCarDal());

            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine("Araba İsmi : "+ car.Description);
            }

            

            

        }
    }
}
