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
        IDataResult<User> RegisterSecondAccount(UserForRegisterDto userForRegister, string password);
        IDataResult<User> Login(UserForLoginDto userForLogin);
        IResult UserExists(string email);
        IResult CompanyExists(Company company);
        IDataResult<AccessToken> CreateAccessToken(User user,int companyId);
    }
}
