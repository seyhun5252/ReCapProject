using Core.Utilities.Results.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ICreditCartService
    {
        IDataResult<IList<CreditCart>> GetAll();
        IDataResult<CreditCart> GetByCustomerId(int customerId);
        IResult Add(CreditCart creditCart);
        IResult Payment();
    }
}
