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
    public class EfRentalDal : EfEntityRepositoryBase<Rental, ReCapDBContext>, IRentalDal
    {
        public List<RentalDetailDto> GetRentalDetails(Expression<Func<RentalDetailDto, bool>> filter = null)
        {
            using (ReCapDBContext context = new ReCapDBContext())
            {
                var result = from rental in context.Rentals
                             join car in context.Cars on rental.CarId equals car.Id
                             join customer in context.Customers on rental.CustomerId equals customer.CustomerId
                             join brand in context.Brands on car.BrandId equals brand.Id
                             join color in context.Colors on car.ColorId equals color.Id
                             join user in context.Users on customer.UserId equals user.Id
                             select new RentalDetailDto
                             {
                                 BrandId = brand.Id,
                                 ColorId = color.Id,
                                 CarId = car.Id,
                                 CustomerId = customer.CustomerId,
                                 BrandName = brand.BrandName,
                                 ColorName = color.ColorName,
                                 CarName = car.CarName,
                                 CustomerFirstName = user.FirstName,
                                 CustomerLastName = user.LastName,
                                 DailyPrice = car.DailyPrice,
                                 Description = car.Description,
                                 Email = user.Email,
                                 ModelYear = car.ModelYear,
                                 RentalId = rental.Id,
                                 RentDate = rental.RentDate,
                                 ReturnDate = rental.ReturnDate,
                                 CompanyName = customer.CompanyName
                            };
                return filter == null
                    ? result.ToList()
                    : result.Where(filter).ToList();

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