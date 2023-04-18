using EReconciliationAPI.Core.Entities.Concrete;
using EReconciliationAPI.Core.Utilities.Results.Abstract;
using EReconciliationAPI.Core.Utilities.Security.JWT;
using EReconciliationAPI.Entities.Dtos;

namespace EReconciliationAPI.Business.Abstract
{
    public interface IAuthService
    {
        IDataResult<User> Register(UserForRegisterDto userForRegister, string password);
        IDataResult<User> Login(UserForLoginDto userForLogin);
        IResult UserExists(string email);
        IDataResult<AccessToken> CreateAccessToken(User user,int companyId);
    }
}
