using EReconciliationAPI.Core.Entities.Concrete;
using EReconciliationAPI.Core.Utilities.Results.Abstract;
using EReconciliationAPI.Entities.Concrete;
using EReconciliationAPI.Entities.Dtos;

namespace EReconciliationAPI.Business.Abstract
{
    public interface ICompanyService
    {
        IResult Add (Company company);
        IResult Update (Company company);
        IResult AddCompanyAndUserCompany (CompanyDto companyDto);
        IDataResult<Company> GetById(int id);
        IDataResult<List<Company>> GetList();
        IDataResult<UserCompany> GetCompany(int userId);
        IResult CompanyExists(Company company);
        IResult UserCompanyAdd(int userId, int companyId);
    }
}
