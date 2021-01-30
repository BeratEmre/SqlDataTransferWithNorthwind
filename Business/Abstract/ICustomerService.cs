using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICustomerService
    {
        IDataResult<Customer> GetById(int customerId);
        IDataResult<List<Customer>> GetList();
        IResult Add(Customer product);
        IResult Delete(Customer product);
        IResult Update(Customer product);
    }
}
