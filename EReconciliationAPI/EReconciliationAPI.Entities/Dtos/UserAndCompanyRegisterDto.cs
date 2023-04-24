using EReconciliationAPI.Core.Entities;
using EReconciliationAPI.Entities.Concrete;

namespace EReconciliationAPI.Entities.Dtos
{
    public class UserAndCompanyRegisterDto : IDto
    {
        public UserForRegisterDto userForRegister { get; set; }
        public Company company { get; set; }
    }
}
