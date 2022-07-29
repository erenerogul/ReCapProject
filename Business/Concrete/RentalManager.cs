using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class RentalManager : IRentalService
    {
        IRentalDal _rentalDal;
        public RentalManager(IRentalDal rentalDal)
        {
            _rentalDal = rentalDal; 
        }
        public IResult Add(Rental rent)
        {
            var result = _rentalDal.GetAll(p=>p.CarId == rent.CarId && (p.RentDate == null||p.ReturnDate>rent.RentDate));
            if(result == null)
            {
                _rentalDal.Add(rent);
                return new SuccessResult();
            }
            else
            {
                return new ErrorResult();
            }
            
        }

        public IResult Delete(Rental rent)
        {
            _rentalDal.Delete(rent);
            return new SuccessResult();
        }

        public IDataResult<List<Rental>> GetAll()
        {
            return new SuccessDataResult<List<Rental>>(_rentalDal.GetAll());
        }

        public IResult Update(Rental rent)
        {
            _rentalDal.Update(rent);
            return new SuccessResult();
        }
    }
}
