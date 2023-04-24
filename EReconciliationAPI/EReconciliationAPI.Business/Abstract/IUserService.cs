using EReconciliationAPI.Core.Entities.Concrete;

namespace EReconciliationAPI.Business.Abstract
{
    public interface IUserService
    {
        List<OperationClaim> GetClaims(User user, int companyId);
        void Add(User user);
        void Update(User user);
        User GetByMail(string email);
        User GetById(int id);
        User GetByMailConfrimValue(string value);
    }
}
