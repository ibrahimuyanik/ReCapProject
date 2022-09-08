using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class RentalManager: IRentalService
    {
        IRentalDal _rentalDal;

        public RentalManager(IRentalDal rentalDal)
        {
            _rentalDal = rentalDal;
        }

        public IResult Add(Rental rental)
        {
            //1. Yol
            //List<Rental> rentalsByCarId = _rentalDal.GetAll(r => r.CarId == rental.CarId);
            //var lastItem = rentalsByCarId.Last();

            //if (lastItem.ReturnDate != null)
            //{
            //    _rentalDal.Add(rental);
            //    return new SuccessResult("Eklendi");
            //}

            //return new ErrorResult("Eklenemedi"); 


            //2.yol
            var checkRent = _rentalDal.GetAll(r => r.CarId == rental.CarId);
    
	        foreach (var rent in checkRent) 
            {
                if (rent.ReturnDate.Equals(null)) 
                {
                    return new ErrorResult("Eklenemedi"); 
                }
            }
            _rentalDal.Add(rental);
            return new SuccessResult("Eklendi");
        }

        public IResult Delete(Rental rental)
        {
            _rentalDal.Delete(rental);
            return new SuccessResult();
        }

        public IDataResult<List<Rental>> GetAll()
        {
            return new SuccessDataResult<List<Rental>>(_rentalDal.GetAll());
        }

        public IDataResult<Rental> GetById(int id)
        {
            return new SuccessDataResult<Rental>(_rentalDal.Get(r => r.Id == id));
        }

        public IResult Update(Rental rental)
        {
            _rentalDal.Update(rental);
            return new SuccessResult();
        }
    }
}
