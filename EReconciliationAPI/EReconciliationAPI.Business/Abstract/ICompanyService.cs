using EReconciliationAPI.Core.Utilities.Results.Abstract;
using EReconciliationAPI.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EReconciliationAPI.Business.Abstract
{
    public interface ICompanyService
    {
        IResult Save (Company company);
        IDataResult<List<Company>> GetList();
    }
}
