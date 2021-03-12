using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;
using System.Collections.Generic;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //------------------Araç işlemleri-------------------
            //CarManager carManager = new CarManager(new EfCarDal());
            //Yeni araç ekle
            /*
            Car car1 = new Car
            {
                BrandId=1,ColorId=1,ModelYear=2016,DailyPrice=300,Description="Mercedes A180",CarId=6
            };
            carManager.Add(car1);
            */
            //Araç Güncelle
            /*
            Car car2 = new Car 
            { 
                CarId = 6, BrandId = 2, ColorId = 2, DailyPrice = 400, Description = "Wolksvagen Tiguan" 
            };
            carManager.Update(car2);
            */
            //Araç sil
            /*
            Car car3 = new Car
            {
                CarId = 6
            };
            carManager.Delete(car3);
            */
            //User işlemleri
            UserManager userManager = new UserManager(new EfUserDal());
            //User ekle
            /*
            User user1 = new User
            {
                UserId=1,
                FirstName = "Hasan",
                LastName = "ÖZ",
                Email="hasanozz2002@gmail.com",
                Password="123789hasan"
                
                
            };
            userManager.Add(user1);
            */

            



        }
    }
}
