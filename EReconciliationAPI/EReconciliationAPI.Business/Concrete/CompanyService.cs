using EReconciliationAPI.Business.Abstract;
using EReconciliationAPI.Business.Constants;
using EReconciliationAPI.Core.Utilities.Results.Abstract;
using EReconciliationAPI.Core.Utilities.Results.Concrete;
using EReconciliationAPI.DataAccess.Abstract;
using EReconciliationAPI.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EReconciliationAPI.Business.Concrete
{
    public class CompanyService : ICompanyService
    {
        private readonly ICompanyDal _companyDal;

        public CompanyService(ICompanyDal companyDal)
        {
            _companyDal = companyDal;
        }
        public IDataResult<List<Company>> GetList()
        {
            return new SuccessDataResult<List<Company>>(_companyDal.GetAll(),Messages.GetListCompany);
        }

        public IResult Save(Company company)
        {
            if (company.Name.Length > 10)
            {
                _companyDal.Add(company);
                return new SuccessResult(Messages.CompanySuccessfullySaved);
            }
            return new ErrorResult("Şirket Adı En Az 10 Karakter Olmalıdır!");
        }
    }
}
