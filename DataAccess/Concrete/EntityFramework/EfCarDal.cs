using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Linq.Expressions;
using Core.DataAccess.EntityFramework;
using Entities.Dtos;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : EfEntityRepositoryBase<Car, CarDBContext>, ICarDal
    {
        public List<CarDetailDto> GetCarDetails()
        {
            using (CarDBContext context = new CarDBContext())
            {
                var result = from c in context.Cars
                             join b in context.Brands on c.BrandId equals b.BrandId
                             join color in context.Colors on c.ColorId equals color.ColorId
                             select new CarDetailDto
                             {
                                 BrandName = b.BrandName,
                                 CarName = c.Description,
                                 ColorName = color.ColorName,
                                 DailyPrice = c.DailyPrice
                             };
                return result.ToList();
            }
        }


    }
}
