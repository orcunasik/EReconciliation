using EReconciliationAPI.Entities.Concrete;

namespace EReconciliationAPI.Entities.Dtos
{
    public class UserAndCompanyRegisterDto
    {
        public UserForRegisterDto userForRegister { get; set; }
        public Company company { get; set; }
    }
}
