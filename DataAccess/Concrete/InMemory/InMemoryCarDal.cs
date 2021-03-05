/*
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
                new Car{CarId=1,BrandId=1,ColorId=1,Brand="Mercedes",Color="Beyaz",DailyPrice=600,ModelYear=2015,Description="Mercedes C180"},
                new Car{CarId=2,BrandId=2,ColorId=2,Brand="Wolkswagen",Color="Siyah",DailyPrice=700,ModelYear=2017,Description="Wolkswagen Passat"},
                new Car{CarId=3,BrandId=2,ColorId=3,Brand="Wolkswagen",Color="Mavi",DailyPrice=550,ModelYear=2013,Description="Wolkswagen Golf"},
                new Car{CarId=4,BrandId=3,ColorId=1,Brand="Renault",Color="Beyaz",DailyPrice=350,ModelYear=2010,Description="Renault Clio"},
                new Car{CarId=5,BrandId=3,ColorId=4,Brand="Renault",Color="Gri",DailyPrice=400,ModelYear=2011,Description="Renault Megane"}

            };

        }
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {

            Car carToDelete = _cars.SingleOrDefault(c => c.CarId == car.CarId);
            _cars.Remove(carToDelete);

        }

        public List<Car> GetAll()
        {

            return _cars;

        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetById(int CarId)
        {

            return _cars.Where(c => c.CarId == CarId).ToList();

        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.CarId == car.CarId);
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
            carToUpdate.ModelYear = car.ModelYear;
        }
    }
}
*/
