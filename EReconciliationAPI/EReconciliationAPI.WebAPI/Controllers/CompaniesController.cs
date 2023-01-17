using EReconciliationAPI.Business.Abstract;
using EReconciliationAPI.Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EReconciliationAPI.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CompaniesController : ControllerBase
    {
        private readonly ICompanyService _companyService;

        public CompaniesController(ICompanyService companyService)
        {
            _companyService = companyService;
        }
        [HttpGet("companyList")]
        public IActionResult GetCompanyList()
        {
            var result = _companyService.GetList();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result.Message);
        }

        [HttpPost("addCompany")]
        public IActionResult AddCompany(Company company)
        {
            var result = _companyService.Save(company);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result.Message);
        }
    }
}
