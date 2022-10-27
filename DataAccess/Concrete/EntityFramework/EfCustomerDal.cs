using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCustomerDal : EfEntityRepositoryBase<Customer, ReCapDBContext>, ICustomerDal
    {
        public List<CustomerDetailDto> GetCustomerDetails(Expression<Func<CustomerDetailDto, bool>> filter = null)
        {
            using (ReCapDBContext context = new ReCapDBContext())
            {
                var result = from c in context.Customers
                             join
                             u in context.Users on c.UserId equals u.Id
                             select new CustomerDetailDto
                             {
                                 CustomerId = c.CustomerId,
                                 UserId = c.UserId,
                                 CompanyName = c.CompanyName,
                                 CustomerFirstName = u.FirstName,
                                 CustomerLastName = u.LastName,
                                 Email = u.Email,
                                 Status = (bool)u.Status
                             };
                return filter == null
                    ? result.ToList()
                    : result.Where(filter).ToList();
            }
        }
    }
}
