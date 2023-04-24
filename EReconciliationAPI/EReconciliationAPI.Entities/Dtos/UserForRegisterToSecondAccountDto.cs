using EReconciliationAPI.Core.Entities;

namespace EReconciliationAPI.Entities.Dtos
{
    public class UserForRegisterToSecondAccountDto : UserForRegisterDto,IDto
    {
        public int CompanyId { get; set; }
    }
}
