using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IRentalService
    {
        IDataResult<List<RentalDetailDto>> GetRentalDetails();
        IDataResult<Rental> GetByID(int ID);
        IDataResult<List<Rental>> GetByCarID(int ID);
        IDataResult<List<Rental>> GetByCustomerID(int ID);
        IDataResult<List<Rental>> GetByRentDate(DateTime rentdate);
        IDataResult<List<Rental>> GetByReturnDate(DateTime returndate);
        IDataResult<List<Rental>> GetAll();
        IResult Add(Rental rental);
        IResult Update(Rental rental);
        IResult Delete(Rental rental);
    }
}
