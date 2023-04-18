using EReconciliationAPI.Core.Entities.Concrete;

namespace EReconciliationAPI.Core.Utilities.Security.JWT
{
    public interface ITokenHelper
    {
        AccessToken CreateToken(User user, List<OperationClaim> operationClaims, int companyId);
    }
}
