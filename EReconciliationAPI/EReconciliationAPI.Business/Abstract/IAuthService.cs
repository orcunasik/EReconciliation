using EReconciliationAPI.Core.Entities.Concrete;
using EReconciliationAPI.Core.Utilities.Results.Abstract;
using EReconciliationAPI.Core.Utilities.Security.JWT;
using EReconciliationAPI.Entities.Concrete;
using EReconciliationAPI.Entities.Dtos;

namespace EReconciliationAPI.Business.Abstract
{
    public interface IAuthService
    {
        IDataResult<UserCompanyDto> Register(UserForRegisterDto userForRegister, string password, Company company);
        IDataResult<User> RegisterSecondAccount(UserForRegisterDto userForRegister, string password, int companyId);
        IDataResult<User> Login(UserForLoginDto userForLogin);
        IDataResult<User> GetByMailConfirmValue(string value);
        IDataResult<User> GetById(int id);
        IResult UserExists(string email);
        IResult Update(User user);
        IResult CompanyExists(Company company);
        IResult SendConfirmEmail(User user);
        IDataResult<AccessToken> CreateAccessToken(User user,int companyId);
        IDataResult<UserCompany> GetCompany(int userId);
    }
}
