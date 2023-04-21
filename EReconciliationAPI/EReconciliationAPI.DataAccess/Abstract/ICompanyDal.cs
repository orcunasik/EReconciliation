using EReconciliationAPI.Core.DataAccess;
using EReconciliationAPI.Entities.Concrete;

namespace EReconciliationAPI.DataAccess.Abstract
{
    public interface ICompanyDal : IEntityRepository<Company>
    {
        void UserCompanyAdd(int userId, int companyId);
    }
}
