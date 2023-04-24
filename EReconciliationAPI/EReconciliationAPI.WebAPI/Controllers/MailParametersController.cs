using EReconciliationAPI.Business.Abstract;
using EReconciliationAPI.Entities.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace EReconciliationAPI.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MailParametersController : ControllerBase
    {
        private readonly IMailParameterService _mailparameterService;

        public MailParametersController(IMailParameterService mailparameterService)
        {
            _mailparameterService = mailparameterService;
        }

        [HttpPost("update")]
        public IActionResult MailParameter(MailParameter mailParameter)
        {
            var result = _mailparameterService.Update(mailParameter);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result.Message);
        }
    }
}
