using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfRentalDal : EfEntityRepositoryBase<Rental, ReCapDBContext>, IRentalDal
    {
        public List<RentalDetailDto> GetRentalDetails()
        {
            using (ReCapDBContext context = new ReCapDBContext())
            {
                var result = from rental in context.Rentals join
                             car in context.Cars on rental.CarId equals car.Id
                             join brand in context.Brands on car.BrandId equals brand.Id
                             join customer in context.Customers on rental.CustomerId equals customer.CustomerId
                             join user in context.Users on
                             customer.UserId equals user.Id
                             select new RentalDetailDto 
                             {
                                 BrandName = brand.BrandName,
                                 CarName = car.CarName,
                                 CustomerFullName = user.FirstName + " " + user.LastName
                             };
                return result.ToList();
                             
            }
        }
    }
}
/*
 *      select BrandName, CarName, FirstName+' '+ LastName 'CustomerFullName' from Rentals inner join Cars on
        Rentals.CarId = Cars.Id inner join Brands on 
        Cars.BrandId = Brands.Id inner join Customers on 
        Rentals.CustomerId = Customers.CustomerId inner join Users on
        Customers.UserId = Users.Id
 *
 */