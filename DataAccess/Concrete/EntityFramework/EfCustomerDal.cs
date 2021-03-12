using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCustomerDal:EfEntityRepositoryBase<Customer, CarDBContext>, ICustomerDal
    {
        

        public List<CustomerDetailDto> GetCustomerDetails(Expression<Func<Customer, bool>> filter = null)
        {
            using (CarDBContext context = new CarDBContext())
            {
                var result = from c in filter is null ? context.Customers : context.Customers.Where(filter)
                             join u in context.Users on c.UserId equals u.UserId
                             select new CustomerDetailDto
                             {
                                 CustomerId = c.CustomerId,
                                 UserId = u.UserId,
                                 UserName = u.FirstName,
                                 UserLastName = u.LastName,
                                 CompanyName = c.CompanyName
                             };
                return result.ToList();
            }
        }

        public List<CustomerDetailDto> GetCustomerDetails()
        {
            throw new NotImplementedException();
        }
    }
}
