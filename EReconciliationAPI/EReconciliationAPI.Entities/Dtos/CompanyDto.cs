using EReconciliationAPI.Entities.Concrete;

namespace EReconciliationAPI.Entities.Dtos;

public class CompanyDto
{
    public Company Company { get; set; }
    public int UserId { get; set; }
}
