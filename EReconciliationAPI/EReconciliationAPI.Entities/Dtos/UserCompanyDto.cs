using EReconciliationAPI.Core.Entities.Concrete;

namespace EReconciliationAPI.Entities.Dtos
{
    public class UserCompanyDto : User
    {
        public int CompanyId { get; set; }
    }
}
