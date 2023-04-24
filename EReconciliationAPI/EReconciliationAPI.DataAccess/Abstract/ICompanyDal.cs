using EReconciliationAPI.Core.DataAccess;
using EReconciliationAPI.Core.Entities.Concrete;
using EReconciliationAPI.Entities.Concrete;

namespace EReconciliationAPI.DataAccess.Abstract
{
    public interface ICompanyDal : IEntityRepository<Company>
    {
        void UserCompanyAdd(int userId, int companyId);
        UserCompany GetCompany(int userId);
    }
}
