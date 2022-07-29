using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IRentalService
    {
        IResult Add(Rental rent);
        IResult Update(Rental rent);
        IResult Delete(Rental rent);
        IDataResult<List<Rental>> GetAll();
    }
}
