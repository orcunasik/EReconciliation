using EReconciliationAPI.Business.Abstract;
using EReconciliationAPI.Business.Constants;
using EReconciliationAPI.Business.ValidationRules.FluentValidation;
using EReconciliationAPI.Core.Aspects.Autofac.Validation;
using EReconciliationAPI.Core.Entities.Concrete;
using EReconciliationAPI.Core.Utilities.Results.Abstract;
using EReconciliationAPI.Core.Utilities.Results.Concrete;
using EReconciliationAPI.DataAccess.Abstract;
using EReconciliationAPI.Entities.Concrete;

namespace EReconciliationAPI.Business.Concrete
{
    public class CompanyService : ICompanyService
    {
        private readonly ICompanyDal _companyDal;

        public CompanyService(ICompanyDal companyDal)
        {
            _companyDal = companyDal;
        }

        public IResult CompanyExists(Company company)
        {
            var result = _companyDal.Get(c => c.Name == company.Name && c.TaxDepartment == company.TaxDepartment && c.TaxIdNumber == company.TaxIdNumber && c.IdentityNumber == company.IdentityNumber);
            if (result is not null)
            {
                return new ErrorResult(Messages.CompanyAlreadyExists);
            }
            return new SuccessResult();
        }

        public IDataResult<List<Company>> GetList()
        {
            return new SuccessDataResult<List<Company>>(_companyDal.GetAll(),Messages.GetListCompany);
        }

        [ValidationAspect(typeof(CompanyValidator))]
        public IResult Add(Company company)
        {
            _companyDal.Add(company);
            return new SuccessResult(Messages.CompanySuccessfullySaved);
        }

        public IResult UserCompanyAdd(int userId, int companyId)
        {
            _companyDal.UserCompanyAdd(userId, companyId);
            return new SuccessResult();
        }

        public IDataResult<UserCompany> GetCompany(int userId)
        {
            return new SuccessDataResult<UserCompany>(_companyDal.GetCompany(userId));
        }
    }
}
